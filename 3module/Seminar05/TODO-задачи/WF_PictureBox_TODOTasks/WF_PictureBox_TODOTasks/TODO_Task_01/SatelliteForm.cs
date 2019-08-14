/* Разработать Windows-приложение с двумя элементами пользовательского интерфейса Button и PictureBox и компонентом Timer. 
 * Изобразить запуск спутника земли. Земля и спутник – круги. Земля в центре панели PictureBox. 
 * По нажатию кнопки Button спутник начинает движение по спирали от поверхности земли до достижения орбиты максимального 
 * (фиксированного) радиуса. Предусмотреть масштабирование рисунка при изменении размеров формы (и панели PictureBox).
 * Разместите на форме элементы управления Button, PictureBox. 
 * Задайте свойства: 
 * SatteliteForm:   StartPosition = CenterScreen, Text = Спутник
 * StartButton:     Text = Запуск,  Anchor = Top, Left, Right
 * PictureBox: 	    Anchor (прикрепить все стороны), BorderStyle = FixedSingle, Dock = None
 * Timer: 	        Интервал срабатывания: 100
 * Свойства задать в конструкторе формы. */

/* TODO: Дополнить программу возможностью «посадки» спутника. 
 * Варианты решения: 
 * 1 - спутник садится после заданного числа оборотов вокруг земли;
 * 2 – на форму добавляется кнопка «Посадка» и по ее нажатию спутник начинает снижаться до земли; 
 * 3 – на единственной кнопке после запуска надпись «Запуск» заменяется надписью «Посадка»,
 * по ее нажатию спутник начинает снижаться до земли.
 * 4 - спутник садится по истечению заданного интервала времени. */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TODO_Task_01
{
    public partial class SatelliteForm : Form
    {
        public SatelliteForm()
        {
            InitializeComponent();
            timer.Enabled = false;
            timer.Interval = 100;
        }
        /// <summary>
        /// Абсцисса центра Земли
        /// </summary>
        float earthX;
        /// <summary>
        /// Ордината центра Земли
        /// </summary>
        float earthY;
        /// <summary>
        /// Единица мастшаба
        /// </summary>
        float scaleUnit;   
        /// <summary>
        /// Радиус Земли
        /// </summary>
        float earthR;
        /// <summary>
        /// X-координата левого верхнего угла Земли
        /// </summary>
        float earthULX;
        /// <summary>
        /// Y-координата левого верхнего угла Земли
        /// </summary>
        float earthULY;                       
        /// <summary>
        /// Счетчик тиков
        /// </summary>
        int tickCounter = 0;                             
        /// <summary>
        /// Начальный угол 
        /// </summary>
        const float THETA0 = (float)(5 * Math.PI / 4);
        /// <summary>
        /// Начальное расстояние от земли до спутника 
        /// </summary>
        float rho0;
        /// <summary>
        /// Радиус спутника
        /// </summary>
        float satelliteR;
        /// <summary>
        /// X-координата левого верхнего угла спутника
        /// </summary>
        float satelliteULX;
        /// <summary>
        /// X-координата левого верхнего угла спутника
        /// </summary>
        float satelliteULY;              
        /// <summary>
        /// Приращение угла
        /// </summary>
        const float DT = (float)(Math.PI / 100);
        // Коэффициенты 
        const int EARTHCOEFFICIENT = 15, SATELLITECOEFFICIENT = 4, RCOEFFICIENT = 1, SCALEUNITCOEFFICIENT = 100;
        /// <summary>
        /// Обработчик события, возникающего при работе таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // TODO: подготовить и масштабировать данные для рисунка 
            tickCounter++; // счетчик тиков
            // TODO: обновить изображение
        }
        /// <summary>
        /// Обработчик события, возникающего при рисовании на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SatelliteForm_Paint(object sender, PaintEventArgs e)
        {
            // TODO: если таймер не работает, пересчитать масштабные соотношения
            // TODO: обновить изображение
        }
        /// <summary>
        /// Обработчик события, возникающего при нажатии на кнопку запуска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            // TODO: активировать таймер
        }
        /// <summary>
        /// Обработчик события, возникающего при рисовании на PictureBox'e
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics target = e.Graphics;
            // TODO: нарисовать две окружности: землю и спутник. Для земли задать зеленый цвет пера, для спутника – черный.
            // Рисовать, начиная с левого верхнего угла, ширина и высота окружностей – удвоенные радиусы.
        }
        /// <summary>
        /// Метод для подготовки и масштабирование данных для рисунка
        /// </summary>
        private void PictureData()
        {
            earthX = pictureBox.Size.Width / 2; // абсцисса центра земли
            earthY = pictureBox.Size.Height / 2; // ордината центра земли
            scaleUnit = Math.Min(earthX, earthY) / SCALEUNITCOEFFICIENT; // единица масштаба 
            earthR = scaleUnit * EARTHCOEFFICIENT; // радиус земли
            // левый верхний угол для земли 
            earthULX = earthX - earthR;
            earthULY = earthY - earthR;
            satelliteR = scaleUnit * SATELLITECOEFFICIENT; // радиус спутника
            // левый верхний угол для спутника
            satelliteULX = earthULX;
            satelliteULY = earthULY;               
            float rho; // расстояние от земли до спутника 
            rho0 = (float)Math.Sqrt(Math.Pow(satelliteULX - earthX, 2) + Math.Pow(satelliteULY - earthY, 2));
            float dR = scaleUnit * RCOEFFICIENT;
            rho = Math.Min(rho0 + tickCounter * dR, scaleUnit * 80);
            satelliteULX = (float)(rho * Math.Cos(THETA0 + tickCounter * DT)) + earthX;
            satelliteULY = (float)(rho * Math.Sin(THETA0 + tickCounter * DT)) + earthY;
        }
    }
}
