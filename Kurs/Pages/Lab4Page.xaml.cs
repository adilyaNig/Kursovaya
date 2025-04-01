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
    /// Логика взаимодействия для Lab4Page.xaml
    /// </summary>
    public partial class Lab4Page : Page
    {
        public Lab4Page()
        {
            InitializeComponent();
        }
        public void LoadHtmlFile()
        {
            try
            {
                // Получаем путь к HTML-файлу относительно папки bin\Debug
                string htmlFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Web\\Lab4.htm");
                webBrowser4.Navigate(htmlFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
