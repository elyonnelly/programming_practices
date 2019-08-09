/*
Последовательность событий при работе с формой
• Создайте пустую форму.
• Добавьте в нее обработчики событий: Activated, Deactivate, FormClosed, 
FormClosing, Load, Paint, Resize.
• В каждый обработчик включите оператор, изменяющий текст заголовка формы, 
и оператор, добавляющий в общую строку название события.
• В обработчике события Form1_FormClosed() поместите вызов диалогового окна, 
где выведите список событий, произошедших при выполнении программы.
• В каждый обработчик событий, кроме Activated, Deactivate, поместите вывод 
в диалоговое окно названия события.
• Запустите программу на выполнение.
• Запишите названия произошедших событий, изменяемые заголовки формы.
• Сравните с результатом, выведенным в обработчике события FormClosed. 
*/
using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        string result;
        public Form1()
        {
            InitializeComponent();
        } // end of Form1()
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Form1_Load";
            result += "\nLoad";
            MessageBox.Show("Событие Load");
        } // end of Form1_Load()
        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "Form1_Activated";
            result += "\nActivated";
        } // end of Form1_Activated()
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Text = "Form1_Deactivate";
            result += "\nDeactivate";
        } // end of Form1_Deactivate()
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = "Form1_Resize";
            result += "\nResize";
            MessageBox.Show("Событие Resize");
        } // end of Form1_Resize()
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Form1_Paint";
            result += "\nPaint";
            MessageBox.Show("Событие Paint");
        } // end of Form1_Paint()
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Text = "Form1_FormClosing";
            result += "\nFormClosing";
            MessageBox.Show("Событие FormClosing");
        } // end of Form1_FormClosing()
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Text = "Form1_FormClosed";
            result = "События в жизни формы: " + result;
            MessageBox.Show(result + "\nFormClosed");
        } // end of Form1_FormClosed()
    } // end of class Form1
}

