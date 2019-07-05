using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructStatic
{
    struct Test1 // Объявление структуры
    {
        public int a;
        static Test1() // Создаем статический конструктор структуры, который сообщает свой вызов
        {
            Console.WriteLine("Вызвался статический конструктор структуры");
        }

    }

    class Test2 // объявление класса
    {
        public int a;
        static Test2()// Создаем статический конструктор класса, который сообщает свой вызов
        {
            Console.WriteLine("Вызвался статический конструктор класса");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test1 test1 = new Test1(); // Создадим объект структуры
            Console.WriteLine("Присваиваем значение");
            test1.a = 10;// Присвоим полю значение 10
            Console.WriteLine(test1.a);// Выведем поле

            Test2 test2 = new Test2();// Создадим объект класса
            Console.WriteLine("Присваиваем значение");
            test2.a = 20; // Присвоим полю значение 20
            Console.WriteLine(test2.a); // выведем поле

            Console.ReadKey();

            // По выполнении программы мы получим следующие выходные данные
            // ------
            // Присваиваем значение
            //10
            //Вызвался статический конструктор класса
            //Присваиваем значение
            //20
            // ------
            // Данный пример илюстрирует то, что статическтй конструктор структуры вызывается при обращении к статическим полям и методам,
            // а статический конструктор класса - до первого обращения к классу.
        }
    }
}
