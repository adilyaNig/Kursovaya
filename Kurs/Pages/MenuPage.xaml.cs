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

namespace Kurs.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        private void Button_Click_Lab1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab1_1());
        }

        private void Button_Click_Spravka(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Spravka());
        }
        private void Button_Click_Lab2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab2_1());
        }

        private void Button_Click_Lab3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab3_1());
        }

        private void Button_Click_Lab4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab4_1());
        }

        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GlavMenuPage());
        }
    }
}
