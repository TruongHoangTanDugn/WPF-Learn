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

namespace WPF_Layout
{
    /// <summary>
    /// Interaction logic for signupLayout.xaml
    /// </summary>
    public partial class signupLayout : Page
    {
        public signupLayout()
        {
            InitializeComponent();
        }

        private void BackToLoginClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginLayout());
        }
    }
}
