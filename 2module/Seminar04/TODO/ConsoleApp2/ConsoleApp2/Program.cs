﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class OffsetBook
    {
        int Mark;
        public OffsetBook(int mark)
        {
            Mark = mark;
        }
        public override string ToString()
        {
            return Mark.ToString(); 
        }
    }

    class Student
    {

        string name;
        int year;
        string voice = "YEAH, I'm student!";

        public void University()
        {
            Console.WriteLine("I'm student.");
        }

        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
    }

    class HSE_Student : Student
    {

        int IUP_cout;
        //TODO Создайте конструктор для HSE_Student из 3х параметров (name, year, IUP_count), 
        //используя базовый. 

        public void HSE()
        //Определить метод, который выводит сообщение типа
        //"YEAH, I'm HSE student! My name is Mark, I'm 12 years old! I have 1 IUP"
        //Использовать интерполяцию
        {
        }
    }

    class MSU_Student //TODO Напишите класс MSU_Student, по аналогии с классом HSE_Student
    { 
        OffsetBook offsetBook;
        public void MSU()
        //Определить метод, который выводит сообщение типа
        //"YEAH, I'm HSE student! My name is Mark, I'm 12 years old! I have 4 in my offset book"
        //Console.WriteLine(examBook) выведет значение examBook.Mark
        //Использовать интерполяцию
        {
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            //Создайте в программе массив имен string[] names = {"Mark", ...}
            int i;
            do
            {
                do
                {
                    Console.WriteLine("Введите количество студентов");
                } while (!int.TryParse(Console.ReadLine(), out i));
                Student[] students = new Student[i];
                //TODO Сгенерируйте с вероятностью 60% студента HSE, с вероятностью 30% студента MSU и
                //с вероятностью 10% студента. Выведите в столбик их клич(методы University, HSE, MSU, причем для каждого
                //студента свой университетский клич (Студент MSU должен использовать метод MSU())).
                //Имя студента случайное из заренее заданного списка имен
                //Годы студентов - целое число из диапазона [17,25]
                //Количество ИУПов - целое число из диапазона от [0,3]
                //Оценка в заетке - целое число из диапазона [2,5]
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
