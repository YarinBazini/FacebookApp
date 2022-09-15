using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserPostsController : UserControl, ITab
    {
        public PostsFacade Facade { get; }

        public UserPostsController()
        {
            InitializeComponent();
            Facade = new PostsFacade();
        }

        public void FetchData()
        {
            try
            {
                m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Clear()));
                m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.DisplayMember = "Message"));
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = false));
                foreach (Post post in Facade)
                {
                    if (post.Message != null)
                    {
                        m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Add(post)));
                    }
                }

                if (m_ListBoxPosts.Items.Count == 0)
                {
                    m_ListBoxPosts.Invoke(new Action(() => m_ListBoxPosts.Items.Add("You have not published any post yet")));
                }
            }
            catch (Exception exception)
            { }
        }

        private void m_ListBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Post selectedUsetPost = (Post)m_ListBoxPosts.SelectedItem;

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
