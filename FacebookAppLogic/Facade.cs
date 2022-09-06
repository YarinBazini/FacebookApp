using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookAppLogic
{
    public abstract class Facade
    {
        protected readonly AppManager r_AppManager;
        protected bool m_DataFetched;

        public Facade()
        {
            r_AppManager = AppManager.Instance;
            m_DataFetched = false;
        }

        protected abstract void fetchData();

        protected void fetchDataIfDidntFetchAlready()
        {
            if (!m_DataFetched)
            {
                fetchData();
            }
            m_DataFetched = true;
        }
    }
}
