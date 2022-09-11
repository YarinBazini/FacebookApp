namespace FacebookAppLogic
{
    public class PostGameFacade
    {
        private PostsGame m_PostGame;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public PostGameFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_PostGame = r_AppManager.PostsGame();
                m_DataFetched = true;
            }
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

                return m_PostGame.BestScore;
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
    }
}
