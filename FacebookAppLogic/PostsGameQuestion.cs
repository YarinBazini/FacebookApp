using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class PostsGameQuestion
    {
        private readonly string r_post;
        private readonly DateTime r_RightAnswer;
        private readonly List<DateTime> r_WrongAnswers;
        private const int k_NumOfAnswers = 4;
        private readonly Random r_Generator;

        public PostsGameQuestion(DateTime i_RightAnswer, string i_post)
        {
            r_Generator = new Random();
            r_post = i_post;
            r_RightAnswer = i_RightAnswer;
            r_WrongAnswers = new List<DateTime>();
            initWrongAnswers(r_RightAnswer);
        }

        public bool CheckAnswer(string i_Answer)
        {
            return i_Answer == r_RightAnswer.ToString("MM/dd/yyyy");
        }

        public List<DateTime> GetShuffledAnswers()
        {
            List<DateTime> shuffledAnswers = new List<DateTime>(k_NumOfAnswers);

            shuffledAnswers.Add(r_RightAnswer);
            for (int i = 0; i < r_WrongAnswers.Count; i++)
            {
                shuffledAnswers.Add(r_WrongAnswers[i]);
            }

            shuffleList(shuffledAnswers);

            return shuffledAnswers;
        }

        private void shuffleList(List<DateTime> i_List)
        {
            int range = i_List.Count -1;
            int randomIndex;

            while (range > 0)
            {
                randomIndex = r_Generator.Next(range);
                swap(i_List, randomIndex, range);
                range--;
            }
        }

        private void swap(List<DateTime> i_Answers, int i_Index1, int i_Index2)
        {
            DateTime tempDate = i_Answers[i_Index1];

            i_Answers[i_Index1] = i_Answers[i_Index2];
            i_Answers[i_Index2] = tempDate;
        }

        private void initWrongAnswers(DateTime i_RightAnswer)
        {
            int answersCounter = 0;
            DateTime randomDate;

            while (answersCounter < k_NumOfAnswers - 1)
            {
                randomDate = getRandomDate();
                if (randomDate != i_RightAnswer)
                {
                    answersCounter++;
                    r_WrongAnswers.Add(randomDate);
                }
            }
        }

        private DateTime getRandomDate()
        {
            DateTime startDate = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - startDate).Days;

            return startDate.AddDays(r_Generator.Next(range));
        }

        public string PostQuestionContent
        {
            get
            {
                return r_post;
            }
        }
    }
}
