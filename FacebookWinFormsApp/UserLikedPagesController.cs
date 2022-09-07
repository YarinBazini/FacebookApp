using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserLikedPagesController : UserControl, ITab
    {
        public LikedPagesPageFacade Facade { get; }

        public UserLikedPagesController()
        {
            InitializeComponent();
            Facade = new LikedPagesPageFacade();
        }
         
        public void FetchData()
        {
            pageBindingSource.DataSource = Facade.LikedPages;
        }
    }
}
