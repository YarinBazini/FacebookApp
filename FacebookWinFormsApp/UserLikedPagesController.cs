using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppGUI
{
    public partial class UserLikedPagesController : UserControl, ITab
    {
        public LikedPagesFacade Facade { get; }

        public UserLikedPagesController()
        {
            InitializeComponent();
            Facade = new LikedPagesFacade();
        }
         
        public void FetchData()
        {
            if (Facade.Count > 0)
            {
                pageBindingSource.DataSource = Facade;
            }
        }
    }
}
