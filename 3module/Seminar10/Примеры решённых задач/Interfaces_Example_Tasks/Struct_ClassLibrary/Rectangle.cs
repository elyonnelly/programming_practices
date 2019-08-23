namespace Struct_Example_01
{
    public struct Rectangle : IGeometry
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;

        /*
         * Обратите внимание, что здесь происходит копирование значений! 
         */
        public Rectangle(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        public double GetSquare() => new Vector(A, B).Length() * new Vector(B, C).Length();

        public double GetPerimeter() => 2 * (new Vector(A, B).Length() + new Vector(B, C).Length());

        public void DragOnVector(Vector v)
        {
            A += v;
            B += v;
            C += v;
            D += v;
        }
    }
}