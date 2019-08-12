using System;

namespace Struct_Example_01
{
    public struct Vector
    {
        /// <summary>
        /// Начало и конец вектора
        /// </summary>
        public Point A, B;

        /*
         * Обратите внимание, что здесь происходит копирование значений! 
         */
        public Vector(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }

        /// <summary>
        /// Перегруженная операция сложения двух векторов
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public static Vector operator + (Vector v, Vector u)
        {
            return new Vector(v.A, v.B + u);
        }

        /// <summary>
        /// Получить длину вектора
        /// </summary>
        /// <returns></returns>
        public double Length() => Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
    }
}