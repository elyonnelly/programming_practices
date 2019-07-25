using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//ToDo порпишите правильный using

namespace Task1
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car(rnd.Next(20, 150), rnd.Next(40, 100) + rnd.NextDouble(),rnd.Next(500,1500));
            }
            FileStream fs = new FileStream("../../../mycars", FileMode.Create);
            //ToDO выберите правильную сериализацию и с ее помощью запишите информацию в файл 
            fs.Close();
            FileStream fs1 = new FileStream("../../../mycars", FileMode.Open);
            //прочтите информацию из файла и выведете ее на экран
            //cars=??????
            fs1.Close();
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.Read();

        }
    }
    [Serializable]
    class Car
    {
        private int power;
        public double currentspeed;
        private double maxspeed;
        private double wedht;

        public Car(int power, double currentspeed,  double wedht)
        {
            this.power = power;
            this.currentspeed = currentspeed;
            this.maxspeed = power/wedht+currentspeed;
            this.wedht = wedht;
        }

        public override string ToString()
        {
            return $"Power:{power},  Wedht: {wedht},  Current Speed : {currentspeed:f3},  Max Speed: {maxspeed:f3}";
        }
    }

}
