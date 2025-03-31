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
    /// Логика взаимодействия для Lab2_2.xaml
    /// </summary>
    public partial class Lab2_2 : Page
    {
        public Lab2_2()
        {
            InitializeComponent();
        }
        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab2_1());
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg2_2 imageProg2_2 = new ImageProg2_2();
            imageProg2_2.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie2_2 reshenie2_2 = new Reshenie2_2();
            reshenie2_2.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code2_2 code2_2 = new Code2_2();
            code2_2.ShowDialog();
        }
        private void Button_Click_Zadaniya(object sender, RoutedEventArgs e)
        {
            Zadaniya2_2 zadaniya2_2 = new Zadaniya2_2();
            zadaniya2_2.ShowDialog();
        }
        private void Button_Click_MenuPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

    }
}
