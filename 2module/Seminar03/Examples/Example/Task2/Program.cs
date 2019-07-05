using System;
using ClassLibrary;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teacher = new Teacher[Rnd.rnd.Next(1, 15)];
            for (int i = 0; i < teacher.Length / 3; i++)
            {
                teacher[i] = new Teacher(Rnd.rnd.Next(20, 35), Rnd.CreateName());
            }
            for (int i = teacher.Length / 3; i < teacher.Length; i++)
            {
                teacher[i] = new Teacher(Rnd.rnd.Next(35, 60), Rnd.CreateName(), Rnd.GetDegree());
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
