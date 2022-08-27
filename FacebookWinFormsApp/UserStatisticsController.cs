using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserStatisticsController : UserControl
    {
        private readonly AppManager r_AppManager;
        private YearSummery m_SelectedYearSummery;
        private Post m_SelectedPost;

        public UserStatisticsController(AppManager i_AppManager)
        {
            InitializeComponent();
            r_AppManager = i_AppManager;
        }

        private void initBarChart()
        {
            foreach (KeyValuePair<int, int> entry in r_AppManager.Statistics.GetYearToPostCountDict())
            {
                m_ChartYearsToPost.Series["Posts Amaunt"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        private void initYearsComboBox()
        {
            foreach (int year in r_AppManager.Statistics.GetAllYearsWithPosts())
            {
                m_ComboBoxYears.Items.Add(year);
            }
        }

        private void m_ButtonShow_Click(object sender, EventArgs e)
        {
            Button showButton = sender as Button;

            showButton.Visible = false;
            m_PanelStatistics.Visible = true;
            initAllComponents();
        }

        private void initAllComponents()
        {
            initYearsComboBox();
            initBarChart();
        }

        private void m_ComboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox yearsComboBox = sender as ComboBox;

            m_LabelWait.Visible = true;
            m_SelectedYearSummery = r_AppManager.Statistics.GetSummeryByYear((int)yearsComboBox.Items[yearsComboBox.SelectedIndex]);
            m_LabelWait.Visible = false;
            updateYearPanel();
            resetUserSelectedData();
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

                updateSelectedPost();
            }
        }

        private void updateSelectedPost()
        {
            if (m_SelectedPost != null)
            {
                if (m_SelectedPost.Message != null)
                {
                    m_LabelSelectesUserPost.Text = m_SelectedPost.Message;
                }
                else if (m_SelectedPost.Caption != null)
                {
                    m_LabelSelectesUserPost.Text = m_SelectedPost.Caption;
                }
                else
                {
                    m_LabelSelectesUserPost.Text = string.Format("[{0}]", m_SelectedPost.Type);
                }
            }
        }
    }
}
