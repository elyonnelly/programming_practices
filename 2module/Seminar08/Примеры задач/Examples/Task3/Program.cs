using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[4];
            for (int i = 0; i < car.Length; i++)
            {
                car[i] = new Car(Car.GenerateName(),Car.rnd.Next(1,120)+Car.rnd.NextDouble(),Car.rnd.Next(1,10));
            }
            foreach (var item in car)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }

    public class Car
    {
        Engine engine;
        string Owner;
        double Speed;
        int Age;
        public static Random rnd = new Random();

        public Car(string owner, double speed, int age)
        {
            Owner = owner;
            Speed = speed;
            Age = age;
            engine = new Engine(rnd.Next(20,200)+rnd.NextDouble(),GenerateName(), rnd.Next(50, 100) + rnd.NextDouble(),this);
        }
        public static string GenerateName()
        {
            string res = String.Empty;
            int length = rnd.Next(5, 15);
            for (int i = 0; i < length; i++)
            {
                res += (char)rnd.Next('a', 'z');
            }
            return res;
        }

        class Engine
        {
            double Power;
            string Type;
            double Weight;
            Car car;
            public Engine(double power, string type, double weight,Car car)
            {
                this.car = car;
                Power = power;
                Type = type;
                Weight = weight;              
            }
            public override string ToString() => $"Car\nOwner: {car.Owner}\tSpeed: {car.Speed:f3}\tAge: {car.Age}\nEngine:\nPower: {Power:f3}\tType: {Type}\tWeight: {Weight:f3}\n";
        }
        public override string ToString() => $"{engine}";
    }

}
