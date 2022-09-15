using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class GroupsFacade : IEnumerable<Group>
    {
        private FacebookObjectCollection<Group> m_Groups;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public GroupsFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        public int Count 
        {
            get
            {
                fetchData();

                return m_Groups.Count;
            }
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

        public IEnumerator<Group> GetEnumerator()
        {
            fetchData();
            foreach (Group group in m_Groups)
            {
                yield return group;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
