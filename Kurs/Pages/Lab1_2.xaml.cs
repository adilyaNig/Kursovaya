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
    /// Логика взаимодействия для Lab1_2.xaml
    /// </summary>
    public partial class Lab1_2 : Page
    {
        public Lab1_2()
        {
            InitializeComponent();
        }
        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab1_1());
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg1_2 imageProg1_2 = new ImageProg1_2();
            imageProg1_2.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie1_2 reshenie1_2 = new Reshenie1_2();
            reshenie1_2.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code1_2 code1_2 = new Code1_2();
            code1_2.ShowDialog();
        }
        private void Button_Click_Zadaniya(object sender, RoutedEventArgs e)
        {
            Zadaniya1_2 zadaniya1_2 = new Zadaniya1_2();
            zadaniya1_2.ShowDialog();
        }
        private void Button_Click_MenuPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }


    }
}
