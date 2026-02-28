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

namespace WPF_Layout
{
    /// <summary>
    /// Interaction logic for LoginLayout.xaml
    /// </summary>
    public partial class LoginLayout : Page
    {
        private static string tk = "hello";
        private static string mk = "123";
        public LoginLayout()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == tk && txtPassword.Text == mk)
            {
                NavigationService.Navigate(new HomeLayout());
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new signupLayout());
        }
    }
}
