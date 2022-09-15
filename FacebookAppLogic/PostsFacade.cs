using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class PostsFacade: IEnumerable<Post>
    {
        private FacebookObjectCollection<Post> m_Posts;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public PostsFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_Posts = r_AppManager.UserPosts;
                m_DataFetched = true;
            }
        }

        public IEnumerator<Post> GetEnumerator()
        {
            fetchData();
            foreach (Post post in m_Posts)
            {
                yield return post;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
