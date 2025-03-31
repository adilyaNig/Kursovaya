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

namespace Kurs.Windows.LabR4
{
    /// <summary>
    /// Логика взаимодействия для Zadaniya4_2.xaml
    /// </summary>
    public partial class Zadaniya4_2 : Window
    {
        public Zadaniya4_2()
        {
            InitializeComponent();
            string filePath = @"\Users\DAMIR\931\Kurs\Kurs\TextFiles\TextFileLab4_2.txt";
            DisplayTextFromFile(filePath);
        }

        

        private void DisplayTextFromFile(string filePath)
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                try
                {
                    string text = File.ReadAllText(filePath, Encoding.UTF8); // Чтение файла в UTF-8
                    string startWord = "решения"; // Начало вывода
                    string endWord = "ГЛАВА 2."; // Конец вывода
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
