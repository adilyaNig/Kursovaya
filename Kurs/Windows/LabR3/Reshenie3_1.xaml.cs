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
using System.Windows.Shapes;

using System.IO;
using Kurs.Windows;
using System.Windows.Navigation;
using System.Text.RegularExpressions;

namespace Kurs.Windows.LabR3
{
    /// <summary>
    /// Логика взаимодействия для Reshenie3_1.xaml
    /// </summary>
    public partial class Reshenie3_1 : Window
    {
        public Reshenie3_1()
        {
            InitializeComponent();
            string filePath = @"C: \Users\DAMIR\931\Kurs\Kurs\TextFiles\TextFileLab3_1.txt";
            DisplayTextFromFile(filePath);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DisplayTextFromFile(string filePath)
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                try
                {
                    string text = File.ReadAllText(filePath, Encoding.UTF8); // Чтение файла в UTF-8
                    string startWord = "Решение:"; // Начало вывода
                    string endWord = "Программный код"; // Конец вывода
                    Regex regex = new Regex($@"{Regex.Escape(startWord)}(.*?)(?=({Regex.Escape(endWord)})|$)", RegexOptions.Singleline);
                    Match match = regex.Match(text);
                    if (match.Success)
                    {
                        string limitedText = match.Groups[1].Value.Trim(); // Группа 1 содержит текст между ключевыми словами
                        RichTextBox.Document.Blocks.Clear();
                        RichTextBox.AppendText(limitedText);
                    }
                    else
                    {
                        RichTextBox.AppendText(text); // Если фрагмент не найден, выводим весь текст
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                }
            }
        }
    }
}
