using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public class AboutPageFacade: Facade
    {
        
        private string m_FirstName;
        private string m_LastName;
        private string m_Birthday;
        private string m_Gender;
        private string m_Email;
        private string m_RelationshipStatus;
        private string m_FacebookId;

        public string FirstName
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_FirstName;
            }
        }

        public string LastName
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_LastName;
            }
        }

        public string Gender
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_Gender;
            }
        }

        public string Birthday
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_Birthday;
            }
        }

        public string Email
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_Email;
            }
        }

        public string RelationshipStatus
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_RelationshipStatus;
            }
        }

        public string FacebookId
        {
            get
            {
                fetchDataIfDidntFetchAlready();

                return m_FacebookId;
            }
        }

        public AboutPageFacade()
        {
        }

        override protected void fetchData() 
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


