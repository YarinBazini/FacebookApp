using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class StatisticsFacade 
    {
        private StatisticsManager m_StatisticsManager;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public StatisticsFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_StatisticsManager = r_AppManager.Statistics;
                m_DataFetched = true;
            }
        }

        public Dictionary<int, int> GetYearToPostCountDict()
        {
            fetchData();

            return m_StatisticsManager.GetYearToPostCountDict();
        }

        public List<int> GetAllYearsWithPosts()
        {
            fetchData();

            return m_StatisticsManager.GetAllYearsWithPosts();
        }

        public YearSummery GetSummeryByYear(int i_Year)
        {
            fetchData();

            return m_StatisticsManager.GetSummeryByYear(i_Year);
        }

        public Dictionary<int, int> GetGraph(Func<Post, int> i_Starategy)
        {
            fetchData();

            return m_StatisticsManager.GetGraph(i_Starategy);
        }
    }
}
