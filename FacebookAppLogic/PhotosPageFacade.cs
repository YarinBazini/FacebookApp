using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class PhotosPageFacade : Facade
    {
        private FacebookObjectCollection<Album> m_Albums;
        public PhotosPageFacade()
        {
        }
        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_Albums;
            }
        }

        protected override void fetchData()
        {
            m_Albums = r_AppManager.UserPhotoAlbums;
        }
    }
}
