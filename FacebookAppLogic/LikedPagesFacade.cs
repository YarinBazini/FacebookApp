using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class LikedPagesFacade : IEnumerable<Page>
    {
        private FacebookObjectCollection<Page> m_LikedPages;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public LikedPagesFacade()
        {
            r_AppManager = AppManager.Instance;
        }
        
        public int Count
        {
            get
            {
                fetchData();

                return m_LikedPages.Count;
            }
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_LikedPages = r_AppManager.UserLikedPages;
                m_DataFetched = true;
            }
        }

        public IEnumerator<Page> GetEnumerator()
        {
            fetchData();
            foreach (Page page in m_LikedPages)
            {
                yield return page;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
