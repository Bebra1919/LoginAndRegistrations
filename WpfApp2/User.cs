using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class User
    {
        public string Name;
        public string Login;
        public string Password;
        public string Sex;

        public User(string Login, string Password) 
        {
            this.Login = Login;
            this.Password = Password;
        }

        public User(string Name, string Login, string Sex, string Password) 
        {
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
            this.Sex = Sex;
        }
    }

}
