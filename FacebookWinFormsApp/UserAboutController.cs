using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserAboutController : UserControl, ITab
    {
        public AboutFacade Facade { get; }

        public UserAboutController()
        {
            InitializeComponent();
            Facade = new AboutFacade();
        }

        public void FetchData()
        {
            m_LabelFirstName.Invoke(new Action(() => m_LabelFirstName.Text = Facade.FirstName));
            m_LabelFirstName.Invoke(new Action(() => m_LabelLastName.Text = Facade.LastName));
            m_LabelFirstName.Invoke(new Action(() => m_LabelGender.Text = Facade.Gender));
            m_LabelFirstName.Invoke(new Action(() => m_LabelBirthday.Text = Facade.Birthday));
            m_LabelFirstName.Invoke(new Action(() => m_LabelEmail.Text = Facade.Email));
            m_LabelFirstName.Invoke(new Action(() => m_LabelRelationshipStatus.Text = Facade.RelationshipStatus));
            m_LabelFirstName.Invoke(new Action(() => m_LabelFacebookId.Text = Facade.FacebookId));
            m_LabelBestScore.Invoke(new Action(() => m_LabelBestScore.Text = Facade.BestGameScore.ToString()));
            Facade.PropertyChanged += new PropertyChangedEventHandler(updateBestScore);
        }

        private void updateBestScore(object sender, PropertyChangedEventArgs e)
        {
            m_LabelBestScore.Invoke(new Action(() => m_LabelBestScore.Text = Facade.BestGameScore.ToString()));
        }
    }
}
