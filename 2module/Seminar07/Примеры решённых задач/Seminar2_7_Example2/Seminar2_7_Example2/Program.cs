using System;
using System.Collections.Generic;
using TransportLibrary;

namespace Seminar2_7_Example2
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            //обратите внимание, что нельзя создать объект типа Transport
            var Buhanochka = new Truck(100);
            var Krusenstern = new Ship(1000);

            List<City> cities = new List<City>
            {
                new City("Barselona", true, 50000),
                new City("StPetersburg", true, 4000),
                new City("Yekaterinburg", false, 1000),
                new City("Moskow", false, 30000)
            };


            for (int i = 0; i < 10; i++)
            {
                var cargo = new Cargo(rnd.Next(10, 50));
                if (rnd.Next(2) == 1)
                {
                    Console.WriteLine(Buhanochka.Deliver(departure: cities[1], destination: cities[2], cargo));
                    Console.WriteLine(Buhanochka.Deliver(departure: cities[2], destination: cities[3], cargo));
                    Console.WriteLine(Buhanochka.Deliver(departure: cities[3], destination: cities[2], cargo));
                }
                else
                {
                    Console.WriteLine(Buhanochka.Deliver(departure: cities[3], destination: cities[2], cargo));
                    Console.WriteLine(Buhanochka.Deliver(departure: cities[1], destination: cities[0], cargo));
                    Console.WriteLine(Buhanochka.Deliver(departure: cities[0], destination: cities[2], cargo));
                }
                
            }
        }
    }
}
