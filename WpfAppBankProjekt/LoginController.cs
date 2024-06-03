using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppBankProjekt
{
    public static class LoginController
    {
        
        public static bool loginControll(string userName, string passWort)
        {
            
            AlleListen.User= AlleListen.Users.Find(n => n.username == userName && n.password == passWort);
            

            if (AlleListen.User == null) return false;
            
            return true;
        }
    }
}
