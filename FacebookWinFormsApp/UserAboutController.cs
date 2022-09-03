using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserAboutController : UserControl, ITab
    {
        public AppManager Manager { get; }

        public UserAboutController()
        {
            InitializeComponent();
            Manager = AppManager.Instance;
        }

        public void FetchData()
        {
            m_LabelFirstName.Invoke(new Action(() => m_LabelFirstName.Text = Manager.LoggedInUser.FirstName));
            m_LabelFirstName.Invoke(new Action(() => m_LabelLastName.Text = Manager.LoggedInUser.LastName));
            m_LabelFirstName.Invoke(new Action(() => m_LabelGender.Text = Manager.LoggedInUser.Gender.ToString()));
            m_LabelFirstName.Invoke(new Action(() => m_LabelBirthday.Text = Manager.LoggedInUser.Birthday.ToString()));
            m_LabelFirstName.Invoke(new Action(() => m_LabelEmail.Text = Manager.LoggedInUser.Email.ToString()));
            m_LabelFirstName.Invoke(new Action(() => m_LabelRelationshipStatus.Text = Manager.LoggedInUser.RelationshipStatus.ToString()));
            m_LabelFirstName.Invoke(new Action(() => m_LabelFacebookId.Text = Manager.LoggedInUser.Id));
        }
    }
}
