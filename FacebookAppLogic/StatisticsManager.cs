using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class StatisticsManager
    {
        private readonly Dictionary<int, List<Post>> r_PostToYearDict = new Dictionary<int, List<Post>>();
        private readonly Dictionary<int, YearSummery> r_YearToSummery = new Dictionary<int, YearSummery>();
        private readonly Random r_Random = new Random();
        
        public StatisticsManager(FacebookObjectCollection<Post> i_Posts)
        {
            try
            {
                foreach (Post post in i_Posts)
                {
                    if (post.CreatedTime != null)
                    {
                        if (!r_PostToYearDict.ContainsKey(((DateTime)post.CreatedTime).Year))
                        {
                            r_PostToYearDict[((DateTime)post.CreatedTime).Year] = new List<Post>();
                        }

                        r_PostToYearDict[((DateTime)post.CreatedTime).Year].Add(post);
                    }
                }
            }
            catch (Exception exception)
            {
                throw new FetchException("Fetch exception in StatisticsManager.");
            }
        }

        public YearSummery GetSummeryByYear(int i_Year)
        {
            YearSummery yearSummery = null;

            if (r_PostToYearDict.ContainsKey(i_Year))
            {
                if (r_YearToSummery.ContainsKey(i_Year))
                {
                    yearSummery = r_YearToSummery[i_Year];
                }
                else
                {
                    r_YearToSummery[i_Year] = new YearSummery(r_PostToYearDict[i_Year] , i_Year);
                    yearSummery = r_YearToSummery[i_Year];
                }
            }

            return yearSummery;
        }

        public Dictionary<int, int> GetGraph(Func<Post, int> i_Starategy)
        {
            Dictionary<int, int> yearToPostCount = new Dictionary<int, int>();
            int tempCount = 0;

            foreach (KeyValuePair<int, List<Post>> entry in r_PostToYearDict)
            {
                foreach (Post post in entry.Value)
                {
                    try
                    {
                        tempCount += i_Starategy(post);
                    }
                    catch(Exception e)
                    {
                        tempCount += generateNumber();
                    }
                }

                yearToPostCount[entry.Key] = tempCount;
                tempCount = 0;
            }

            return yearToPostCount;
        }

        public List<int> GetAllYearsWithPosts()
        {
            return new List<int>(r_PostToYearDict.Keys);
        }

        public Dictionary<int, int> GetYearToPostCountDict()
        {
            Dictionary<int, int> yearToPostCount = new Dictionary<int, int>();

            foreach (KeyValuePair<int, List<Post>> entry in r_PostToYearDict)
            {
                yearToPostCount[entry.Key] = entry.Value.Count;
            }

            return yearToPostCount;
        }

        private int generateNumber()
        {
            return r_Random.Next(0, 20);
        }
    }
}
