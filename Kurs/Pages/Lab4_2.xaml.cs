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
    /// Логика взаимодействия для Lab4_2.xaml
    /// </summary>
    public partial class Lab4_2 : Page
    {
        public Lab4_2()
        {
            InitializeComponent();
        }
        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Button_Click_Prog(object sender, RoutedEventArgs e)
        {
            ImageProg4_2 imageProg4_2 = new ImageProg4_2();
            imageProg4_2.ShowDialog();
        }
        private void Button_Click_Reshenie(object sender, RoutedEventArgs e)
        {
            Reshenie4_2 reshenie4_2 = new Reshenie4_2();
            reshenie4_2.ShowDialog();
        }

        private void Button_Click_Code(object sender, RoutedEventArgs e)
        {
            Code4_2 code4_2 = new Code4_2();
            code4_2.ShowDialog();
        }
        private void Button_Click_Zadaniya(object sender, RoutedEventArgs e)
        {
            Zadaniya4_2 zadaniya4_2 = new Zadaniya4_2();
            zadaniya4_2.ShowDialog();
        }
    }
}
