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
        public StatisticsFacade Facade { get; }

        public UserStatisticsController()
        {
            InitializeComponent();
            Facade = new StatisticsFacade();
        }

        public void FetchData()
        {
            new Thread(initYearsComboBox).Start();
            new Thread(initBarChart).Start();
        }

        private void initBarChart()
        {
            try
            {
                foreach (KeyValuePair<int, int> entry in Facade.GetYearToPostCountDict())
                {
                    m_ChartYearsToPost.Invoke(new Action(() => m_ChartYearsToPost.Series["Posts Amaunt"].Points.AddXY(entry.Key, entry.Value)));
                }
            }
            catch(Exception exception)
            { }
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
            this.Invoke(new Action(() => updateYearPanel()));
            this.Invoke(new Action(() => resetUserSelectedData()));
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
    }
}
