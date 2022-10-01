using System.ComponentModel;

namespace FacebookAppLogic
{
    public class PostGameFacade : INotifyPropertyChanged
    {
        private PostsGame m_PostGame;
        private readonly AppManager r_AppManager;
        private int m_BestScore;
        private bool m_DataFetched = false;
        public event PropertyChangedEventHandler PropertyChanged;

        public PostGameFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_PostGame = r_AppManager.PostsGame();
                m_PostGame.PropertyChanged += new PropertyChangedEventHandler(updateBestScore);
                m_BestScore = m_PostGame.BestScore;
                m_DataFetched = true;
            }
        }

        private void updateBestScore(object sender, PropertyChangedEventArgs e)
        {
            BestScore = m_PostGame.BestScore;
        }

        public bool UserCanPlay
        {
            get
            {
                fetchData();

                return m_PostGame.UserCanPlay;
            }
        }

        public void StartNewGame()
        {
            m_PostGame.StartNewGame();
        }

        public int CurrentScore 
        {
            get
            {
                fetchData();

                return m_PostGame.CurrentScore;
            }
        }

        public int BestScore
        {
            get
            {
                fetchData();

                return m_BestScore;
            }
            set
            {
                m_BestScore = value;
                OnPropertyChanged(new PropertyChangedEventArgs("BestGameScore"));
            }
        }

        public int QuestionCounter
        {
            get
            {
                fetchData();

                return m_PostGame.QuestionCounter;
            }
        }

        public int QuestionsPerGame
        {
            get
            {
                fetchData();

                return m_PostGame.QuestionsPerGame;
            }
        }

        public bool IsGameOver 
        {
            get
            {
                fetchData();

                return m_PostGame.IsGameOver;
            }
        }

        public PostsGameQuestion GetQuestion()
        {
            return m_PostGame.GetQuestion();
        }

        public void IncreaseScore()
        {
            m_PostGame.IncreaseScore();
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
