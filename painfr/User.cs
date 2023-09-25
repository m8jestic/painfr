using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace painfr
{
    public class User
    {
        public uint record;
        public string username;
        private string password;
        public bool isAdmin;
        public User(string username ,string password, bool isAdmin = false, uint record = 0)
        {
            if (Register(username,password))
            {
                this.username = username;
                this.password = password;
                this.isAdmin = isAdmin;
                this.record = record;
            }
            else
            {
                Console.WriteLine("Такой пользователь уже существует");
            }
            
            
        }
        public void ShowResults()
        {
            Console.WriteLine($"Ваш рекорд {record}");
        }
        public bool Register(string username, string password)
        {
            if (this.username != username & username != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Login(string username, string password) { 
            if(this.username == username & password == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
