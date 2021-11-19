using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace lb4_spz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename, filepath, text;
        private void create_file_Click(object sender, EventArgs e)
        {
            filename = file_name.Text;//берем имя файла из текстбокса
            filepath = @"C:\Users\osadc\source\repos\lb4_spz\" + filename;//создаем полный путь к файлу
            text = file_fill.Text;//читаем содержимое текстбокса для заполнения файла
            if (!Regex.IsMatch(text, @"^[0-9,-- ]+$") || filename=="") MessageBox.Show("Некорректно введенные данные!\nФайл не создан!", "Ошибка");//проверка на корректность ввода данных
            else File.WriteAllText(filepath + ".txt", text);//записываем данные в файл
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            get_file_text.Text = File.ReadAllText(filepath + ".txt");//считываем файл и записываем содержимое в текстбокс
        }

        private void rewrite_file_Click(object sender, EventArgs e)
        {
            string[] numbers = text.Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries);//создаем массив, куда записываем числа, разделяя их по пробелу и запятой
            string result="";//строка для результата
            int count = 1;//счетчик повторений
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])//если элемент_тек==элемент_некст
                {
                    count++;//увеличиваем счетчик
                }
                else
                {
                    result += count+", ";//записываем резалт и добавляем запятую после числа
                    count = 1;//сбрасываем счетчик
                }
                if (i == numbers.Length - 2)//для последнего символа не ставим запятую
                {
                    result += count;
                }
            }
            get_rewrite.Text = result;//заносим резалт в текстбокс
            File.WriteAllText(filepath + ".out", result);//создаем новый файл
        }
    }
}
