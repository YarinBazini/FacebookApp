using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.IO;

namespace FacebookAppLogic
{
    public sealed class AppManager
    {
        private static AppManager s_AppManagerInstance = null;
        private static object s_LockObj = new object();
        private const string k_AccessTokenFilePath = "AccessToken.txt";
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private string m_AccessToken;
        private PostsGame m_PostsGame;
        private StatisticsManager m_StatisticsManager;
        private const string k_AppID = "599927405011335";

        private AppManager()
        {}

        public static AppManager Instance 
        { 
            get
            {
                if (s_AppManagerInstance == null)
                {
                    lock(s_LockObj)
                    {
                        if (s_AppManagerInstance == null)
                        {
                            s_AppManagerInstance = new AppManager();
                        }
                    }
                }

                return s_AppManagerInstance;
            }
        }

        public void Login()
        {
            loadAccessTokenIfExist();
            try
            {
                loginWithToken();
            }
            catch (Exception exception)
            {
                loginWithoutToken();
            }

            if (m_LoginResult != null && !string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_AccessToken = m_LoginResult.AccessToken;
                saveAccessTokenToFile();
            }
            else
            {
                throw new LoginException("Login failed. Try again later.");
            }
        }

        public User LoggedInUser
        {
            get
            {
                if (m_LoggedInUser != null)
                {
                    return m_LoggedInUser;
                }
                else
                {
                    throw new LoginException("You must log in before get a user.");
                }
            }
        }

        public string GetUserProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public string GetUserName()
        {
            return m_LoggedInUser.Name;
        }

        public bool CheckIfCoverPhotoExistAndReturnUrl(out string o_CoverPictureUrl)
        {
            bool isFindCoverPicture = false;

            o_CoverPictureUrl = "";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name.Equals("Cover photos") && album.PictureAlbumURL != null)
                {
                    isFindCoverPicture = true;
                    o_CoverPictureUrl = album.PictureAlbumURL;
                }
            }

            return isFindCoverPicture;
        }

        public FacebookObjectCollection<Post> UserPosts
        {
            get 
            { 
                return m_LoggedInUser.Posts; 
            }
        }

        public FacebookObjectCollection<Album> UserPhotoAlbums
        {
            get
            {
                return m_LoggedInUser.Albums;
            }
        }

        public FacebookObjectCollection<Group> UserGroups
        {
            get
            {
                return m_LoggedInUser.Groups;
            }
        }

        public FacebookObjectCollection<Page> UserLikedPages
        {
            get
            {
                return m_LoggedInUser.LikedPages;
            }
        }

        public PostsGame PostsGame()
        {
            if (m_PostsGame == null)
            {
                m_PostsGame = new PostsGame(m_LoggedInUser.Posts);
            }

            return m_PostsGame;
        }

        public StatisticsManager Statistics
        {
            get
            {
                if (m_StatisticsManager == null)
                {
                    m_StatisticsManager = new StatisticsManager(m_LoggedInUser.Posts);
                }

                return m_StatisticsManager;
            }
        }

        public void Logout()
        {
            m_AccessToken = null;
            using (StreamWriter writer = new StreamWriter(k_AccessTokenFilePath))
            {
                writer.WriteLine();
            }
        }

        private void loginWithToken()
        {
            m_LoginResult = FacebookService.Connect(m_AccessToken);
        }

        private void loginWithoutToken()
        {
            try
            {
             m_LoginResult = FacebookService.Login(
             //App ID    
             k_AppID,
             //requested permissions:
             "email",
             "public_profile",
             "user_age_range",
             "user_birthday",
             "user_events",
             "user_friends",
             "user_gender",
             "user_hometown",
             "user_likes",
             "user_link",
             "user_location",
             "user_photos",
             "user_posts",
             "user_videos"
             );
            }
            catch (Exception exception)
            {}
        }

        private void saveAccessTokenToFile()
        {
            using (StreamWriter writer = new StreamWriter(k_AccessTokenFilePath))
            {
                writer.WriteLine(m_AccessToken);
            }
        }

        private void loadAccessTokenIfExist()
        {
            try
            {
                m_AccessToken = File.ReadAllText(k_AccessTokenFilePath);
            }
            catch (IOException exception)
            {
                m_AccessToken = null;
            }
        }
    }
}
