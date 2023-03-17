using System;
using System.Collections.Generic;
using System.Text;

namespace LayerModel
{
    public class Usuario
    {
        private int id;
        private string username;
        private string email;
        private int edad;

        public Usuario(int id , string username, string email, int edad)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.edad = edad;
        }
        public Usuario(string username, string email, int edad){
            this.username = username;
            this.email = email;
            this.edad = edad;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => username;  set=>username = value; }
        public string Email { get =>email; set=> email = value; }
        public int Edad { get => edad; set => edad = value; }

        public String ShowState()
        {
           return "ID: "+this.id+" USERNAME: "+this.username+" EMAIL: " + this.email + " EDAD: " + this.edad;
        }
    }
}
