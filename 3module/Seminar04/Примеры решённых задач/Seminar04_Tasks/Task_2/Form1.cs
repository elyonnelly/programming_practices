/*
Разработать Windows-приложение. В поле ListBox вывести в виде 
списка элементы массива строк. Выделяя элемент списка, удалять 
его и из списка, и из массива. Обеспечить возможность 
восстановления начального состояния списка и массива. 
Некоторые свойства элементов задавать в конструкторе форм, 
другие – в коде программы.
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
        }
        // храним начальный список
        string[] lines = new string[]
       { "один", "два", "три", "четыре", "пять", "шесть", "семь" };
        // храним изменённый список
        string[] newLines = null;
        // нажатие на кнопку Отобразить начальный список
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lines);
            newLines = null;
        }
        // нажатие на кнопку Удалить выбранный элемент
        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex; // номер выделенной строки
            if (n == -1) // Выделенная строка отсутствует
            {
                MessageBox.Show("Список пуст или \nнет выделенного элемента!");
                return;
            }
            /*
            listBox1.Items – это коллекция.
            Для удаления элемента из списка удобно пользоваться
            методами работы с коллекциями. 
            В нашем случае – можно применить нестатический метод 
            public virtual void RemoveAt(int index) – он удаляет 
            элемент с индексом index из коллекции и выполняет 
            сдвиг элементов на один элемент, удаляя пропуск.
            */

            listBox1.Items.RemoveAt(n);
            newLines = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(newLines, 0);

            /* то же самое без RemoveAt
            if (newLines == null)
            {
                newLines = new string[lines.Length];
                Array.Copy(lines, newLines, lines.Length);
            }
            for (int i = 0, j = 0; i < newLines.Length; i++)
             {
                 if (i != n)
                     newLines[j++] = newLines[i];
             }
             Array.Resize(ref newLines, newLines.Length - 1);
             listBox1.Items.Clear();
             listBox1.Items.AddRange(newLines);
             */
        }
    }
}

