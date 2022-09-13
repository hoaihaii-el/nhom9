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

namespace RestaurantManagementSystem
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
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnWareHouse_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = new WareHouse();
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = new Staff();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = new Menu();
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = new Table();
        }

        private void btnBill_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = new Bill();
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = new Stats();
        }

        private void btnViewProfile_Click(object sender, RoutedEventArgs e)
        {
            Profile objViewProfile = new Profile();
            objViewProfile.Show();
        }
    }
}
