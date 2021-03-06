﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do // безопасный ввод натурального числа большего 2
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 3);

            int[] mas = new int[n];

            for (int i = 0; i < n; i++) // заполняем массив, проверяя вводимые пользователем числа на корректность
            {
                int k;
                do
                {
                    Console.WriteLine($"Введите {i}-ое число");
                } while (!int.TryParse(Console.ReadLine(), out k));
                mas[i] = k;
            }

            int sum = 0, mult = 1;

            foreach (int item in mas) // цикл foreach проходит по всем элементам коллекции
            {
                sum += item; // сумма
                mult *= item; // произведение
            }

            int result = 0;
            for (int i = 0; i < n; i++) // циклом for проходимся по массиву, проверяя индексы на четность
            {
                if (i % 2 == 0) result += mas[i];
                else result -= mas[i];
            }

            Console.WriteLine($"Сумма : {sum}");
            Console.WriteLine($"Произведение : {mult}");
            Console.WriteLine($"Сложная сумма : {result}");


            Console.Read();
        }
    }
}
