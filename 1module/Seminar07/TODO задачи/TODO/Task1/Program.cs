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
            Random rnd = new Random();
            int length;
            do // ввод размера массива
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out length) || length < 1);

            int[] array = new int[length];
            for (int i = 0; i < length; i++) // генерация массива
            {
                array[i] = rnd.Next(100);
            }

            /*TODO
            Развернуть массив, не используя Reverse и не создавая новый.  
            */

            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Read();
        }
    }
}
