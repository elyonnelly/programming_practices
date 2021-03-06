﻿/* Разработать оконное приложение, позволяющее:
 * 1) Отрисовать H-фрактал;
 * 2) Установить количество шагов рекурсии (глубину);
 * 3) Автоматически перерисовывать фрактал при изменении размеров окна;
 * 4) Предоставлять пользователю возможность выбора двух цветов startColor и endColor. 
 * Цвет startColor используется для отрисовки элементов первой итерации, цвет endColor – последней. 
 * Цвета для промежуточных итераций вычисляются с использованием линейного градиента.
 * 5) Предоставлять возможность сохранения фрактала в виде картинки;
 * 6) Предоставлять возможность изменения прозрачности формы. */

using System;
using System.Windows.Forms;
using System.Drawing;
using PictureBoxExampleClassLibrary;

namespace Sample_Task_01
{
    public partial class FractalForm : Form
    {
        /// <summary>
        /// Экземпляр фрактала
        /// </summary>
        private Fractal fractal;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FractalForm()
        {
            //Метод, добавляющий на форму все компоненты, которые мы заявили в дизайнере форм (как то: label, PictureBox, etc.)
            InitializeComponent();

            //У самой формы и ее компонентов есть множество свойств,
            //которые вы можете посмотреть во вкладке Properies (Свойства), если нажать на интересующий компонент формы в дизайнере.
            hScrollBar.Value = 100;
            hScrollBar.Minimum = 15;
            // Получение разрешения экрана устройства
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            // Зададим минимальный размер формы
            MinimumSize = new Size(resolution.Width / 2 + 100, resolution.Height / 2 + 100);
            // Зададим максимальный размер формы
            MaximumSize = resolution;
            // Задание минимального выбираемого значения глубины рекурсии
            recursionDepthTrackBar.Minimum = 1;
            // Задание максимального выбираемого значения глубины рекурсии
            recursionDepthTrackBar.Maximum = Fractal.MAXRECURSIONDEPTH;
        }
        /// <summary>
        /// Обработчик события, возникающего при изменении значения прозрачности в поле ввода maskedTextBox.
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void MaskedTextBoxOpacity_TextChanged(object sender, EventArgs e)
        {
            /* В maskedTextBox задана маска 000 (0 -- любая цифра), так что на ввод в поле принимаются только не более чем трехзначные числа.
             * При возникновении ситуаций, когда введено число 100 < opacity < 1000, 
             * обрабатываем исключение FormatException,
             * которое выбрасывается при попытке поставить свойству Opacity (прозрачность) значение большее 100%. */

            try
            {
                Opacity = double.Parse(((MaskedTextBox)sender).Text) / 100;
            }
            catch (FormatException)
            {
                Opacity = 1.0;
            }
        }
        /// <summary>
        /// Обработчик события, возникающего при изменении положения слайдера scrollBar'a
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void HScrollBar_ValueChanged(object sender, EventArgs e)
        {
            //с помощью scrollBar'a тоже можно менять прозрачность формы, если считывать требуемый процент прозрачность с scrollBar. 
            //свойство Value у ScrollBar всегда от 0 до 100 (по сути, на какую долю был сдвинут ползунок скролла).
            maskedTextBoxOpacity.Text = ((HScrollBar)sender).Value.ToString();
        }
        /// <summary>
        /// Метод для отрисовки фрактала
        /// </summary>
        /// <param name="height">Высота изображения</param>
        /// <param name="width">Ширина изображения</param>
        private void PaintFractal(int height, int width)
        {
            // Задание начального и конечного цвета для отрисовки фрактала
            Color startColor = buttonStartColor.BackColor;
            Color endColor = buttonEndColor.BackColor;
            // Задание глубины рекурсии
            int depth = recursionDepthTrackBar.Value;
            fractal = new HFractal(width, height, depth, startColor, endColor);
            // Отрисовка фрактала
            fractal.Draw(pictureBoxFractal);
        }
        /// <summary>
        /// Обработчик события, возникающего при нажатии на кнопку выбора начального цвета
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void ButtonStartColor_Click(object sender, EventArgs e)
        {
            /* Среди возможных компонентов для формы есть SomeDialog, то есть диалоговые окна.
             * Например, ColorDialog представляет общее диалоговое окно, в котором отображаются доступные цвета и элементы управления,
             * позволяющие пользователю определять собственные цвета. FolderDialog позволяет пользователю выбрать папку в проводнике.
             * После окончания работы пользователя с диалоговым окном, компонент в соответствующих свойствах хранит
             * всю интересующую нас информацию.*/

            ColorDialog startColor = (ColorDialog)sender;

            // Отображение диалогового окна для выбора начального цвета
            DialogResult SResult = startColor.ShowDialog();
            // Проверка выбора цвета. SResult хранит информацию о том, как закончился диалог с пользователем. OK -- успешно,
            // т.е. в конкретной ситуации -- пользователь выбрал цвет.
            if (SResult == DialogResult.OK)
                // Присвоение кнопке начального цвета выбранного цвета
                buttonStartColor.BackColor = startColor.Color;
            // Отрисовка фрактала с использованием начального цвета
            PaintFractal(panelFractal.Height, panelFractal.Width);
        }
        /// <summary>
        /// Обработчик события, возникающего при нажатии на кнопку выбора конечного цвета
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void ButtonEndColor_Click(object sender, EventArgs e)
        {
            ColorDialog endColor = (ColorDialog)sender;
            // Отображение диалогового окна для выбора цвета
            DialogResult EResult = endColor.ShowDialog();
            // Проверка выбора цвета
            if (EResult == DialogResult.OK)
                // Присвоение кнопке конечного цвета выбранного цвета
                buttonEndColor.BackColor = endColor.Color;
            // Отрисовка фрактала с использованием конечного цвета
            PaintFractal(panelFractal.Height, panelFractal.Width);
        }
        /// <summary>
        /// Обработчик события, возникающего при изменении глубины рекурсии
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void RecursionDepthTrackBar_Scroll(object sender, EventArgs e)
        {
            // Вывод значения выбранной глубины рекурсии
            labelDisplayDepth.Text = ((TrackBar)sender).Value.ToString();
            // Отрисовка фрактала в соответствии с выбранной глубиной рекурсии                                          
            PaintFractal(panelFractal.Height, panelFractal.Width);
        }
        /// <summary>
        /// Обработчик события, возникающего при изменении размеров панели
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void PanelFractal_Resize(object sender, EventArgs e)
        {
            // Определение меньшей границы панели
            int minSize = panelFractal.Width > panelFractal.Height ?
                panelFractal.Height < 485 ? 485 : panelFractal.Height :
                panelFractal.Width < 485 ? 485 : panelFractal.Width;
            // Изменение размеров панели
            panelFractal.Height = minSize;
            panelFractal.Width = minSize;
            // Перерисовка фрактала в соответствии с новыми размерами панели
            PaintFractal(panelFractal.Height, panelFractal.Width);
        }
        /// <summary>
        /// Обработчик события, возникающего при нажатии на кнопку сохранения изображения
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Создание диалогового окна "Сохранить как..", для сохранения изображения
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save image as...",
                // Отображение предупреждения в случае, если пользователь указывает имя уже существующего файла
                OverwritePrompt = true,
                // Отображение предупреждения в случае, если пользователь указывает несуществующий путь
                CheckPathExists = true,
                // Список форматов файла, отображаемый в поле "Тип файла"
                Filter = "Image Files(*.PNG)|*.PNG",
                // Отображение кнопки "Справка" в диалоговом окне
                ShowHelp = true
            };
            // При нажатии кнопки "ОК" в диалоговом окне производится попытка сохранить изображение
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxFractal.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("The action cannot be completed because the file is open in another program.",
                                    "File in use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception undefinedException)
                {
                    MessageBox.Show("Something went wrong. " + undefinedException.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
