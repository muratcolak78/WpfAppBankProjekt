using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppBankProjekt
{
    /// <summary>
    /// Interaktionslogik für UserFenster.xaml
    /// </summary>
    public partial class UserFenster : Window
    {

       
        

            public UserFenster()
            {
                InitializeComponent();
             
            }

            private void MenuItem_Click(object sender, RoutedEventArgs e)
            {
            MenuItem menuItem = (MenuItem)sender;
            string menuHeader = menuItem.Header.ToString();

            switch (menuHeader)
            {
                case "My Accounts":
                   MyAccountsPage page=new MyAccountsPage();
                   contentControl.Content = page.Content;
                    
                    break;
                case "Transfer":
                   // contentControl.Content = new TransferPage();
                    break;
                case "Campaigns":
                   // contentControl.Content = new CampaignsPage();
                    break;
                default:
                    break;
            }
        }
    }
}

