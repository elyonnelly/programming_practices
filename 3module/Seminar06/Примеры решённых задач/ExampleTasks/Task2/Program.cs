/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: показать передачу параметров в поток
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class ThreadWithState
    {
        private int index;
        private int count;

        public ThreadWithState(int index, int count)
        {
            this.index = index;
            this.count = count;
        }

        public void ThreadProc()
        {
            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine($"ThreadProc[{index}]: {i}");
                Thread.Sleep(0);
            }
        }
    }

    class Program
    {
        private const int NumberOfThreads = 17;
        private const int Count = 10;

        public static void PrintNumber(object obj)
        {
            var (index, count) = (Tuple<int, int>)obj;

            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine($"PrintNumber[{index}]: {i}");
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[NumberOfThreads];
            for (int i = 0; i < NumberOfThreads; ++i)
            {
                var x = new ThreadWithState(i, Count);
                threads[i] = new Thread(x.ThreadProc);
            }
            foreach (var i in threads)
                i.Start();
            Console.ReadKey();
        }
    }
}
