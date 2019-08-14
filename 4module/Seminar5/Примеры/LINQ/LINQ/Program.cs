using System;
using System.Collections.Generic;
using System.Linq;

/*
 Создать класс Man с открытым полями string Name, string Surname, DateTime Birthday.
 Определить свойство, которое возвращает целое число, сколько лет человеку. Переопределить метод ToString, чтобы он выводил
 информацию об объекте в виде "Имя Фамилия, ДД.ММ.ГГГГ" (Если день и месяц выражаются через одну цифру, нули можно не писать)

    В основной программе создать список из 20 человек с фамилиями и именами из заданного списка, а год рождения в диапазоне от
    2000 до 2019. С помощью LINQ выбрать тех людей, которым больше 15 лет и отсорьировать их по фамилии.

Создать повтор решения
     
 */

namespace LINQ
{

    class Man
    {
        public string Name,
            Surname;
        DateTime BirthDay;

        public Man(string name, string surname, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
        }

        public int GetYear { get 
                {
                DateTime now = DateTime.Now;
                int years = now.Year - BirthDay.Year;
                if (now.Month*32 + now.Day < BirthDay.Month*30+BirthDay.Day)
                    --years;
                return years;
                }
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, {BirthDay.Day}.{BirthDay.Month}.{BirthDay.Year}";
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] names = { "Mark", "Oleg", "Andrew", "Alex", "Olya", "Max", "Piter", "John", "Tom", "Jake", "Bruce" };
            string[] surnames = { "Petrov", "Ivanov", "Sidorov", "Matveev", "Blade", "Shan", "Nikolaev", "Baskov", "Galkin", "Wayne" };
            do
            {
                Console.Clear();
                List<Man> men = new List<Man>();
                for (int i = 0; i < 20; i++)
                {
                    men.Add(new Man(names[rnd.Next(0,names.Length)], 
                        surnames[rnd.Next(0,surnames.Length)],
                        new DateTime(year: rnd.Next(2000, 2017), month:rnd.Next(1,13), day: rnd.Next(1,28))));
                }

                foreach (var item in men)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("---Linq---");

                var selection = from item in men
                                where item.GetYear > 15
                                orderby item.Surname
                                select item;

                foreach (var item in selection)
                {
                    Console.WriteLine(item);
                }

            }while(Console.ReadKey(true).Key == ConsoleKey.Enter);

        }
    }
}
