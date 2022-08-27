﻿using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserAboutController : UserControl
    {
        private readonly AppManager r_AppManager;

        public UserAboutController(AppManager i_AppManager)
        {
            InitializeComponent();
            r_AppManager = i_AppManager;
        }

        public void FetchUserAboutData()
        {
            m_LabelFirstName.Text = r_AppManager.LoggedInUser.FirstName;
            m_LabelLastName.Text = r_AppManager.LoggedInUser.LastName;
            m_LabelGender.Text = r_AppManager.LoggedInUser.Gender.ToString();
            m_LabelBirthday.Text = r_AppManager.LoggedInUser.Birthday.ToString();
            m_LabelEmail.Text = r_AppManager.LoggedInUser.Email.ToString();
            m_LabelRelationshipStatus.Text = r_AppManager.LoggedInUser.RelationshipStatus.ToString();
            m_LabelFacebookId.Text = r_AppManager.LoggedInUser.Id;
        }
    }
}
