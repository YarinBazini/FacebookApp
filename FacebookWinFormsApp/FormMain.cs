using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookAppLogic;
using System.Threading;
using System.Collections.Generic;

namespace FacebookAppGUI
{
    public partial class FormMain : Form
    {
        public AppManager Manager { get; }
        public Dictionary<TabsFactory.TabType, ITab> Tabs { get; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            Manager = AppManager.Instance;
            Tabs = new Dictionary<TabsFactory.TabType, ITab>();
            initTabsDictionary();
            conectControlersToUITabs();
        }

        private void initTabsDictionary()
        {
            Tabs.Add(TabsFactory.TabType.PostsTab, TabsFactory.Create(TabsFactory.TabType.PostsTab));
            Tabs.Add(TabsFactory.TabType.AboutTab, TabsFactory.Create(TabsFactory.TabType.AboutTab));
            Tabs.Add(TabsFactory.TabType.PhotosTab, TabsFactory.Create(TabsFactory.TabType.PhotosTab));
            Tabs.Add(TabsFactory.TabType.GroupsTab, TabsFactory.Create(TabsFactory.TabType.GroupsTab));
            Tabs.Add(TabsFactory.TabType.LikesPagesTab, TabsFactory.Create(TabsFactory.TabType.LikesPagesTab));
            Tabs.Add(TabsFactory.TabType.PostsGameTab, TabsFactory.Create(TabsFactory.TabType.PostsGameTab));
            Tabs.Add(TabsFactory.TabType.UserStatisticsTab, TabsFactory.Create(TabsFactory.TabType.UserStatisticsTab));
        }

        private void conectControlersToUITabs()
        {
            m_TabPosts.Controls.Add(Tabs[TabsFactory.TabType.PostsTab] as UserControl);
            m_TabAbout.Controls.Add(Tabs[TabsFactory.TabType.AboutTab] as UserControl);
            m_TabPhotos.Controls.Add(Tabs[TabsFactory.TabType.PhotosTab] as UserControl);
            m_TabGroups.Controls.Add(Tabs[TabsFactory.TabType.GroupsTab] as UserControl);
            m_TabLikedPages.Controls.Add(Tabs[TabsFactory.TabType.LikesPagesTab] as UserControl);
            m_TabPagePostsGame.Controls.Add(Tabs[TabsFactory.TabType.PostsGameTab] as UserControl);
            m_TabPageStatistics.Controls.Add(Tabs[TabsFactory.TabType.UserStatisticsTab] as UserControl);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                m_LabelLoading.Visible = true;
                m_LabelErrorBeforLogin.Visible = false;
                Manager.Login();
                setUserFacebookPage();
                new Thread(fetchUserData).Start();
                m_LabelLoading.Visible = false;
            }
            catch (Exception exception)
            {
                m_LabelLoading.Visible = false;
                MessageBox.Show(exception.Message, "Login Failed");
            }
        }

        private void setUserFacebookPage()
        {
            m_PictureBoxUserProfie.LoadAsync(Manager.GetUserProfilePicture());
            m_LabelUserName.Text = Manager.GetUserName();
            checkIfCoverPhotoExistAndShow();
            showRelevantComponents();
        }

        private void showRelevantComponents()
        {
            m_LabelErrorBeforLogin.Visible = false;
            m_TabsFacebookApp.Visible = true;
            m_ButtonLogin.Visible = false;
            m_ButtonLogout.Visible = true;
            m_PictureBoxUserCover.Visible = true;
            m_LabelUserName.Visible = true;
            m_PictureBoxUserProfie.Visible = true;
        }

        private void hideRelevantComponents()
        {
            m_LabelErrorBeforLogin.Visible = true;
            m_TabsFacebookApp.Visible = false;
            m_ButtonLogin.Visible = true;
            m_ButtonLogout.Visible = false;
            m_PictureBoxUserCover.Visible = false;
            m_LabelUserName.Visible = false;
            m_PictureBoxUserProfie.Visible = false;
            m_LabelCoverPhotoError.Visible = false;
        }

        private void fetchUserData()
        {
            try
            {
                List<Thread> fetchThreads = new List<Thread>();
                Thread current;

                foreach (KeyValuePair< TabsFactory.TabType, ITab> entry in Tabs)
                {
                    if (entry.Key != TabsFactory.TabType.UserStatisticsTab && entry.Key != TabsFactory.TabType.PostsGameTab)
                    {
                        current =  new Thread(entry.Value.FetchData);
                        fetchThreads.Add(current);
                        current.Start();
                    }
                }

                foreach(Thread thread in fetchThreads)
                {
                    thread.Join();
                }

                Tabs[TabsFactory.TabType.UserStatisticsTab].FetchData();
                Tabs[TabsFactory.TabType.PostsGameTab].FetchData();
            }
            catch (Exception exception)
            { }
        }

        private void checkIfCoverPhotoExistAndShow()
        {
            string coverPictureUrl;

            if (Manager.CheckIfCoverPhotoExistAndReturnUrl(out coverPictureUrl))
            {
                m_LabelCoverPhotoError.Visible = false;
                m_PictureBoxUserCover.LoadAsync(coverPictureUrl);
            }
            else
            {
                m_LabelCoverPhotoError.Visible = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Manager.Logout();
            hideRelevantComponents();
        }
    }
}
