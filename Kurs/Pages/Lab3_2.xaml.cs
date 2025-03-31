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
    /// Логика взаимодействия для Lab3_2.xaml
    /// </summary>
    public partial class Lab3_2 : Page
    {
        public Lab3_2()
        {
            InitializeComponent();
        }
        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Lab3_1());
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg3_2 imageProg3_2 = new ImageProg3_2();
            imageProg3_2.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie3_2 reshenie3_2 = new Reshenie3_2();
            reshenie3_2.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code3_2 code3_2 = new Code3_2();
            code3_2.ShowDialog();
        }
        private void Button_Click_Zadaniya(object sender, RoutedEventArgs e)
        {
            Zadaniya3_2 zadaniya3_2 = new Zadaniya3_2();
            zadaniya3_2.ShowDialog();
        }
        private void Button_Click_MenuPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
    }
}
