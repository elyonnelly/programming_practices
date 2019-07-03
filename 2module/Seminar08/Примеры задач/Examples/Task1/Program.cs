using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] arr = new Triangle[3];
            arr[0] = new Triangle(0, 0, 1, 0, 0, 1);
            arr[1] = new Triangle(-1, -1, 5, 5, 6, 0);
            arr[2] = new Triangle(-1, 0, 0, 1, 1, 0);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }

    class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public double Distance(Point point) // вычисляет расстояние между точками
        {
            return Math.Sqrt((this.X - point.X) * (this.X - point.X) + (this.Y - point.Y) * (this.Y - point.Y));
        }

        public override string ToString()
        {
            return $"(X = {X}, Y = {Y})";
        }
    }

    class Triangle
    {
        public Triangle(double ax, double ay, double bx, double by, double cx, double cy) // Конструктор, осуществяющий
        { // отношение композиции между классами Point и Triangle
            A = new Point(ax, ay);
            B = new Point(bx, by);
            C = new Point(cx, cy);
        }

        public Point A { get; private set; } // Вершины треугольника
        public Point B { get; private set; }
        public Point C { get; private set; }

        public double ABSide { get => A.Distance(B); } // Длины сторон треугольника
        public double BCSide { get => B.Distance(C); }
        public double CASide { get => C.Distance(A); }

        public double Area() // Вычисление площади
        {
            double p = (ABSide + BCSide + CASide) / 2;
            return Math.Sqrt(p * (p - ABSide) * (p - BCSide) * (p - CASide));
        }

        public override string ToString()
        {
            return $"Triangle:   Point A: {A.ToString()}, Point B: {B.ToString()}, Point B: {B.ToString()}, Area = {this.Area()}";
        }
    }
}
