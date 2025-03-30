﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


namespace Kurs.Windows.LabR1
{
    /// <summary>
    /// Логика взаимодействия для Code1_2.xaml
    /// </summary>
    public partial class Code1_2 : Window
    {
        public Code1_2()
        {
            InitializeComponent();
            string filePath = @"C: \Users\DAMIR\931\Kurs\Kurs\TextFiles\TextFileLab1_1.txt";
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
                    string startWord = "Программный код:"; // Начало вывода
                    string endWord = "Выполнение"; // Конец вывода
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
