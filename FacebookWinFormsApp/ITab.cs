using FacebookAppLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppGUI
{
    public interface ITab
    {
        AppManager Manager { get; }
        void FetchData();
    }
}
