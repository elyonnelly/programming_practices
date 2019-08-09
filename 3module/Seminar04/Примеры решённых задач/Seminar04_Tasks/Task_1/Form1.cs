/*
На форму вывести надпись, буквы которой будут последовательно 
исчезать (начиная с конца). Как только надпись исчезнет, форма 
должна постепенно становиться все более прозрачной и постепенно «растаять». 
Затем изображение формы постепенно восстанавливается, но надпись на форме 
уже другая. Программа демонстрирует возможности компонента Timer, и 
свойства Opacity, определяющего прозрачность формы.
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
        }
        
        Size labelSize; // будем хранить начальный размер label
        Font labelFont; // начальный размер шрифта

        private void Form1_Load(object sender, EventArgs e)
        {
            // задаём цвет из RGB (или ARGB)
            this.button1.ForeColor = Color.FromArgb(111, 60, 137);
            // лучше всегда ограничивать минимальный размер формы !
            // это можно сделать и в конструкторе (в свойствах формы)
            this.MinimumSize = new Size(this.Width, this.Height);
            // цвет текста label
            this.label1.ForeColor = Color.Crimson;
            // присваиваем начальные значения полям labelSize и labelFont
            labelSize = this.label1.Size;
            labelFont = this.label1.Font;
            step = 0.1; // задаём шаг
        }
        // изменяем размер шрифта при изменении размеров формы
        private void Form1_Resize(object sender, EventArgs e)
        {
            float newSize = labelFont.Size * (label1.Size.Height / labelSize.Height +
                label1.Size.Width / labelSize.Width) / 2;
            label1.Font = new Font(this.Font.FontFamily, newSize, this.Font.Style);
        }
        /* Элементы на форме меняют размер в зависимости от значения якорей (Anchor).
           Посмотрите, как они выставлены для кнопки и лейбла в данной программе
           (кнопка увеличивается только в ширину, лейбл во все стороны).
           Можете попробовать поставить другие якоря и посмотреть, что будет.
           Текст в Label в Windows Forms масштабируется в зависимости от разрешения экрана,
           поэтому приходиться делать так, как показано выше (для множества надписей 
           можно написать один отдельный метод).
           https://docs.microsoft.com/ru-ru/dotnet/framework/winforms/automatic-scaling-in-windows-forms
        */
        double step;
        // обработка тиков таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step > 0)
            {
                string temp = label1.Text;
                if (temp.Length > 0)
                    label1.Text = temp.Substring(0, temp.Length - 1);
                else
                {
                    if (this.Opacity > 0) // пока не прозрачный
                        this.Opacity = this.Opacity - step;
                    else
                    {
                        label1.Text = "Идеальный баланс!";
                        step = -step;
                    }
                }
            }
            else    // Здесь шаг отрицательный
                this.Opacity = this.Opacity - step;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // активируем (включаем) таймер
            button1.Enabled = false; // деактивируем кнопку
            button1.Text = "Я сама неотвратимость";
        }
    }
}
