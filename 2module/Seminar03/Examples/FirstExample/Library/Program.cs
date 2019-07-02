using System;
using System.Collections.Generic;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ConsoleKeyInfo l;
            do
            {
                List<Student> lststd = new List<Student>();
                for (int i = 0; i < rnd.Next(5, 11); i++)
                {
                    lststd.Add(new Student(rnd.Next(0, 8), RandomL.GetSex(rnd), RandomL.CreateName(rnd), rnd.Next(0, 10) + rnd.NextDouble()));
                    if (Student.CountOfStudents % 2 == 0)
                        lststd[i].GetGraduate(rnd);
                }
                Print(lststd);
                Console.WriteLine("To exit push Escape");
                l = Console.ReadKey(true);
            } while (l.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// метод вывода
        /// </summary>
        /// <param name="lststd"></param>
        private static void Print(List<Student> lststd)
        {
            foreach (var item in lststd)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine($"Count of Students: {Student.CountOfStudents}");
        }

        

       
    }
}
