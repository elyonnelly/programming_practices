/*
Создать на форме прозрачный квадратный фрагмент («форточку»), 
который можно перемещать с помощью ползунка (элемент TrackBar).
Установите свойства формы: Text = Форточка на форме, BackColor = ActiveCaptionText. 
Поместите на форму элемент TrackBar («ползунок»), установите его свойства: 
Anchor = Bottom, Left, Right; Orientation = Horizontal.
Добавьте обработчики событий: Form1_Paint (), trackBar1_Scroll ().
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.Text = "Форточка на форме";
            X = 0; Y = 0; W = 100; H = 100;
        }
        int X, Y, W, H; // Координаты и размеры форточки
        
        // Метод реагирует на каждое перемещение  
        // пользователем ползунка на элементе trackBar1
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            // после изменения пользователем ползунка 
            // элемента trackBar1 необходимо 
            // переместить форточку, для чего перерисуем всю форму:
            this.Invalidate();
        }
        // Метод для перерисовки формы
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = this.Width - W;
            e.Graphics.FillRectangle(
            new SolidBrush(SystemColors.ControlDark), X, Y, W, H);
            // Устанавливаем цвет ControlDark "прозрачным":
            this.TransparencyKey = SystemColors.ControlDark;
        }

        // ToDO: Дополните форму задачи вторым элементом trackBar2, 
        // размещенным вертикально и позволяющим перемещать форточку вверх и вниз.
    }
}
