using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class PostsFacade: Facade
    {
        private FacebookObjectCollection<Post> m_Posts;
        public PostsFacade()
        {
        }
        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_Posts;
            }
        }

        protected override void fetchData()
        {
            m_Posts = r_AppManager.UserPosts;
        }
    }
}
