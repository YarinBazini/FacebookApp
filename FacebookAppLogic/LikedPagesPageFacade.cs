using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class LikedPagesPageFacade : Facade
    {
        private FacebookObjectCollection<Page> m_LikedPages;
        public LikedPagesPageFacade()
        {
        }
        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_LikedPages;
            }
        }

        protected override void fetchData()
        {
            m_LikedPages = r_AppManager.UserLikedPages;
        }
    }
}
