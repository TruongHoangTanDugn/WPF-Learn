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
using System.Windows.Shapes;
using WPF_Layout.Models;
using WPF_Layout.Repositories;

namespace WPF_Layout
{
    /// <summary>
    /// Interaction logic for signupLayout.xaml
    /// </summary>
    public partial class signupLayout : Page
    {
        private UserRepository _userRepository = new();
        public signupLayout()
        {
            InitializeComponent();
        }

        private void BackToLoginClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginLayout());
        }
        private void FirstNameBox(object sender, TextChangedEventArgs e)
        {

        }
        private void LastNameBox(object sender, TextChangedEventArgs e)
        {

        }

        private void EmailBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox(object sender, TextChangedEventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = SignUpFirstName.Text.Trim();
            string lastName = SignUpLastName.Text.Trim();
            string email = SignUpEmail.Text.Trim();
            string password = SignUpPassword.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all the information required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            User? user = _userRepository.FindByUsername(email);
            if (user != null)
            {
                MessageBox.Show("Existed email address. Please try another email address", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            User userAcc = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            _userRepository.AddNew(userAcc);
            NavigationService.Navigate(new LoginLayout());
        }
    }
}
