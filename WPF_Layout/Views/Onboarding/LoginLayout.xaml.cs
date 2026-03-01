using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Layout.Models;
using WPF_Layout.Repositories;
using WPF_Layout.Views.Home;

namespace WPF_Layout
{
    /// <summary>
    /// Interaction logic for LoginLayout.xaml
    /// </summary>
    public partial class LoginLayout : Page
    {
        private readonly UserRepository _userRepository = new();

        public LoginLayout()
        {
            InitializeComponent();
        }

        private void SignInButton(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Password;

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password completely and correctly", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            User? user = _userRepository.FindByUsername(email);

            if(user == null || user.Password != password)
            {
                MessageBox.Show("Invalid username or password", "Sign in Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            NavigationService.Navigate(new HomeLayout(user));
        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new signupLayout());
        }

        
        private void EmailBox(object sender, TextChangedEventArgs e)
        {
        }

        private void PasswordBox(object sender, RoutedEventArgs e)
        {
        }

        private void ForgetPassButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Unimplemented Feature or Page", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
