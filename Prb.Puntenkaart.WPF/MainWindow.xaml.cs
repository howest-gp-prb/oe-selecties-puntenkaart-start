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

namespace Prb.Puntenkaart.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
        }
        private void TxtWetenschappen_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtWetenschappen.IsLoaded)
            {
            }
        }
        private void TxtWiskunde_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtWiskunde.IsLoaded)
            {
            }
        }
        private void TxtTalen_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTalen.IsLoaded)
            {
            }
        }
        private void CmbWetenschappen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbWetenschappen.IsLoaded)
            {
            }
        }
        private void CmbWiskunde_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbWetenschappen.IsLoaded)
            {
            }
        }
        private void CmbTalen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbWetenschappen.IsLoaded)
            {
            }
        }
        private void TxtWetenschappen_GotFocus(object sender, RoutedEventArgs e)
        {
        }
        private void TxtWiskunde_GotFocus(object sender, RoutedEventArgs e)
        {
        }
        private void TxtTalen_GotFocus(object sender, RoutedEventArgs e)
        {
        }
    }
}
