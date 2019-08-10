using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_02_Exp
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 3, 1, 2, 4, 5 };
            HashSet<int> setA = new HashSet<int>(arr); // System.Collection.Generic
            Console.Write("A: ");
            foreach (int x in setA) Console.Write(x + " ");// 3 1 2 4 5
                                                           // Добавление одного и того же значения
            setA.Add(45); setA.Add(45);
            Console.Write("\nA: ");
            foreach (int x in setA) Console.Write(x + " ");// 3 1 2 4 5 45
                                                           // создаём множество B
            int[] arr2 = { 1, 2, 7, 7, 15 };
            HashSet<int> setB = new HashSet<int>(arr2);
            Console.Write("\nB: ");
            foreach (int x in setB) Console.Write(x + " ");// 1 2 7 15
                                                           // Формируем пересечение множеств System.Linq
            HashSet<int> intersectAB = new HashSet<int>(setA.Intersect(setB));
            Console.WriteLine("\n A intersection B:");
            foreach (int x in intersectAB) Console.Write(x + " "); // 1 2
            Console.ReadLine();
        }
    }
}
