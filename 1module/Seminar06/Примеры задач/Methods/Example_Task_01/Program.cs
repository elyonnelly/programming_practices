/* Задача: 
 * На вход подается целое число number. 
 * Необходимо вывести его в обратном порядке (справа налево). 
 * Все вычисления осуществлять в методе ReverseNumber(int number).
 * Использовать строки, массивы, списки и циклы ЗАПРЕЩАЕТСЯ.
 */

using System;

namespace Example_Task_01
{
    class Program
    {
        /// <summary>
        /// Метод для вычисления и вывода заданного числа в обратном порядке.
        /// </summary>
        /// <param name="num">Число, которое необходимо записать в обратном порядке</param>
        /// <returns></returns>
        private static int ReverseNumber(int num)
        {
            if (num < 10)
            {
                Console.Write(num);
                return num;
            }
            else
            {
                Console.Write(num % 10);
                return ReverseNumber(num / 10);
            }
        }

        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите число, которое необходимо записать в обратном порядке: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Входное значение должно быть целым числом типа Integer.");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Входное значение превосходит границы типа Integer.");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Входное значение должно быть целым числом типа Integer.");
                return;
            }

            Console.Write("Число, записанное в обратном порядке: ");
            ReverseNumber(number);
            Console.ReadKey();
        }
    }
}
