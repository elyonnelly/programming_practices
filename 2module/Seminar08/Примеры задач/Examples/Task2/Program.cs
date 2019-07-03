using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            int occupantsNumber = rnd.Next(2, 10);
            Occupant[] occupants = new Occupant[occupantsNumber];

            for (int i = 0; i < occupantsNumber; i++)
            {
                occupants[i] = new Occupant(GenerateName(), rnd.Next(1, 100));
            }

            House house = new House(occupants);

            Console.WriteLine(house);
            Console.ReadKey();
        }

        static string GenerateName()
        {
            string res = String.Empty;
            int length = rnd.Next(5, 15);
            for (int i = 0; i < length; i++)
            {
                res += (char)rnd.Next('a', 'z');
            }
            return res.Substring(0, 1).ToUpper() + res.Substring(1);
        }
    }

    class House
    {
        Occupant[] occupants;

        public House(Occupant[] occupants)
        {
            this.occupants = occupants;
        }

        public override string ToString()
        {
            string res = "Occupants: \n";
            for (int i = 0; i < occupants.Length; i++)
            {
                res += occupants[i].ToString() + "\n";
            }
            return res;
        }
    }

    class Occupant
    {
        public Occupant(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
