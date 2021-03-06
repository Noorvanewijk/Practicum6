﻿using System;
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
using WebService.Models;

namespace Practicum6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SOAPService.ServiceClient soap = new SOAPService.ServiceClient();
        public static UserModel gebruiker;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void register(object sender, RoutedEventArgs e)
        {
            var newuser = name.Text;
            gebruiker = soap.RegisterUser(newuser);

            if (gebruiker == null)
            {
                MessageBox.Show("Deze gebruiker bestaat al, gebruik een andere naam");
            }
            else
            {

                MessageBox.Show($"Nieuwe gebruiker {gebruiker.Username} gemaakt met wachtwoord: {gebruiker.Password}");
            }
        }

        private void login(object sender, RoutedEventArgs e)
        {
            gebruiker = soap.LoginUser(username.Text, passwordBox.Password);

            if (gebruiker != null)
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
