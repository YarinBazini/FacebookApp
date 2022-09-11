﻿using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostsFacade
    {
        private FacebookObjectCollection<Post> m_Posts;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public PostsFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                fetchData();

                return m_Posts;
            }
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_Posts = r_AppManager.UserPosts;
                m_DataFetched = true;
            }
        }
    }
}
