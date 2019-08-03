using System;

namespace SampleTaskLib
{
    /// <summary>
    /// Класс Гендальфа.
    /// </summary>
    public class Gandlaf
    {
        /// <summary>
        /// Коэффициент при x^2
        /// </summary>
        public double A { get; private set; }
        /// <summary>
        /// Коэффициент при x
        /// </summary>
        public double B { get; private set; }
        /// <summary>
        /// Коэффициент при свободном члене
        /// </summary>
        public double C { get; private set; }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="a">Коэффициент при x^2</param>
        /// <param name="b">Коэффициент при x</param>
        /// <param name="c">Коэффициент при свободном члене</param>
        public Gandlaf(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// Вычисление суммы корней трехчлена
        /// </summary>
        /// <returns></returns>
        private int CalculateSumOfRoots(double discriminant)
        {
            double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
            double x2 = (B + Math.Sqrt(discriminant)) / (2 * A);
            return ((int)(x1 + x2));
        }

        /// <summary>
        /// Метод, определяющий можно ли пройти на территорию и время присутствия.
        /// </summary>
        public void TryToPass()
        {
            double D = Math.Pow(B, 2) - 4 * A * C;
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
