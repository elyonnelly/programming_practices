using System;

namespace Seminar2_2_Examples
{
    class Program
    {
        private static Random rnd;
        private static string GenerateNewName()
        {
            string text = string.Empty + (char)rnd.Next(65, 91);
            for (int i = 1; i < rnd.Next(5, 15); i++)
            {
                text += (char)rnd.Next(97, 123);
            }

            return text;
        }
        static void Main()
        {
            rnd = new Random();

            var Gryffindor = new Faculty()
            {
                Name = "Gryffindor",
                Students = new Student[10]
            };
            for (int i = 0; i < 10; i++)
            {
                Gryffindor.Students[i] = new Student
                {
                    Surname = GenerateNewName(),
                    Course = rnd.Next(1, 8),
                    Sex = rnd.Next(2) == 0 ? "Male" : "Female"
                };
            }

            Console.WriteLine("Students on Gryffindor");
            foreach (var student in Gryffindor.Students)
            {
                Console.WriteLine(student.GetInfo() + "\n");
            }

            Console.WriteLine($"Count of girl on {Gryffindor.Name}: {Faculty.CountGirl(Gryffindor)}");

            var countOfStudentOnCourse = Faculty.CountStudentsOnCourse(Gryffindor);
            for (int course = 1; course <= 7; course++)
            {
                Console.WriteLine($"Count of student on {course} course: {countOfStudentOnCourse[course]}");
            }

            var McGonagall = new Professor
            {
                Surname = "McGonagall",
                Subject = "Transfiguration"
            };

            for(int i = 0; i < 5; i++)
            {
               Console.WriteLine(Gryffindor.ChangePoint(McGonagall, rnd.Next(-5, 5)));
            }

            Console.WriteLine($"count of point of Gryffindor: {Gryffindor.Point}");

            var Lockhart = new Professor
            {
                Surname = "Lockhart",
                Subject = "Defence Against the Dark Arts"
            };


            //Полиморфизм
            Console.WriteLine($"hahaha, {Lockhart.Surname} cast spell to {McGonagall.Surname}!");
            Lockhart.CastSpell(McGonagall);
            Console.WriteLine($"New Surname: {McGonagall.Surname}");

            Console.WriteLine($"hahaha, {Lockhart.Surname} cast spell to {Gryffindor.Students[0].Surname}!");
            Lockhart.CastSpell(Gryffindor.Students[0]);
            Console.WriteLine($"New Surname: {Gryffindor.Students[0].Surname}");

        }
    }
}
