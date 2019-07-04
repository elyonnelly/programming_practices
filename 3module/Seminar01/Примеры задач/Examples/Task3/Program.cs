using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    delegate Point MoveDel(); // делегат-тип

    class Robot
    {
        Point point; // положение робота на плоскости

        public Robot()
        {
            this.point = new Point(0, 0); ;
        }

        public Point Right() { point.X++; return point; } // направо
        public Point Left() { point.X--; return point; } // налево
        public Point Forward() { point.Y++; return point; } // вперед
        public Point Backward() { point.Y--; return point; } // назад

        public void Reset()
        { // Обнулить координаты
            point = new Point(0, 0);
        }

        public override string ToString()
        { // Сообщить координаты
            return string.Format("The Robot position: x={0}, y={1}", point.X, point.Y);
        }
    }

    internal class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"x ={X}, y ={Y}";
        }
    }


    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            Robot rob = new Robot();

            MoveDel[] traceArr = new MoveDel[10]; // Массив делегатов, представляет перемещение робота на плоскости

            MoveDel trace = null; // Многоадресный делегат, представляет перемещение робота на плоскости
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(4))
                { // Заполняем массив, дублируя методы в многоадресный делегат
                    case 0:
                        traceArr[i] = new MoveDel(rob.Forward);
                        trace += traceArr[i];
                        break;
                    case 1:
                        traceArr[i] = new MoveDel(rob.Backward);
                        trace += traceArr[i];
                        break;
                    case 2:
                        traceArr[i] = new MoveDel(rob.Left);
                        trace += traceArr[i];
                        break;
                    case 3:
                        traceArr[i] = new MoveDel(rob.Right);
                        trace += traceArr[i];
                        break;
                }
            }

            Console.WriteLine("Массив делегатов:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method={0}, Target={1}", traceArr[i].Method, traceArr[i].Target);
                Console.WriteLine(traceArr[i]());
                Console.WriteLine();
            }

            rob.Reset();

            Console.WriteLine("=============");
            Console.WriteLine("Многоадресный делегат:");
            Console.WriteLine(trace()); // Обратите внимание, что выполняюся все делегаты, но возвращается значение только последнее

            Console.Read();
        }
    }
}
