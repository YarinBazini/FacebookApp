using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class GroupsPageFacade: Facade
    {
        private FacebookObjectCollection<Group> m_Groups;
        public GroupsPageFacade()
        {
        }
        public FacebookObjectCollection<Group> Groups 
        { 
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_Groups;
            }
        }
        
        protected override void fetchData()
        {
            m_Groups = r_AppManager.UserGroups;
        }
    }
}
