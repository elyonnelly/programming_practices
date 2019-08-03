/* Определить интерфейс числовых рядов с целочисленными членами. 
 * Реализуя интерфейс, определить класс для представления числового ряда Пелла:
 * a_i = a_i-2 + 2 * a_i-1; a_1 = 1, a_2 = 2.
 * В основной программе запросить у пользователя количество членов ряда Пелла и вывести их.*/

using InterfacesTODOClassLibrary;
using System;

/* TODO: Реализуя интерфейс ISeries, определить классы для представления числового ряда:
 * I. Фиббоначи: 
 * a_i = a_i-2 + a_i-1; i > 2; a_1 = 1, a_2 = 1
 * II. Люка:
 * a_i = a_i-2 + a_i-1; i > 2; a_1 = 2, a_2 = 1
 * В основной программе, используя метод PrintSeries() вывести на экран по k членов рядов Пелла, 
 * Фибоначчи и Люка. k – вводится с клавиатуры пользователем.*/

namespace Interfaces_Example_Task_01
{
    class Program
    {
        /// <summary>
        /// Метод для вывода k членов ряда
        /// </summary>
        /// <param name="k">количество членов ряда</param>
        /// <param name="serie">экземпляр класса ряда</param>
        static void PrintSeries(int k, ISeries serie)
        {
            for (int i = 0; i < k; i++)
                Console.Write($"{serie.GetNext}\t");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int k;
        }
    }
}
