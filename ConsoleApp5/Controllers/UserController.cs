using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp5.DTO;

namespace ConsoleApp5.Controllers
{
    public class UserController
    {


        public virtual bool saveUser(User user)
        {
            return validateUser(user);
        }


        public virtual bool validateUser(User user)
        {
            return false;
        }
    }
}
