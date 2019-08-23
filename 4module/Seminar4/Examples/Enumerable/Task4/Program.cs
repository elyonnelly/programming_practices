using System;
using System.Collections.Generic;
using System.Threading;

namespace Task4
{
    //ленивая колекция дает элементы когда у нее их запрашивают,
    //те они коллекция не была заполнена до того, как к ней обратились
    //задача: выводить элементы последовательности до момента, когда пользовательне нажмет какую-либо кнопку

    class Seqences
    {
        /// <summary>
        /// именованный итератор
        /// </summary>
        public static IEnumerable<int> Fibonacci
        {
            get
            {
                int a = 1;
                int b = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    int c = a + b;
                    a = b;
                    b = c;
                    yield return c;
                }
            }
        }
        /// <summary>
        /// именованный итератор от параметров
        /// </summary>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static IEnumerable<int> Exponential(int multiplier)
        {
            var a = 1;

            while (true)
            {
                yield return a;
                a *= multiplier;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Seqences.Fibonacci)
            {
                Console.WriteLine(item);
                Thread.Sleep(100);
                if (Console.KeyAvailable) break;
            }
            //foreach (var item in Seqences.Exponential(3))
            //{
            //    Console.WriteLine(item);
            //    Thread.Sleep(100);
            //    if (Console.KeyAvailable) break;
            //}
        }
    }
}
