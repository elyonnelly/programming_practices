using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    struct Point
    { 
        double x ,y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //TODO реализовать метод Point  AddVector(Vector), который возвращает точку, смещенную на вектор.
        //TODO реализовать метод void Add
    }

    // TODO реализовать структуру Vector, содержащий поля begin, end - типа Point (начало вектора в точке begin)
    //Создать два конструктора, один принимает две точки - другой 4 вещественных числа

    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Point[] points = new Point[10];
            for (int i = 0; i < 10; i++)
            {
                //TODO инициализировать все точки
            }

            foreach (var item in points)
            {
                //TODO Создать случайные векторы, диапазон каждой координаты [-10,10)
                //TODO Изменить координаты каждой точки
                //TODO записать всё в файл Points.txt, используя адаптеры потоков
            }
        }
    }
}
