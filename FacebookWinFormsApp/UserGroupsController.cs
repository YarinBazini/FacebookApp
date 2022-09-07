using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserGroupsController : UserControl, ITab
    {
        public GroupsPageFacade Facade { get; }

        public UserGroupsController()
        {
            InitializeComponent();
            Facade = new GroupsPageFacade();
        }

        public void FetchData()
        {
            groupBindingSource.DataSource = Facade.Groups;
        }
    }
}
