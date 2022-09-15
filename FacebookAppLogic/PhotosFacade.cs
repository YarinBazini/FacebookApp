using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class PhotosFacade : IEnumerable<Album>
    {
        private FacebookObjectCollection<Album> m_Albums;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public PhotosFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_Albums = r_AppManager.UserPhotoAlbums;
                m_DataFetched = true;
            }
        }

        public IEnumerator<Album> GetEnumerator()
        {
            fetchData();
            foreach (Album album in m_Albums)
            {
                yield return album;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
