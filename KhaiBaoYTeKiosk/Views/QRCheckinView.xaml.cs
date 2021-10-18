using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace KhaiBaoYTeKiosk.Views
{
    /// <summary>
    /// Interaction logic for QRCheckinView.xaml
    /// </summary>
    public partial class QRCheckinView : UserControl
    {
        public QRCheckinView()
        {
            InitializeComponent();
            
        }

        private bool isPressed = false;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            Debug.WriteLine("Im triggered");
            Debug.WriteLine("InputBox Text: " + ScannerBox.InputBox.Text);

            if (!isPressed)
            {
                ScannerBox.PlaceholderBox.Focus();
                isPressed = true;
            }
        }

        private void keyboard_Loaded(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.KeyDown += Window_KeyDown;
        }
    }
}
