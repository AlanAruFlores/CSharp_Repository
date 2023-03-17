using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
namespace Controller
{
    public class ControllerUser
    {
        static UserDAO dao = new UserDAO();
        public static void Register(string u , string p , int t)
        {
            dao.RegisterNewAccount(u, p, t);
        }


        public static int Login(string u , string p)
        {
            int id = 0;
            User user = dao.LoginAccount(u, p);
            if(user != null) id = user.Id;

            return id;
        }
    }
}
