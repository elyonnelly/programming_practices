using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2
{
    /*
     В программе создать класс студент, в котором определены следующие свойства:
     string Name -- имя студента
     string Faculty -- название факультета
     Конструктор, принимающий на вход 2 параметра -- имя студента и название фаакультета

    В основной программе определить string[] names -- массив имен студентов
                                    string[] facultys -- массив с названиями факультета
                                    массив с названиями факультетов определить как ФКН, ФМЭиМП, ФГН, ФЭН
                                    string[] places -- массив местоположения факультетов -- Покровка, ордынка, старая басманная
    Определить массив факультетов правильно(с корректным местоположением)
    Определить массив студентов со случайным именем из списка и случайным факультетом

        С помощью LINQ создать и вывести на экран объекты анонимного типа, в которых есть 3 поля:
        Name - имя студента
        Facult - факультет
        Place - расположение факультета

        Вывести всю информацию о новых объектах на экран
         */
    class Student
    { 
        public string Name { get;}
        public string Faculty { get;}
        public Student(string name,string fac )
        { 
            this.Name = name;
            this.Faculty = fac;
        }

    }

    class Faculty
    {
        public Faculty(string name, string place)
        {
            Name = name;
            this.Place = place;
        }

        public string Name { get;}
        public string Place { get;}


    }

    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] names = {"John", "Sarah", "Bruce", "Piter", "Tom", "Mike", "Andrew", "Nick", "Jack" };
            string[] facultys = {"Факультет компьютерных наук", 
                "Факультет мировой экономики и мировой политики", "Факультет гуманитарных наук",
                "Факультет экономических наук"};
            string[] places = {"Покровка", "Ордынка", "Старая Басманная" };
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(names[rnd.Next(names.Length)], facultys[rnd.Next(facultys.Length)]));
            }

            Faculty[] buildings = new Faculty[facultys.Length];
            for (int i = 0; i < facultys.Length; i++)
            {
                buildings[i] = new Faculty(facultys[i], places[i%3]);
            }


            var selection = from student in students 
                            join place in buildings on student.Faculty equals place.Name
                            orderby student.Name
                            select new {Name = student.Name, 
                            Facult = student.Faculty, Place = place.Place };

            foreach (var item in selection)
            {
                Console.WriteLine($"{item.Name}, {item.Facult}, {item.Place}");
            }

            Console.ReadKey();
        }
    }
}
