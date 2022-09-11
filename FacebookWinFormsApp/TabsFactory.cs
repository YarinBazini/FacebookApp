namespace FacebookAppGUI
{
    public static class TabsFactory
    {
        public enum TabType
        {
            PostsTab,
            AboutTab,
            PhotosTab,
            GroupsTab,
            LikesPagesTab,
            PostsGameTab,
            UserStatisticsTab
        }

        public static ITab Create(TabType i_Type)
        {
            ITab createdTab = null;

            if (i_Type.Equals(TabType.AboutTab))
            {
                createdTab = new UserAboutController();
            }
            else if (i_Type.Equals(TabType.PostsTab))
            {
                createdTab = new UserPostsController();
            }
            else if (i_Type.Equals(TabType.PhotosTab))
            {
                createdTab = new UserPhotosController();
            }
            else if (i_Type.Equals(TabType.GroupsTab))
            {
                createdTab = new UserGroupsController();
            }
            else if (i_Type.Equals(TabType.LikesPagesTab))
            {
                createdTab = new UserLikedPagesController();
            }
            else if (i_Type.Equals(TabType.PostsGameTab))
            {
                createdTab = new PostsGameController();
            }
            else if (i_Type.Equals(TabType.UserStatisticsTab))
            {
                createdTab = new UserStatisticsController();
            }

            return createdTab;
        }
    }
}
