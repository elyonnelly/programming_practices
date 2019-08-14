/* Разработать игру на основе оконного приложения. Кнопка появляется и исчезает на форме. 
 * Цель игры: пока кнопка видна, кликать по ней мышью. Клики по кнопки учитываются как попадания, клики мимо – промахи. 
 * Подсчёт очков ведётся в объекте класса Rate. Описание класса разместить в отдельном файле в библиотеке классов.
 * Создать форму с одной кнопкой (Button) и двумя метками (Label). 
 * Изменить названия для кнопки на button, для меток на failsLabel и hitsLabel. 
 * Для управления временем отображения кнопки использовать компонент Timer. 
 * Для этого добавить его к форме и установить свойство Interval = 1000, Enabled = true. */

/* TODO: усложнить игру, запрограммировав появление кнопки в произвольном месте формы. 
 * Ограничение: кнопка полностью должна попадать в окно и не накладываться на область «счёта». 
 * Каждые 5 попаданий менять цвет формы на случайно сгенерированный цвет.
 * Создать PictureBox, невидимый в ходе игры. 
 * Каждые 20 попаданий запускать событие рисования случайных разноцветных штрихов по всему PictureBox на некоторый промежуток времени. 
 * Также выводить сообщение: "New achievment unlocked! {n} hits were successful.*/

using System;
using System.Windows.Forms;
using WF_TODOTasks_ClassLibrary;


namespace TODO_Task_02
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// Объект, отвечающий за подсчёт очков
        /// </summary>
        Rate gameRating = new Rate();
        public GameForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события, возникающего при клике на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, System.EventArgs e)
        {
            gameRating.Hits++;
            // TODO: увеличить счетчик в hitsLabel
        }
        /// <summary>
        /// Обработчик события, возникающего при работе таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // TODO: изменить состояние кнопки по тику таймера
        }
        /// <summary>
        /// Обработчик события, возникающего при клике мыши по форме (то есть, мимо кнопки)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            gameRating.Fails++;
            // TODO: увеличить счетчик в failsLabel
        }
    }
}
