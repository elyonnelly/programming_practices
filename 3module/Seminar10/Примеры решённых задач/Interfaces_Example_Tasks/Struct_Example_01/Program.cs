using System;
using System.Collections.Generic;

/*
 * Структуры, реализующие интерфейсы.
 * Определим простейшие структуры -- геометрические фигуры
 * И интерфейс, позволяющий легко работать с экземплярами структур.
 */

namespace Struct_Example_01
{
    internal class Program
    {
        /*
         * В основной программе создадим список фигур, используя экземпляры типа интерфейса
         * для упрощения работы с фигурами
         */
        private static void Main(string[] args)
        {
            List<IGeometry> figures = new List<IGeometry>();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Point A = new Point(rnd.Next(10), rnd.Next(10));
                Point B = new Point(rnd.Next(10), rnd.Next(10));
                Point C = new Point(rnd.Next(10), rnd.Next(10));
                figures.Add(new Triangle(A, B, C));

                Vector v = new Vector(B, A) + new Vector(B, C);
                Point D = B + v;
                figures.Add(new Rectangle(A, B, C, D));
            }

            foreach (IGeometry figure in figures)
            {
                Console.WriteLine($"Square = {figure.GetSquare()}");
                Console.WriteLine($"Perimeter = {figure.GetPerimeter()}");
            }

        }
    }
}