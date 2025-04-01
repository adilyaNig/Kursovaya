
using System;
using System.Collections.Generic;
using System.IO;
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

using Kurs.Pages;

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
            // Создаем экземпляр страницы с Lab1Page
            Lab1Page lab1Page = new Lab1Page();

            // Загружаем HTML-файл
            lab1Page.LoadHtmlFile();

            // Открываем новую страницу
            NavigationService.Navigate(lab1Page);
        }

        private void Button_Click_Lab2(object sender, RoutedEventArgs e)
        {
            Lab2Page lab2Page = new Lab2Page();
            lab2Page.LoadHtmlFile();
            NavigationService.Navigate(lab2Page);
        }
        private void Button_Click_Lab3(object sender, RoutedEventArgs e)
        {
            Lab3Page lab3Page = new Lab3Page();
            lab3Page.LoadHtmlFile();
            NavigationService.Navigate(lab3Page);
        }
        private void Button_Click_Lab4(object sender, RoutedEventArgs e)
        {
            Lab4Page lab4Page = new Lab4Page();
            lab4Page.LoadHtmlFile();
            NavigationService.Navigate(lab4Page);
        }


        private void Button_Click_Spravka(object sender, RoutedEventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.LoadHtmlFile();
            NavigationService.Navigate(spravka);
        }
       

        
     
    }
}
