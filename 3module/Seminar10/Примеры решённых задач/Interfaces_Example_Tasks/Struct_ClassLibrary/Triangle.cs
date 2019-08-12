using System;

namespace Struct_Example_01
{
    public struct Triangle : IGeometry
    {
        private Point A, B, C;

        /*
         * Обратите внимание, что здесь происходит копирование значений! 
         */
        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double GetSquare() => Math.Abs((A.x - C.x) * (B.y - C.y) - (B.x - C.x) * (A.y - C.y)) * 0.5;

        public double GetPerimeter() =>
            new Vector(A, B).Length() + new Vector(B, C).Length() +
            new Vector(A, C).Length();

        public void DragOnVector(Vector v)
        {
            A += v;
            B += v;
            C += v;
        }
    }
}