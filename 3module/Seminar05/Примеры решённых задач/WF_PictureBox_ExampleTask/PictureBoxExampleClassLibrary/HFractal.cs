using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PictureBoxExampleClassLibrary
{
     /// <summary>
     /// Класс, представляющий H-фрактал
     /// </summary>
    public class HFractal : Fractal
    {
        /// <summary>
        /// Конструктор для создания экземлпяра H-фрактала
        /// </summary>
        /// <param name="width">Ширина области рисования</param>
        /// <param name="height">Высота области рисования</param>
        /// <param name="curRecursionDepth">Текущий уровень рекурсии</param>
        /// <param name="startColor">Начальный цвет</param>
        /// <param name="endColor">Конечный цвет</param>
        public HFractal(int width, int height, int curRecursionDepth, Color startColor, Color endColor) :
            base(width, height, curRecursionDepth, startColor, endColor) { }

        /// <summary>
        /// Метод для отрисовки H
        /// </summary>
        /// <param name="x">Начальная координата по x</param>
        /// <param name="y">Начальная координата по y</param>
        /// <param name="length">Длина отрезка</param>
        /// <param name="pen">Перо</param>
        private void H(int x, int y, int length, Pen pen)
        {
            g.DrawLine(pen, x - length, y - length, x - length, y + length);
            g.DrawLine(pen, x - length, y, x + length, y);
            g.DrawLine(pen, x + length, y - length, x + length, y + length);
        }

        /// <summary>
        /// Метод для отрисовки H-фрактала
        /// </summary>
        /// <param name="x">Начальная координата по x</param>
        /// <param name="y">Начальная координата по y</param>
        /// <param name="length">Длина отрезка</param>
        /// <param name="curRecursionLevel">Текущий уровень рекурсии</param>
        public void HFractalDraw(int x, int y, int length, int curRecursionLevel)
        {
            // Вершины фигуры Н
            int x00; int x01; int x10; int x11;
            int y00; int y01; int y10; int y11;

            if (curRecursionLevel > 0)
            {
                // Получение цвета для текущей итерации
                GetCurIterationColor();
                // Задание цвета пера в соответствии с текущей итерацией
                Pen pen = new Pen(colorArray[curRecursionLevel - 1], 2); 

                // Вычисление координат для уменьшенных копий фигуры H
                x00 = x - length; y00 = y - length;
                x01 = x - length; y01 = y + length;
                x10 = x + length; y10 = y - length;
                x11 = x + length; y11 = y + length;

                // Рисование одной фигуры Н
                H(x, y, length, pen);
                // Уменьшение размера отрезка для фигуры в 2 раза
                length /= 2;

                // Рекурсивная отрисовка уменьшенных копий фигур H на каждом из 4 концов исходной фигуры
                HFractalDraw(x00, y00, length, curRecursionLevel - 1);
                HFractalDraw(x01, y01, length, curRecursionLevel - 1);
                HFractalDraw(x10, y10, length, curRecursionLevel - 1);
                HFractalDraw(x11, y11, length, curRecursionLevel - 1);
            }
        }

        /// <summary>
        /// Метод для отрисовки фрактала
        /// </summary>
        /// <param name="fractalPictureBox">Область для отрисовки фрактала</param>
        public override void Draw(PictureBox fractalPictureBox)
        {
            try
            {
                // Вычисление координаты центра
                int centerCoordinate = drawingDimension / 2;
                // Создание объекта растрового изображения
                fractalBitmap = new Bitmap(drawingDimension + 1, drawingDimension + 1);
                // Создание графического объекта для возможности рисования
                g = Graphics.FromImage(fractalBitmap);
                // Улучшение качества изображения
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                // Вызов метода для отрисовки фрактала
                HFractalDraw(centerCoordinate, centerCoordinate, drawingDimension / (MAXRECURSIONDEPTH / 2), curRecursionDepth);
                // Передача объекта растрового изображения на PictureBox
                fractalPictureBox.Image = fractalBitmap;
                fractalPictureBox.Location = new Point(widthOffset, heightOffset);
                fractalPictureBox.Size = new Size(drawingDimension, drawingDimension);
            }
            catch (Exception undefinedException)
            {
                MessageBox.Show("Something went wrong. " + undefinedException.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
