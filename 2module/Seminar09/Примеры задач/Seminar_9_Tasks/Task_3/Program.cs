/*
Бинарные флаги
*/
using System;

namespace Task_3
{
    class Program
    {
        [Flags]
        enum MyBit
        {
            V1 = 1,
            V2 = 2,
            V3 = 4,
            V4 = 8,
            V5 = 16
        }

        static void Main(string[] args)
        {
            ShowAllBits();
            Console.ReadKey();
        }
        static void ShowAllBits()
        {
            for (int i = 1; i < 32; i++)
                Console.WriteLine("{0} - {1}", i, (MyBit)i);
            // что выведет код ниже ?
            // for (int i = 1; i <= 32; i++)
            //   Console.WriteLine("{0} - {1}", i, (MyBit)i);
        }
    }
}
