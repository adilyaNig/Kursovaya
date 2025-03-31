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

using Kurs.Windows.LabR3;

namespace Kurs.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lab3_1.xaml
    /// </summary>
    public partial class Lab3_1 : Page
    {
        public Lab3_1()
        {
            InitializeComponent();
        }
        private void Button_Click_MenuPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg3_1 imageProg3_1 = new ImageProg3_1();
            imageProg3_1.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie3_1 reshenie3_1 = new Reshenie3_1();
            reshenie3_1.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code3_1 code3_1 = new Code3_1();
            code3_1.ShowDialog();
        }
        
        private void Button_Click_Zadacha2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab3_2());
        }
    }
}
