using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppBankProjekt
{
    public static class AlleListen
    {
        static User user = null;
        static List<User> users = new List<User>();

        internal static List<User> Users { get => users; set => users = value; }
        internal static User User { get => user; set => user = value; }

        public static void aktullenListen()
        {
            users = JSONHelper.ReadFromJson<User>("users.json");
           
        }
    }
}
