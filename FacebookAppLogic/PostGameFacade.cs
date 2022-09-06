using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class PostGameFacade : Facade
    {
        private PostsGame m_PostGame;
        
        public PostGameFacade()
        {
        }

        protected override void fetchData()
        {
            m_PostGame = r_AppManager.PostsGame();
        }

        public bool UserCanPlay
        {
            get
            {
                fetchDataIfDidntFetchAlready();

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
                fetchDataIfDidntFetchAlready();

                return m_PostGame.CurrentScore;
            }
        }

        public int BestScore
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_PostGame.BestScore;
            }
        }

        public int QuestionCounter
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_PostGame.QuestionCounter;
            }
        }

        public int QuestionsPerGame
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_PostGame.QuestionsPerGame;
            }
        }

        public bool IsGameOver 
        {
            get
            {
                fetchDataIfDidntFetchAlready();

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
