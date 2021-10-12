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

namespace KhaiBaoYTeKiosk.Views
{
    /// <summary>
    /// Interaction logic for HealthDeclarationView.xaml
    /// </summary>
    public partial class HealthDeclarationView : UserControl
    {
        public HealthDeclarationView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Modal.Visibility == Visibility.Visible)
            {
                Modal.Visibility = Visibility.Collapsed;
            }
            else Modal.Visibility = Visibility.Visible;
        }
    }
}
