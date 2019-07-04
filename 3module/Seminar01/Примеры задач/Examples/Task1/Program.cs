using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Program
    {
        // Объявление делегата-типа:
        delegate int Cast(double value);

        static void Main()
        {
            // Анонимный метод
            Cast firstHangler = null; // null нужен только для того чтобы испоьлзовать += . Можно избежать 
            firstHangler += delegate (double val)
            { // Помните ли вы, как работает следующая стока?
                return Math.Ceiling(val) % 2 == 0 ? (int)Math.Ceiling(val) : (int)Math.Floor(val);
            };

            Cast secondHangler = delegate (double val)
            {
                return (int)Math.Truncate(Math.Exp(Math.Sqrt(val)));
            };

            Random rnd = new Random(); // TODO почему программа будет работать неверно, если объявить rnd внутри цикла?
            double[] array = new double[5];
            for (int i = 0; i < 5; i++)
            {
                double value = Math.Round(rnd.Next(0, 64) + rnd.NextDouble(), 4);
                array[i] = value;
                Console.WriteLine($"value = {value}; \t firstHangler(value) = {firstHangler(value)} \t secondHangler(value) = {secondHangler(value)}");
            }
            Console.ReadLine();
        }
    }
}