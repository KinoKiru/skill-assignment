using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
   public class Login
    {
        private string username;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public Login() { }

        public Login(string _username, string _password) {
            password = _password;
            username = _username;
        }
    }
}
