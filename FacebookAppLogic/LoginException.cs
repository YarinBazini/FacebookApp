using System;

namespace FacebookAppLogic
{
    public class LoginException : Exception
    {
        public LoginException(string i_Message) : base("Login Failed because: " + i_Message)
        {}
    }
}
