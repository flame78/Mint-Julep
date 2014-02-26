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

namespace HackWarsLib
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
        private void StartGame(object sender, RoutedEventArgs e)
        {
            Window Map = new map();
            Map.Show();
            this.Close();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to exit?", "Exit Confirmation", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Environment.Exit(1);
            }
        }
    }
}
