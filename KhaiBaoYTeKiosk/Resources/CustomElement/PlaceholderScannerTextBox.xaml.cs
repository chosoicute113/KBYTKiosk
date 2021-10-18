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

namespace KhaiBaoYTeKiosk.Resources.CustomElement
{
    /// <summary>
    /// Interaction logic for PlaceholderScannerTextBox.xaml
    /// </summary>
    public partial class PlaceholderScannerTextBox : UserControl
    {
        public PlaceholderScannerTextBox()
        {
            InitializeComponent();
        }
        public string Text
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
            DependencyProperty.Register("Text", typeof(string), typeof(PlaceholderScannerTextBox), new PropertyMetadata());
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(PlaceholderScannerTextBox), new PropertyMetadata("PLACEHOLDER"));

        private void PlaceholderBox_GotFocus(object sender, RoutedEventArgs e)
        {

            PlaceholderBox.Visibility = Visibility.Collapsed;
            InputBox.Visibility = Visibility.Visible;
            InputBox.Focus();
        }

        private void PlaceholderBox_Loaded(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(Text))
            {
                PlaceholderBox.Visibility = Visibility.Collapsed;
                InputBox.Visibility = Visibility.Visible;
            }
        }
    }
}
