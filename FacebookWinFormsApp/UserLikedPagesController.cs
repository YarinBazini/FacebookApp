using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserLikedPagesController : UserControl
    {
        private readonly AppManager r_AppManager;

        public UserLikedPagesController(AppManager i_AppManager)
        {
            InitializeComponent();
            r_AppManager = i_AppManager;
        }

        public void FetchUserLikePages()
        {
            try
            {
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = false));
                m_ListBoxLikePages.Invoke(new Action(() => m_ListBoxLikePages.Items.Clear()));
                foreach (Page page in r_AppManager.UserLikedPages)
                {
                    m_ListBoxLikePages.Invoke(new Action(() => m_ListBoxLikePages.Items.Add(page)));
                }

                if (m_ListBoxLikePages.Items.Count == 0)
                {
                    m_ListBoxLikePages.Invoke(new Action(() => m_ListBoxLikePages.Items.Add("You doesn't have like pages to show")));
                }
            }
            catch (Exception exception)
            {
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = true));
            }
        }

        private void m_ListBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedLikePage();
        }

        private void displaySelectedLikePage()
        {
            try
            {
                Page selectedLikePage;

                m_LabelError.Visible = false;
                if (m_ListBoxLikePages.SelectedItems.Count == 1)
                {
                    selectedLikePage = m_ListBoxLikePages.SelectedItem as Page;
                    if (selectedLikePage != null)
                    {
                        m_PanelLikePages.Visible = true;
                        m_LabelLikePageName.Text = selectedLikePage.Name;
                        m_PictureBoxLikePagesPicture.LoadAsync(selectedLikePage.PictureNormalURL);
                    }
                }
            }
            catch (Exception exception)
            {
                m_LabelError.Visible = true;
            }
        }
    }
}
