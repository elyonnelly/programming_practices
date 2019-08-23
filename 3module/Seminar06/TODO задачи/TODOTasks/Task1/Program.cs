/*
 * TODO Задачи
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private const int NumberOfThreads = 10;

        public static void PrintNumbers(object count)
        {
            // TODO по желанию: передавать в PrintNumbers номер потока и выводить его на экран
            // Пример вывода:
            // [Thread 4]: 6
            for (int i = 0; i < (int)count; ++i)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[NumberOfThreads];
            for (int i = 0; i < threads.Length; ++i)
            {
                // TODO: заполнить массив threads потоками с делегатом PrintNumbers и случайным count от 0 до 30
            }

            for (int i = 0; i < threads.Length; ++i)
            {
                // TODO: запустить все threads
                Console.WriteLine($"Поток {i} запущен!");
            }

            Console.ReadKey();
        }
    }
}
