﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк с массиве:");
            int n = Reading();
            int[][] array = new int[n][];
            CreateAndFill(array);
            PrintF(array);
            Console.Read();
        }

        /// <summary>
        /// метод ввывода элментов массива
        /// </summary>
        /// <param name="array"></param>
        private static void PrintF(int[][] array)
        {
            foreach (var item in array)//сначала
            {
                foreach (var e in item)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// метод создания и заполнения массива
        /// </summary>
        /// <param name="array"></param>
        private static void CreateAndFill(int[][] array)
        {
            int count = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new int[count++];//подумайте почему это работает правильно
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(-5, 10);
                }
            }
        }

        /// <summary>
        /// метод для чтения количества строк в треугольнике
        /// </summary>
        /// <returns></returns>
        private static int Reading()
        {
            int k;
            while (!int.TryParse(Console.ReadLine(), out k) && k < 0)
            {
                Console.WriteLine("Error");
            }
            return k;
        }
    }
}
