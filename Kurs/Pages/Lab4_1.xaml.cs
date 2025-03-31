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

using Kurs.Windows.LabR4;

namespace Kurs.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lab4_1.xaml
    /// </summary>
    public partial class Lab4_1 : Page
    {
        public Lab4_1()
        {
            InitializeComponent();
        }
        private void Button_Click_MenuPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg4_1 imageProg4_1 = new ImageProg4_1();
            imageProg4_1.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie4_1 reshenie4_1 = new Reshenie4_1();
            reshenie4_1.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code4_1 code4_1 = new Code4_1();
            code4_1.ShowDialog();
        }
       

        private void Button_Click_Zadacha2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab4_2());
        }
    }
}
