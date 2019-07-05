/* В основной программе ввести натуральное число и вычислить суммы его цифр, находящийся на четных и на нечетных рязрядах. 
 * Разряд единиц считать нулевым и четным. 
 * Для этого написать метод с натуральным параметром, вычисляющий суммы цифр, находящихся на четных и на нечетных позициях 
 * в записи значения параметра. 
 * Заголовок метода: void Sums(uint number, out uint sumEven, out uint sumOdd). 
 * Основная программа, используя метод, "общается с пользователем". */
using System;

namespace Example_Task_03
{
    class Program
    {
        /// <summary>
        /// Метод для вычисления сумм цифр числа, стоящих на четных и нечетных позициях.
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="sumEven">Сумма цифр на четных позициях</param>
        /// <param name="sumOdd">Сумма цифр на нечетных позициях</param>
        private static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            uint cur, cur2, number2;

            number2 = number / 10;

            while (number != 0 | number2 != 0)
            {
                cur = number % 10;
                cur2 = number2 % 10;
                number /= 100;
                number2 /= 100;
                sumEven += cur;
                sumOdd += cur2;
            }
        }

        static void Main()
        {
            uint sumEven, number, sumOdd;
            do Console.Write("Введите натуральное число: ");
            while (!uint.TryParse(Console.ReadLine(), out number));
            Sums(number, out sumEven, out sumOdd);
            Console.WriteLine($"Сумма цифр на четных позициях = {sumEven}\nСумма цифр на нечетных позициях = {sumOdd}");
            Console.ReadKey();
        }
    }
}
