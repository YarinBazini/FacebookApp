using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserGroupsController : UserControl, ITab
    {
        public AppManager Manager { get; }

        public UserGroupsController()
        {
            InitializeComponent();
            Manager = AppManager.Instance;
        }

        public void FetchData()
        {
            m_ListBoxGroups.Invoke(new Action(() => m_ListBoxGroups.Items.Clear()));
            m_LabelError.Invoke(new Action(() => m_LabelError.Visible = false));
            try
            {
                foreach (Group group in Manager.UserGroups)
                {
                    m_ListBoxGroups.Invoke(new Action(() => m_ListBoxGroups.Items.Add(group)));
                }

                if (m_ListBoxGroups.Items.Count == 0)
                {
                    m_ListBoxGroups.Invoke(new Action(() => m_ListBoxGroups.Items.Add("You doesn't have groups to show")));
                }
            }
            catch (Exception exception)
            {
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = true));
            }
        }

        private void m_ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displaySelectedGroup();
            }
            catch (Exception exception)
            {
                m_LabelError.Visible = true;
            }
        }

        private void displaySelectedGroup()
        {
            Group selectedGroup;

            if (m_ListBoxGroups.SelectedItems.Count == 1)
            {
                selectedGroup = m_ListBoxGroups.SelectedItem as Group;
                if (selectedGroup != null)
                {
                    m_PanelGroupDetails.Visible = true;
                    m_LabelGroupName.Text = selectedGroup.Name;
                    m_LabelGroupPrivacy.Text = selectedGroup.Privacy.ToString();
                    m_LabelGroupDescription.Text = selectedGroup.Description;
                    m_PictureBoxGroupPicture.LoadAsync(selectedGroup.IconUrl);
                }
            }
        }
    }
}
