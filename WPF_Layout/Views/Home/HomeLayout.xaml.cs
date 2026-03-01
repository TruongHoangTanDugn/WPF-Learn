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

namespace WPF_Layout.Views.Home
{
    /// <summary>
    /// Interaction logic for HomeLayout.xaml
    /// </summary>
    public partial class HomeLayout : Page
    {
        private User user;
        private UserRepository _userRepository = new();
        public HomeLayout()
        {
            InitializeComponent();
            user = new User();
        }

        public HomeLayout(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void LogOutButton(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void DeleteAccountButton(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Delete this account?", "Confirm delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Account deleted.", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                _userRepository.Remove(user);
                if (NavigationService != null && NavigationService.CanGoBack)
                    NavigationService.GoBack();
            }
        }
    }
}
