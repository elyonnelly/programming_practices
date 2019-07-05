using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkLib;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink[] drinks = new Drink[5];
            drinks[0] = new Drink();

            /*
             * TODO заполнить массив до конца напитками со случайными значениями параметров
             */


            Random rnd = new Random();
            foreach (var item in drinks)
            {
                //Console.WriteLine(item[rnd.Next(-100, 100)]); //раскомментировать
            }

            Console.ReadLine();
        }
    }
}
