using System;
using ClassLibrary;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Teacher[] teacher = new Teacher[rnd.Next(1, 15)];
            for (int i = 0; i < teacher.Length / 3; i++)
            {
                teacher[i] = new Teacher(rnd.Next(20, 35), Rnd.CreateName(rnd));//посомтрите библеотеку
            }
            for (int i = teacher.Length / 3; i < teacher.Length; i++)
            {
                teacher[i] = new Teacher(rnd.Next(35, 60), Rnd.CreateName(rnd), Rnd.GetDegree(rnd));
            }
            Print(teacher);
            Console.Read();
        }

        private static void Print(Teacher[] teacher)
        {
            Console.WriteLine("Teachers in University:");
            foreach (var item in teacher)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
