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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practicum6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SOAPService.ServiceClient soap = new SOAPService.ServiceClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void register(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Registratie gelukt, je kunt nu inloggen!");
        }

        private void login(object sender, RoutedEventArgs e)
        {
            if (soap.LoginUser(username.Text, passwordBox.Password))
            {
                Store secondWindow = new Store();
                secondWindow.Show();
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is incorrect");
            }
        }
    }
}
