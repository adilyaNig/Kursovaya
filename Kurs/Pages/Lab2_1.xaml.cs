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

using Kurs.Windows.LabR2;

namespace Kurs.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lab2_1.xaml
    /// </summary>
    public partial class Lab2_1 : Page
    {
        public Lab2_1()
        {
            InitializeComponent();
        }
        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg2_1 imageProg2_1 = new ImageProg2_1();
            imageProg2_1.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie2_1 reshenie2_1 = new Reshenie2_1();
            reshenie2_1.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code2_1 code2_1 = new Code2_1();
            code2_1.ShowDialog();
        }
        
        private void Button_Click_Zadacha2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab2_2());
        }
    }
}
