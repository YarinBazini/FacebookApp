using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PhotosFacade
    {
        private FacebookObjectCollection<Album> m_Albums;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public PhotosFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                fetchData();

                return m_Albums;
            }
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_Albums = r_AppManager.UserPhotoAlbums;
                m_DataFetched = true;
            }
        }
    }
}
