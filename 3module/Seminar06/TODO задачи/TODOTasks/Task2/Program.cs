using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static int[] numbers = new int[1000];

        public static void FillArray()
        {
            lock (numbers)
            {
                for (int i = 0; i < numbers.Length; ++i)
                {
                    // TODO: Заполнить массив любыми числами
                    numbers[i] = i;
                    Thread.Sleep(1);
                }
            }
        }

        public static void WorkWithArray()
        {
            // TODO: не выполнять цикл, пока fillThread не сгенерирует numbers

            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void Main(string[] args)
        {
            Thread fillThread = new Thread(FillArray);
            Thread workThread = new Thread(WorkWithArray);
            // TODO: запустить потоки в разном порядке, поиграться с локами в функциях, чтобы понять lock
            // TODO: Сделать так, чтобы сгенерированные числа выводились на экран

            Console.ReadKey();
        }
    }
}
