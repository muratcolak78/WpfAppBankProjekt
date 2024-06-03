using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBankProjekt
{
    internal class User
    {
        public User(string username, string password, string name, string surname, string email, string adress)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.adress = adress;
        }

        public string username {  get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public string email { get; set; }
        
        public string adress { get; set; }
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();



    }
}
