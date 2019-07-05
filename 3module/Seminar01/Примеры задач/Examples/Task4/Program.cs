using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public delegate void ActionDel(int x, int y);

    static class MyMath
    {
        public static void Addition(int X, int Y)
        {
            Console.WriteLine($"{X} + {Y} = { X + Y }");
        }

        public static void Multiplication(int X, int Y)
        {
            Console.WriteLine($"{X} * {Y} = { X * Y }");
        }

        public static void Exponentiation(int X, int Y)
        {
            Console.WriteLine($"{X} ^ {Y} = { Math.Round(Math.Pow(X, Y), 4) }");
        }

        public static void Division(int X, int Y)
        {
            Console.WriteLine($"{X} / {Y} = { Math.Round((double)X / Y, 4) }");
        }

        public static void Subtraction(int X, int Y)
        {
            Console.WriteLine($"{X} - {Y} = { X - Y }");
        }
    }

    class Program
    {

        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            ActionDel actionDel = null;

            for (int i = 0; i < 15; i++)
            {
                switch (rnd.Next(5))
                { // Заполняем массив, дублируя методы в многоадресный делегат
                    case 0:
                        actionDel += MyMath.Addition; // Можно добавлять несколько раз один и тот же метод к делегату
                        break;
                    case 1:
                        actionDel += MyMath.Multiplication;
                        break;
                    case 2:
                        actionDel += MyMath.Exponentiation;
                        break;
                    case 3:
                        actionDel += MyMath.Division;
                        break;
                    case 4:
                        actionDel += MyMath.Subtraction;
                        break;
                }
            }

            actionDel?.Invoke(rnd.Next(-10, 11), rnd.Next(-10, 11));

            for (int i = 0; i < 15; i++)
            {
                actionDel -= MyMath.Multiplication;
                actionDel -= MyMath.Division;
            }
            Console.WriteLine("\n===================\n");
            actionDel?.Invoke(rnd.Next(-10, 11), rnd.Next(-10, 11));

            Console.ReadLine();
        }
    }
}
