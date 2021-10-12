using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
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

namespace KhaiBaoYTeKiosk.CustomControl
{
    /// <summary>
    /// Interaction logic for PlaceholderPasswordBox.xaml
    /// </summary>
    public partial class PlaceholderPasswordBox : UserControl
    {
        public PlaceholderPasswordBox()
        {
            InitializeComponent();
        }
        public string Password
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); }
        }


        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PlaceholderPasswordBox), new PropertyMetadata("PLACEHOLDER"));
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(PlaceholderPasswordBox), new PropertyMetadata("PLACEHOLDER"));

        private void InputBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(InputBox.Password))
            {
                PlaceholderBox.Visibility = Visibility.Visible;
                InputBox.Visibility = Visibility.Collapsed;
            }
        }

        private void PlaceholderBox_GotFocus(object sender, RoutedEventArgs e)
        {

            PlaceholderBox.Visibility = Visibility.Collapsed;
            InputBox.Visibility = Visibility.Visible;
            InputBox.Focus();
        }

        private void PlaceholderBox_Loaded(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(Password))
            {
                PlaceholderBox.Visibility = Visibility.Collapsed;
                InputBox.Visibility = Visibility.Visible;
            }
        }

        private void InputBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = InputBox.Password;
        }
    }
}
