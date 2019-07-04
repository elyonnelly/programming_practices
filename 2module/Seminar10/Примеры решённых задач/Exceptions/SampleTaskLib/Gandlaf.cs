using System;

namespace SampleTaskLib
{
    /// <summary>
    /// Класс Гендальфа.
    /// </summary>
    public class Gandlaf
    {
        /// <summary>
        /// Коэффициенты при степенях трехчлена
        /// </summary>
        double a, b, c;

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="a">Коэффициент при x^2</param>
        /// <param name="b">Коэффициент при x</param>
        /// <param name="c">Коэффициент при свободном члене</param>
        public Gandlaf(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Свойства для доступа коэффицентов квадратного трехчлена.
        /// </summary>
        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// Вычисление суммы корней трехчлена
        /// </summary>
        /// <returns></returns>
        int CalculateSumOfRoots(double discriminant)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (b + Math.Sqrt(discriminant)) / (2 * a);
            return ((int)(x1 + x2));
        }

        /// <summary>
        /// Метод, определяющий можно ли пройти на территорию и время присутствия.
        /// </summary>
        public void TryToPass()
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) throw new NoPassageException();
            else
            {
                int amountOfHours = CalculateSumOfRoots(D);
                if (amountOfHours < 0) throw new NoPassageException();
                else
                {
                    if (amountOfHours == 0) throw new NoPassageException("Было близко, но я все-таки не могу позволить тебе пройти :(. Удачи в другой раз!");
                    else
                        Console.WriteLine($"Можешь проходить! Позволенное время присутствия: {amountOfHours} ч.");
                }
            }
        }
    }
}
