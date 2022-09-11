using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class LikedPagesFacade
    {
        private FacebookObjectCollection<Page> m_LikedPages;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public LikedPagesFacade()
        {
            r_AppManager = AppManager.Instance;
        }
        
        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                fetchData();

                return m_LikedPages;
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
    }
}
