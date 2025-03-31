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

using Kurs.Windows.LabR1;

namespace Kurs.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lab1_1.xaml
    /// </summary>
    public partial class Lab1_1 : Page
    {
        public Lab1_1()
        {
            InitializeComponent();
        }
        private void Button_Click_MenuPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg1_1 imageProg1_1 = new ImageProg1_1();
            imageProg1_1.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie1_1 reshenie1_1 = new Reshenie1_1();
            reshenie1_1.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code1_1 code1_1 = new Code1_1();
            code1_1.ShowDialog();
        }
        
        private void Button_Click_Zadacha2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab1_2());
        }
    }
}
