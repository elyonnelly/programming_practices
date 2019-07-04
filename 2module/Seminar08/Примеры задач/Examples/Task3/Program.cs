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
                car[i] = new Car(Car.GenerateLine(),Car.rnd.Next(1,120)+Car.rnd.NextDouble(),Car.rnd.Next(1,10));
            }
            foreach (var item in car)
            {
                Console.WriteLine(item);// без ToString()
            }
            Console.Read();
        }
    }
ConsoleApp2
    public class Car
    {
        Engine engine { get; }
        string Owner { get; }
        double Speed { get; }
        int Age { get; }
        public static Random rnd = new Random();

        public Car(string owner, double speed, int age)
        {
            Owner = owner;
            Speed = speed;
            Age = age;
            engine = new Engine(rnd.Next(20,200)+rnd.NextDouble(),GenerateLine(), rnd.Next(50, 100) + rnd.NextDouble(),this);//обратите внимание перекидываем через this
        }
        public static string GenerateLine()
        {
            string res = String.Empty;//пустая строка
            int length = rnd.Next(5, 15);
            for (int i = 0; i < length; i++)
            {
                res += (char)rnd.Next('a', 'z');
            }
            return res;
        }
        /// <summary>
        /// Вложенный класс
        /// </summary>
        class Engine
        {
            double Power { get; }
            string Type { get; }
            double Weight { get; }
            Car car { get; }
            public Engine(double power, string type, double weight,Car car)
            {
                this.car = car;
                Power = power;
                Type = type;
                Weight = weight;              
            }
            public override string ToString() => $"Car\nOwner: {car.Owner}\tSpeed: {car.Speed:f3}\tAge: {car.Age}\nEngine:\nPower: {Power:f3}\tType: {Type}\tWeight: {Weight:f3}\n";
        }
        public override string ToString() => $"{engine}";//вызывает ToString 
    }

}
