using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        int Id;

        public Person(int id)
        {
            Id = id;
        }

        public override string ToString() => $"I am person, my Id: {Id}";

    }

    class Seqences
    {
        List<Person> people;

        public Seqences(List<Person> people)
        {
            this.people = people;
        }

        //именованный итератор без парметров выводящий элементы через одного


        //именованный итератович с 1 целочисленным параметром n  выводящий элементы через n
        
        //обычный итератор через лист (те не прописывать руками, а (new List<T>()).GetEnimerator()))

    }
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Random rnd = new Random();
            int rand = rnd.Next(10, 50);
            List<Person> hum = new List<Person>();
            for (int i = 0; i < rand; i++)
            {
                hum.Add(new Person(k++));
            }
            Seqences Army = new Seqences(hum);
            foreach (var item in Army)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in Army.ThroughtOne)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            foreach (var item in Army.Passing(10))
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }
    }
}
