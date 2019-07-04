using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(Pow);//ToDo реализовать с помощью анонимного метода
            MyDelegate del2 = delegate (double x)
            {
                return Math.Sqrt(x);
            };

            Console.WriteLine($"{(del1 + del2)(double.Parse(Console.ReadLine())):f3}");//ToDo сделать так, чтобы выводился в модуль
            Console.Read();
        }
        private static double Pow(double x) => x * x;

    }

}
