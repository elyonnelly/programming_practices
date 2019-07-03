using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] array = new Person[5];
            for (int i = 0; i < array.Length/2; i++)
            {
                //создайте обьекты с помощью композиции
            }
            for (int i = array.Length/2; i < array.Length; i++)
            {
                //создайте обьекты с помощью агрегации
            }
            PrintPersons(array);
            Console.Read();
        }

        private static void PrintPersons(Person[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);//не обязательно писать ToString()
            }
        }
    }

    class Person
    {
        public Person()
        {
            //TODO инициализируйте child с помощью композиции
            Name = Child.RandomName();
        }

        public Person(Child child)
        {
            this.child = child;
            Name = Child.RandomName();
        }

        Child child { get; }// вспомните, что значит автосвоство только с get акцессором( 3 семинар 2 модуля есть в примерах пояснения)
        readonly string Name;

        public override string ToString() => $"Person: {Name}, his child: {child.ToString()}";//TODO сделайте так чтобы выводилось имя ребенка 
        public class Child
        {
            static Random rnd = new Random();
            public Child()
            {
                Name = RandomName();
            }

            public static string RandomName()
            {
                string name = "";
                name += (char)rnd.Next('A', 'Z');
                for (int i = 0; i < rnd.Next(4, 8); i++)
                {
                    name += (char)rnd.Next('a', 'z');
                }
                return name;
            }
            string Name { get; }
        }
    }
    

}
