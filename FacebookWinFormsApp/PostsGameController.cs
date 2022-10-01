using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class PostsGameController : UserControl, ITab
    {
        private PostsGameQuestion m_CurrentQuestion;
        public PostGameFacade Facade { get; }

        public PostsGameController()
        {
            InitializeComponent();
            Facade = new PostGameFacade();
        }

        public void FetchData()
        {
            if (!Facade.UserCanPlay)
            {
                m_LabelErrorMessage.Invoke(new Action(() => m_LabelErrorMessage.Visible = true));
                m_ButtonNewGame.Invoke(new Action(() => m_ButtonNewGame.Enabled = false));
            }
            else
            { 
                Invoke(new Action(()=> setAllControls()));
            }
        }

        private void m_ButtonNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                m_LabelError.Visible = false;
                Facade.StartNewGame();
                m_CurrentQuestion = Facade.GetQuestion();
                m_PanelPostsGame.Visible = true;
                setAllControls();
            }
            catch (Exception exception)
            {
                m_LabelError.Visible = true;
            }
        }

        private void setAllControls()
        {
            List<DateTime> answers = new List<DateTime>();

            m_LabelLastResult.Visible = false;
            m_ButtonNextQuestion.Visible = false;
            m_LabelScore.Text = "Score: " + Facade.CurrentScore.ToString();
            m_LabelBestScore.Text = "Best Score: " + Facade.BestScore.ToString();
            m_LabelNumberOfQuestion.Text = Facade.QuestionCounter.ToString() + "/" + Facade.QuestionsPerGame.ToString();
            if (m_CurrentQuestion != null)
            {
                m_LabelPost.Text = m_CurrentQuestion.PostQuestionContent;
                answers = m_CurrentQuestion.GetShuffledAnswers();
                m_ButtonAnswer1.Text = answers[0].ToString("MM/dd/yyyy");
                m_ButtonAnswer2.Text = answers[1].ToString("MM/dd/yyyy");
                m_ButtonAnswer3.Text = answers[2].ToString("MM/dd/yyyy");
                m_ButtonAnswer4.Text = answers[3].ToString("MM/dd/yyyy");
            }
        }

        private void m_ButtonAnswer_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (m_CurrentQuestion.CheckAnswer(clickedButton.Text))
            {
                Facade.IncreaseScore();
                m_LabelLastResult.Text = "Correct answer!";
            }
            else
            {
                m_LabelLastResult.Text = "Wrong answer!";
            }

            m_LabelLastResult.Visible = true;
            m_ButtonNextQuestion.Visible = true;
        }

        private void m_ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                m_LabelError.Visible = false;
                if (!Facade.IsGameOver)
                {
                    m_CurrentQuestion = Facade.GetQuestion();
                }
                else
                {
                    m_PanelPostsGame.Visible = false;
                }

                setAllControls();
            }
            catch (Exception exception)
            {
                m_LabelError.Visible = true;
            }
        }
    }
}
