/* Напишите программу, вычисляющую площадь и периметр треугольника по заданным длинам его сторон. Площадь вычислять по формуле Герона.
 * Декомпозируйте в отдельные методы:
 * 1) Вычисление площади треугольника;
 * 2) Вычисление периметра треугольника;
 * Методы должны возвращать false, если параметры заданы неверно и треугольник с такими длинами построить нельзя. Если треугольник существует, методы возвращают true.
 * На экран выведите площадь и периметр треугольника с точностью до 3 знаков после запятой. В случае, если треугольника не существует, выведите соответствующее осмысленное сообщение.
 * Пример входных данных:  
 * 1
 * 5
 * 1
 * Пример выходных данных:
 * Треугольника не существует 
 */
using System;

namespace Example_Task_02
{
    class Program
    {
        /// <summary>
        /// Метод, определяющий существует ли треугольник.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Cторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns></returns>
        static bool TriangleExists(double a, double b, double c)
        {
            return ((a + b > c) & (b + c > a) & (a + c > b));
        }

        /// <summary>
        /// Метод для вычисления периметра.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Cторона b</param>
        /// <param name="c">Сторона c</param>
        /// <param name="p">Периметр</param>
        /// <returns></returns>
        static bool Perimeter(double a, double b, double c, out double p)
        {
            if (!TriangleExists(a, b, c))
            {
                p = 0;
                return false;
            }
            else
            {
                p = a + b + c;
                return true;
            }
        }

        /// <summary>
        /// Метод для вычисления площади.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Cторона b</param>
        /// <param name="c">Сторона c</param>
        /// <param name="s">Площади</param>
        /// <returns></returns>
        static bool Square(double a, double b, double c, ref double s)
        {
            if (!TriangleExists(a, b, c))
                return false;
            else
            {
                double p;
                Perimeter(a, b, c, out p);
                s = Math.Sqrt((p / 2) * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
                return true;
            }
        }

        static void Main(string[] args)
        {
            double a, b, c, p, s = 0;
            do
            {
                do Console.WriteLine("Введите длину стороны a: ");
                while (!double.TryParse(Console.ReadLine(), out a));
                do Console.WriteLine("Введите длину стороны b: ");
                while (!double.TryParse(Console.ReadLine(), out b));
                do Console.WriteLine("Введите длину стороны c: ");
                while (!double.TryParse(Console.ReadLine(), out c));
                if (Perimeter(a, b, c, out p) & Square(a, b, c, ref s))
                    Console.WriteLine($"s = {s:f3}, p = {p:f3}");
                else Console.WriteLine("Параметры заданы неверно, треугольник с такими длинами построить нельзя.");
                Console.WriteLine("Нажмите ESC для выхода, любую клавишу для продолжения.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
