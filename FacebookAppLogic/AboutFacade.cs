using System.ComponentModel;

namespace FacebookAppLogic
{
    public class AboutFacade : INotifyPropertyChanged
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
        private int m_BestGameScore;
        public event PropertyChangedEventHandler PropertyChanged;

        public AboutFacade()
        {
            r_AppManager = AppManager.Instance;
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
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

        public int BestGameScore
        {
            get
            {
                fetchData();

                return m_BestGameScore;
            }
            set
            {
                if (m_BestGameScore != value)
                {
                    m_BestGameScore = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("BestGameScore"));
                }
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
                m_BestGameScore = r_AppManager.PostsGame().BestScore;
                r_AppManager.PostsGame().PropertyChanged += new PropertyChangedEventHandler(onUpdateBestScore);
                m_DataFetched = true;
            }
        }

        private void onUpdateBestScore(object sender, PropertyChangedEventArgs e)
        {
            BestGameScore = r_AppManager.PostsGame().BestScore;
        }
    }
}


