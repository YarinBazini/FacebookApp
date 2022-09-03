using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookAppLogic;
using System.Threading;

namespace FacebookAppGUI
{
    public partial class FormMain : Form
    {
        private readonly AppManager r_AppManager;
        private readonly UserPostsController r_UserPostController;
        private readonly UserAboutController r_UserAboutController;
        private readonly UserPhotosController r_UserPhotosController;
        private readonly UserGroupsController r_UserGroupsController;
        private readonly UserLikedPagesController r_UserLikedPagesController;
        private readonly PostsGameController r_PostsGameController;
        private readonly UserStatisticsController r_UserStatisticsController;
         
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_AppManager = AppManager.Instance;
            r_UserPostController = new UserPostsController(r_AppManager);
            r_UserAboutController = new UserAboutController(r_AppManager);
            r_UserPhotosController = new UserPhotosController(r_AppManager);
            r_UserGroupsController = new UserGroupsController(r_AppManager);
            r_UserLikedPagesController = new UserLikedPagesController(r_AppManager);
            r_PostsGameController = new PostsGameController(r_AppManager);
            r_UserStatisticsController = new UserStatisticsController(r_AppManager);
            conectControlersToUITabs();
        }

        private void conectControlersToUITabs()
        {
            this.m_TabPosts.Controls.Add(r_UserPostController);
            this.m_TabAbout.Controls.Add(r_UserAboutController);
            this.m_TabPhotos.Controls.Add(r_UserPhotosController);
            this.m_TabGroups.Controls.Add(r_UserGroupsController);
            this.m_TabLikedPages.Controls.Add(r_UserLikedPagesController);
            this.m_TabPagePostsGame.Controls.Add(r_PostsGameController);
            this.m_TabPageStatistics.Controls.Add(r_UserStatisticsController);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                m_LabelLoading.Visible = true;
                m_LabelErrorBeforLogin.Visible = false;
                r_AppManager.Login();
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
            m_PictureBoxUserProfie.LoadAsync(r_AppManager.GetUserProfilePicture());
            m_LabelUserName.Text = r_AppManager.GetUserName();
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
                new Thread(fetchUserPosts).Start();
                new Thread(fetchUserAboutData).Start();
                new Thread(fetchUserPhotos).Start();
                new Thread(fetchUserGroups).Start();
                new Thread(fetchUserLikePages).Start();
                fetchUserPostsGame();
            }
            catch (Exception exception)
            { }
        }

        private void fetchUserPostsGame()
        {
            r_PostsGameController.FetchGameData();
        }

        private void fetchUserLikePages()
        {
            r_UserLikedPagesController.FetchUserLikePages();
        }

        private void fetchUserGroups()
        {
            r_UserGroupsController.FetchUserGroups();
        }

        private void fetchUserPhotos()
        {
            r_UserPhotosController.FetchUserPhotos();
        }

        private void fetchUserAboutData()
        {
            r_UserAboutController.FetchUserAboutData();
        }

        private void fetchUserPosts()
        {
             r_UserPostController.FetchUserPosts();
        }

        private void checkIfCoverPhotoExistAndShow()
        {
            string coverPictureUrl;

            if (r_AppManager.CheckIfCoverPhotoExistAndReturnUrl(out coverPictureUrl))
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
            r_AppManager.Logout();
            hideRelevantComponents();
        }
    }
}
