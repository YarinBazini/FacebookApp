using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserGroupsController : UserControl, ITab
    {
        public GroupsFacade Facade { get; }

        public UserGroupsController()
        {
            InitializeComponent();
            Facade = new GroupsFacade();
        }

        public void FetchData()
        {
            if (Facade.Count > 0)
            {
                groupBindingSource.DataSource = Facade;
            }
        }
    }
}
