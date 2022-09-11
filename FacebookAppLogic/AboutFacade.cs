namespace FacebookAppLogic
{
    public class AboutFacade
    {
        private string m_FirstName;
        private string m_LastName;
        private string m_Birthday;
        private string m_Gender;
        private string m_Email;
        private string m_RelationshipStatus;
        private string m_FacebookId;
        private readonly AppManager r_AppManager;
        private bool m_DataFetched = false;

        public AboutFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        public string FirstName
        {
            get
            {
                fetchData();

                return m_FirstName;
            }
        }

        public string LastName
        {
            get
            {
                fetchData();

                return m_LastName;
            }
        }

        public string Gender
        {
            get
            {
                fetchData();

                return m_Gender;
            }
        }

        public string Birthday
        {
            get
            {
                fetchData();

                return m_Birthday;
            }
        }

        public string Email
        {
            get
            {
                fetchData();

                return m_Email;
            }
        }

        public string RelationshipStatus
        {
            get
            {
                fetchData();

                return m_RelationshipStatus;
            }
        }

        public string FacebookId
        {
            get
            {
                fetchData();

                return m_FacebookId;
            }
        }

        private void fetchData() 
        {
            if (!m_DataFetched)
            {
                m_FirstName = r_AppManager.LoggedInUser.FirstName;
                m_LastName = r_AppManager.LoggedInUser.LastName;
                m_Gender = r_AppManager.LoggedInUser.Gender.ToString();
                m_Birthday = r_AppManager.LoggedInUser.Birthday.ToString();
                m_Email = r_AppManager.LoggedInUser.Email.ToString();
                m_RelationshipStatus = r_AppManager.LoggedInUser.RelationshipStatus.ToString();
                m_FacebookId = r_AppManager.LoggedInUser.Id;
                m_DataFetched = true;
            }
        }
    }
}


