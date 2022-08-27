using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class PostsGame
    {
        private readonly List<UserPost> r_Posts = new List<UserPost>();
        private int m_BestScore;
        private int m_CurrentGameScore;
        private const int k_NumOfQuestionsPerGame = 5;
        private const int k_ScorePerRightAnswer = 1;
        private int m_CurrentGameQuestionCounter;
        private readonly Random r_Generator;
        private bool m_UserCanPlay;
        private bool m_IsGameOver;

        public PostsGame(FacebookObjectCollection<Post> i_Posts)
        {
            filterReleventPostsForGame(i_Posts);
            m_UserCanPlay = r_Posts.Count != 0;
            r_Generator = new Random();
            m_BestScore = 0;
            m_CurrentGameQuestionCounter = 0;
            m_CurrentGameScore = 0;
            m_IsGameOver = false;
        }

        public bool UserCanPlay
        {
            get
            {
                return m_UserCanPlay;
            }
        }

        public PostsGameQuestion GetQuestion()
        {
            int postIndex = r_Generator.Next(r_Posts.Count);
            DateTime rightTimePosted;
            
            while (r_Posts[postIndex].CreatedTime == null)
            {
                postIndex = r_Generator.Next(r_Posts.Count);
            }

            rightTimePosted = (DateTime)r_Posts[postIndex].CreatedTime;
            m_CurrentGameQuestionCounter++;
            if (m_CurrentGameQuestionCounter == k_NumOfQuestionsPerGame)
            {
                m_IsGameOver = true;
            }

            return new PostsGameQuestion(rightTimePosted, r_Posts[postIndex].Content);
        }

        public void StartNewGame()
        {
            if (m_CurrentGameScore > m_BestScore)
            {
                m_BestScore = m_CurrentGameScore;
            }

            m_CurrentGameScore = 0;
            m_CurrentGameQuestionCounter = 0;
            m_IsGameOver = false;
        }

        private void filterReleventPostsForGame(FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                if (post.Message != null && post.CreatedTime != null)
                {
                    r_Posts.Add(new UserPost {Content = post.Message, CreatedTime = (DateTime)post.CreatedTime });
                }
                else if (post.Caption != null && post.CreatedTime != null)
                {
                    r_Posts.Add(new UserPost { Content = post.Caption, CreatedTime = (DateTime)post.CreatedTime });
                }
            }
        }

        public int BestScore
        {
            get
            {
                return m_BestScore;
            }
        }

        public int CurrentScore
        {
            get
            {
                return m_CurrentGameScore;
            }
        }

        public void IncreaseScore()
        {
            m_CurrentGameScore += k_ScorePerRightAnswer;
        }

        public bool IsGameOver
        {
            get
            {
                return m_IsGameOver;
            }
        }

        public int QuestionCounter
        {
            get
            {
                return m_CurrentGameQuestionCounter;
            }
        }

        public int QuestionsPerGame
        {
            get
            {
                return k_NumOfQuestionsPerGame;
            }
        }
    }
}
