using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxExampleClassLibrary
{
    /// <summary>
    /// Класс фрактала
    /// </summary>
    public abstract class Fractal
    {
        /// <summary>
        /// Объект растрового изображения
        /// </summary>
        protected Bitmap fractalBitmap;
        /// <summary>
        /// Поверхность для рисования
        /// </summary>
        protected Graphics g;
        /// <summary>
        /// Максимальная глубина рекурсии
        /// </summary>
        public const int MAXRECURSIONDEPTH = 8;
        /// <summary>
        /// Начальный цвет
        /// </summary>
        protected Color startColor;
        /// <summary>
        /// Конечный цвет
        /// </summary>
        protected Color endColor; 
        /// <summary>
        /// Размер области отрисовки фрактала (область квадратная)
        /// </summary>
        protected int drawingDimension;
        /// <summary>
        /// Длина отрезка на первой итерации
        /// </summary>
        protected int length;
        /// <summary>
        /// Текущий уровень рекурсии
        /// </summary>
        protected int curRecursionDepth;
        /// <summary>
        /// Сдвиг относительно границы PictureBox'а по ширине
        /// </summary>
        protected int widthOffset;
        /// <summary>
        /// Сдвиг относительно границы PictureBox'а по высоте
        /// </summary>
        protected int heightOffset;

        /// <summary>
        /// Конструктор, задающий значения параметров
        /// </summary>
        /// <param name="width">Ширина области рисования</param>
        /// <param name="height">Высота области рисования</param>
        /// <param name="curRecursionDepth">Текущий уровень рекурсии</param>
        /// <param name="startColor">Начальный цвет</param>
        /// <param name="endColor">Конечный цвет</param>
        protected Fractal(int width, int height, int curRecursionDepth, Color startColor, Color endColor)
        {
            drawingDimension = Math.Min(width, height);
            this.startColor = startColor;
            this.endColor = endColor;
            this.curRecursionDepth = curRecursionDepth;
            widthOffset = (width - drawingDimension) / 2;
            heightOffset = (height - drawingDimension) / 2;
        }

        /// <summary>
        /// Массив цветов по итерациям
        /// </summary>
        public Color[] colorArray;

        /// <summary>
        /// Метод для вычисления цветов по итерациям
        /// </summary>
        public void GetCurIterationColor()
        {
            // Создание промежуточного массива
            Color[] curColorArray = new Color[curRecursionDepth];
            curColorArray[0] = startColor;

            // Если глубина рекурсии - 1, то массив цветов будет состоять только из одного элемента: начального цвета;
            if (curRecursionDepth == 1)
            {
                colorArray = curColorArray;
                return;
            }

            // Разделение начального цвета на компоненты RGB
            int rSColor = startColor.R;
            int gSColor = startColor.G;
            int bSColor = startColor.B;
            // Разделение конечного цвета на компоненты RGB
            int rEColor = endColor.R;
            int gEColor = endColor.G;
            int bEColor = endColor.B;

            for (int i = 0; i < curColorArray.Length; i++)
            {
                // Вычисление цвета для очередной итерации с использованием линейного градиента
                var rIterationColor = rSColor + (rEColor - rSColor) * i / (curColorArray.Length - 1);
                var gIterationColor = gSColor + (gEColor - gSColor) * i / (curColorArray.Length - 1);
                var bIterationColor = bSColor + (bEColor - bSColor) * i / (curColorArray.Length - 1);
                // Заполнение промежуточного массива значениями цветов для линейного градиента
                curColorArray[i] = Color.FromArgb(rIterationColor, gIterationColor, bIterationColor);
            }

            // Реверсирование массива, так как цвета хранятся в обратном порядке
            Array.Reverse(curColorArray);
            // Передача внешнему массиву значений промежуточного
            colorArray = curColorArray;
        }

        /// <summary>
        /// Метод для отрисовки фрактала
        /// </summary>
        /// <param name="fractalPictureBox">Область для отрисовки фрактала</param>
        public virtual void Draw(PictureBox fractalPictureBox) { }
    }
}
