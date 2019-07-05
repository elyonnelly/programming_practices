using System;
using System.Collections.Generic;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<Student> lststd = new List<Student>();
                int rnk = Rnd.rnd.Next(5, 11);
                for (int i = 0; i < rnk; i++)
                {
                    lststd.Add(new Student(Rnd.rnd.Next(0, 8), Rnd.GetSex(), Rnd.CreateName(), Rnd.rnd.Next(0, 10) + Rnd.rnd.NextDouble()));
                    if (Student.CountOfStudents % 2 == 0)
                        lststd[i].GetGraduate(Rnd.rnd);
                }
                Print(lststd);
                Console.WriteLine("To exit push Escape");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
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
