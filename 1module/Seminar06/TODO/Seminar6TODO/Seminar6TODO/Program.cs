using System;

namespace Seminar6TODO
{

    class Program
    {
        /*
         * Рассмотрим последовательность чисел ai, i = 0, 1, 2, …, удовлетворяющих следующим условиям:
         * a_0 = 0
         * a_1 = 1
         * a_{2i} = a_i
         * a_{2i + 1} = a_i + a_{i + 1}
         * для каждого i = 1, 2, 3, …
         * Напишите программу, которая для заданного значения n находит максимальное среди чисел a0, a1, …, an.
         * */

        //TODO реализуйте ввод целого числа с клавиатуры, учитывайте возможность некорректного ввода
        static int Read(out int n)
        {

        }

        //TODO реализуйте поиск n-го члена последовательности
        static int GetMemberOfSequence(int number)
        {

        }

        static void UpdateMaximumOnSegment(ref int max, int length)
        {
            for (int i = 0; i <= length; i++) // устраиваем линейный поиск на последовательности от 0 до n
            {
                max = Math.Max(GetMemberOfSequence(i), max);
            }
        }

        static void Main(string[] args)
        {
            do
            {
                int n;
                while ((Read(out n)) != 0)
                {
                    int max = 0;
                    UpdateMaximumOnSegment(ref max, length: n);
                    Console.WriteLine(max);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape); // не забываем про повтор решения

        }
    }
}
