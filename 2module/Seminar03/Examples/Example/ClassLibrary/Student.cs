using System;

namespace ClassLibrary
{
    public class Student
    {
        public static int CountOfStudents;//количество студентов в вузе
        private int course;
        public int Course
        {
            get => course;
            private set
            {
                course = value <= 0 || value >= 6 ? 1 : value;//вспомнить что это такое
            }
        }

        private readonly string Sex;//можно задать значение либо как у константы при инициализации или в контрукторе класса
        public string Name { get; }//на самом деле тоже REDAONLY
        public double AverageMark { get; private set; }

        /// <summary>
        /// метод получения оценки
        /// </summary>
        /// <param name="rnd"></param>
        public void GetGraduate(Random rnd)//всегда передавайте псевдорандом иначе будет работать очень криво
        {
            if (rnd.Next(0, 2) == 1)
            {
                this.AverageMark *= 1.05;
                if (this.AverageMark > 10)//не забывайте такие проверки на самостах
                    AverageMark = 10;
            }
            else
            {
                this.AverageMark *= 0.95;
            }
        }

        static Student()
        {
            CountOfStudents = 0;//инициализирует единожды       
        }

        public Student(int course, string sex, string name, double averageMark)
        {
            CountOfStudents++;//статическое поле
            Course = course;
            Sex = sex;
            Name = name;
            AverageMark = averageMark;
        }

        public string GetInfo() => $"Name: {Name}\nSex: {Sex}\tCourse: {Course}\tAverageMark: {AverageMark:f3}";
    }
}
