using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserPostsController : UserControl
    {
        private readonly AppManager r_AppManager;

        public UserPostsController(AppManager i_AppManager)
        {
            InitializeComponent();
            r_AppManager = i_AppManager;
        }

        public void FetchUserPosts()
        {
            try
            {
                m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Clear()));
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = false));
                foreach (Post post in r_AppManager.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Add(post.Message)));
                    }
                    else if (post.Caption != null)
                    {
                        m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                        m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Add((string.Format("[{0}]", post.Type)))));
                    }
                }

                if (m_ListBoxPosts.Items.Count == 0)
                {
                    m_ListBoxPosts.Items.Add("You have not published any post yet");
                }
            }
            catch (Exception exception)
            {
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = true));
            }
        }

        private void m_ListBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Post selectedUsetPost = r_AppManager.LoggedInUser.Posts[m_ListBoxPosts.SelectedIndex];

                m_ListBoxPostComments.Items.Clear();
                m_LabelError.Visible = false;
                if (selectedUsetPost.Comments.Count > 0)
                {
                    foreach (Comment comment in selectedUsetPost.Comments)
                    {
                        m_ListBoxPostComments.Items.Add(String.Format("{0}: {1}", comment.From, comment.Message));
                    }
                }
                else
                {
                    m_ListBoxPostComments.Items.Add("The selected post has no comments yet");
                }
            }
            catch (Exception exception)
            {
                m_LabelError.Visible = true;
            }
        }
    }
}
