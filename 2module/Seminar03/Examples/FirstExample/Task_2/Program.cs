using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Teacher[] teacher = new Teacher[rnd.Next(1, 15)];
            for (int i = 0; i < teacher.Length/3; i++)
            {
                teacher[i] = new Teacher(rnd.Next(20, 30), RandomL.CreateName(rnd));
            }
            for (int i = teacher.Length/3; i < teacher.Length; i++)
            {
                teacher[i] = new Teacher(rnd.Next(20, 30), RandomL.CreateName(rnd),RandomL.GetDegree(rnd));
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
