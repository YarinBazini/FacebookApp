using System;

namespace FacebookAppLogic
{
    public class FetchException : Exception
    {
        public FetchException(string i_Message) : base("Fetch Failed: " + i_Message)
        {}
    }
}
