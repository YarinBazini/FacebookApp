using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserStatisticsController : UserControl, ITab
    {
        private YearSummery m_SelectedYearSummery;
        private Post m_SelectedPost;
        private Dictionary<RadioButton, Func<Post, int>> m_RadioButtons;
        public StatisticsFacade Facade { get; }

        public UserStatisticsController()
        {
            InitializeComponent();
            Facade = new StatisticsFacade();
            initRadioButtonsDict();
        }

        public void FetchData()
        {
            new Thread(initYearsComboBox).Start();
            new Thread(() => setBarChart(Facade.GetGraph(m_RadioButtons[m_RadioButtonPosts]))).Start();
        }

        private void initRadioButtonsDict()
        {
            m_RadioButtons = new Dictionary<RadioButton, Func<Post, int>>();
            m_RadioButtons.Add(m_RadioButtonPosts, (Post post) => 1);
            m_RadioButtons.Add(m_RadioButtonComments, (Post post) => post.Comments.Count);
            m_RadioButtons.Add(m_RadioButtonLikes, (Post post) => post.LikedBy.Count);
        }

        private void initYearsComboBox()
        {
            try
            {
                foreach (int year in Facade.GetAllYearsWithPosts())
                {
                    m_ComboBoxYears.Invoke(new Action(() => m_ComboBoxYears.Items.Add(year)));
                }
            }
            catch(Exception exception)
            { }
        }

        private void m_ButtonShow_Click(object sender, EventArgs e)
        {
            Button showButton = sender as Button;

            showButton.Visible = false;
            m_PanelStatistics.Visible = true;
        }

        private void m_ComboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox yearsComboBox = sender as ComboBox;
            int year = (int)yearsComboBox.Items[yearsComboBox.SelectedIndex];

            new Thread(() => fetchSelectedYeadData(year)).Start();
        }

        private void fetchSelectedYeadData(int i_Year)
        {
            m_LabelWait.Invoke(new Action(() => m_LabelWait.Visible = true));
            m_SelectedYearSummery = Facade.GetSummeryByYear(i_Year);
            m_LabelWait.Invoke(new Action(() => m_LabelWait.Visible = false));
            Invoke(new Action(() => updateYearPanel()));
            Invoke(new Action(() => resetUserSelectedData()));
        }

        private void resetUserSelectedData()
        {
            m_LabelSelectesUserPost.Text = "";
            m_RadioButtonTopCommentPost.Checked = false;
            m_RadioButtonTopLikedPost.Checked = false;
            m_RadioButtonWorstCommentsPost.Checked = false;
            m_RadioButtonWorstLikesPost.Checked = false;
        }

        private void updateYearPanel()
        {
            if (m_SelectedYearSummery != null)
            {
                m_PanelYearSummery.Visible = true;
                m_LabelYear.Text = "Year: " + m_SelectedYearSummery.Year.ToString();
                m_LabelNumOfLikes.Text = "Total Likes: " + m_SelectedYearSummery.NumOfLikes.ToString();
                m_LabelNumOfComments.Text = "Total Comments: " + m_SelectedYearSummery.NumOfComments.ToString();
            }
            else
            {
                m_PanelYearSummery.Visible = false;
            }
        }

        private void m_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButtonSender = sender as RadioButton;

            if (radioButtonSender.Checked == true)
            {
                if (radioButtonSender.Equals(m_RadioButtonTopCommentPost))
                {
                    m_SelectedPost = m_SelectedYearSummery.TopCommentedPost;
                }
                else if (radioButtonSender.Equals(m_RadioButtonTopLikedPost))
                {
                    m_SelectedPost = m_SelectedYearSummery.TopLikedPost;
                }
                else if (radioButtonSender.Equals(m_RadioButtonWorstLikesPost))
                {
                    m_SelectedPost = m_SelectedYearSummery.WorstLikedPost;
                }
                else if (radioButtonSender.Equals(m_RadioButtonWorstCommentsPost))
                {
                    m_SelectedPost = m_SelectedYearSummery.WorstCommenedtPost;
                }

                new Thread(updateSelectedPost).Start();
            }
        }

        private void updateSelectedPost()
        {
            if (m_SelectedPost != null)
            {
                if (m_SelectedPost.Message != null)
                {
                    m_LabelSelectesUserPost.Invoke(new Action(() => m_LabelSelectesUserPost.Text = m_SelectedPost.Message));
                }
                else if (m_SelectedPost.Caption != null)
                {
                    m_LabelSelectesUserPost.Invoke(new Action(() => m_LabelSelectesUserPost.Text = m_SelectedPost.Caption));
                }
                else
                {
                    m_LabelSelectesUserPost.Invoke(new Action(() => m_LabelSelectesUserPost.Text = string.Format("[{0}]", m_SelectedPost.Type)));
                }
            }
        }

        private void setComponentstsForCalculateGraph()
        {
            m_LabelGraphCalculate.Visible = true;
            m_RadioButtonLikes.Enabled = false;
            m_RadioButtonPosts.Enabled = false;
            m_RadioButtonComments.Enabled = false;
        }

        private void setBarChart(Dictionary<int, int> i_Graph)
        {
            try
            {
                m_ChartYearsToPost.Invoke(new Action(() => m_ChartYearsToPost.Series.Clear()));
                m_ChartYearsToPost.Invoke(new Action(() => m_ChartYearsToPost.Series.Add("Graph")));
                foreach (KeyValuePair<int, int> entry in i_Graph)
                {
                    m_ChartYearsToPost.Invoke(new Action(() => m_ChartYearsToPost.Series["Graph"].Points.AddXY(entry.Key, entry.Value)));
                }

                m_LabelGraphCalculate.Invoke(new Action(() => m_LabelGraphCalculate.Visible = false));
                m_RadioButtonPosts.Invoke(new Action(() => m_RadioButtonPosts.Enabled = true));
                m_RadioButtonLikes.Invoke(new Action(() => m_RadioButtonLikes.Enabled = true));
                m_RadioButtonComments.Invoke(new Action(() => m_RadioButtonComments.Enabled = true));
            }
            catch(Exception exception)
            { }
        }

        private void m_RadioButtonGraph_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;

            if (button.Checked)
            {
                setComponentstsForCalculateGraph();
                new Thread(() => setBarChart(Facade.GetGraph(m_RadioButtons[button]))).Start();
            }
        }
    }
}
