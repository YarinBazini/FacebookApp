using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class GroupsFacade
    {
        private FacebookObjectCollection<Group> m_Groups;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public GroupsFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        public FacebookObjectCollection<Group> Groups 
        { 
            get
            {
                fetchData();

                return m_Groups;
            }
        }

        private void fetchData()
        {
            if (!m_DataFetched)
            {
                m_Groups = r_AppManager.UserGroups;
                m_DataFetched = true;
            }
        }
    }
}
