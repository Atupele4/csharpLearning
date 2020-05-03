using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp5.Controllers;
using ConsoleApp5.DTO;

namespace ConsoleApp5.Managers
{
    public class UserManager : UserController
    {
        public override bool saveUser(User user)
        {
            User userx = user;
            var checkedx = base.saveUser(userx);
            return checkedx;
        }

        public override bool validateUser(User user)
        {
            return user.UserName.Length > 0;
        }
    }
}
