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

namespace WPF_Layout.Views.Home
{
    /// <summary>
    /// Interaction logic for HomeLayout.xaml
    /// </summary>
    public partial class HomeLayout : Page
    {
        private User user;

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
    }
}
