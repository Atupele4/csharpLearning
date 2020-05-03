using System;
using ConsoleApp5.Controllers;
using ConsoleApp5.DTO;
using ConsoleApp5.Managers;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            user.UserName = "user1";
            user.Phone = "0977123456";
            user.Location = "Lusaka, Zambia";

            UserManager userManager = new UserManager();

            userManager.saveUser(user);

            Console.WriteLine("Hello World!");
        }





    }
}
