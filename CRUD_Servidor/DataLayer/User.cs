using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Telephone { get; set;}


        public User(int id , string username, string password, int telephone)
        {
            Id = id;
            UserName = username;
            Password = password;
            Telephone = telephone;

        }
        public User(string UserName, string Password, int Telephone)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Telephone = Telephone;
        }

        public User() { }

    }
}
