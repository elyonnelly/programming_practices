/* В основной программе вводится натуральное числ. Необходимо вычислить суммы его цифр, находящийся на позициях,
 * кратных заданным в последующих строках числах.
 * Разряд единиц считать нулевым и четным. 
 * Для этого написать метод с натуральным параметром, вычисляющий суммы цифр, находящихся на позициях, кратных заданному параметру.
 * Заголовок метода: int Sum(uint number, out uint position). 
 * Основная программа, используя метод, "общается с пользователем". */
using System;

namespace Example_Task_03
{
    class Program
    {
        /// <summary>
        /// Метод для вычисления сумм цифр числа, стоящих позициях, кратных position
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="position">число, которому должны быть кратны элементы, входящие в сумму</param>
        static int Sum(uint number, uint position)
        {
            //TODO 
        }

        static uint ReadUint()
        {
            uint number; 
            do
            {
                Console.Write("Введите натуральное число: ");
            }
            while (!uint.TryParse(Console.ReadLine(),  out number));
            return number;

        }

        static void Main()
        {
            Console.WriteLine("Введите число");
            uint number = ReadUint();
            Console.WriteLine("Введите количество искомых позиций");
            uint count = ReadUint();
            Console.WriteLine("Вводите числа");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Сумма цифр на позициях, кратных введенному числу: {Sum(number, ReadUint())}");
            }
        }
    }
}