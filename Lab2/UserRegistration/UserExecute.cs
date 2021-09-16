using System;

namespace UserRegistration
{
    class UserExecute
    {
        static void Main(string[] args)
        {
            var user = User.CreateUser();
            user.UserInfo();
        }
    }
}