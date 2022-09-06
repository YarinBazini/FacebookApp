using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class StatisticsPageFacade : Facade
    {
        private StatisticsManager m_StatisticsManager;
        public StatisticsPageFacade()
        {
        }

        protected override void fetchData()
        {
            m_StatisticsManager = r_AppManager.Statistics;
        }

        public Dictionary<int, int> GetYearToPostCountDict()
        {
            fetchDataIfDidntFetchAlready();
            return m_StatisticsManager.GetYearToPostCountDict();
        }

        public List<int> GetAllYearsWithPosts()
        {
            fetchDataIfDidntFetchAlready();
            return m_StatisticsManager.GetAllYearsWithPosts();
        }

        public YearSummery GetSummeryByYear(int i_Year)
        {
            fetchDataIfDidntFetchAlready();
            return m_StatisticsManager.GetSummeryByYear(i_Year);
        }
    }
}
