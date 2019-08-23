namespace Struct_Example_01
{
    /// <summary>
    /// Структура, представляющая точку
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Координаты
        /// </summary>
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Перегруженная операция сложения двух точек
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Point operator +(Point A, Point B) => new Point(B.x + A.x, B.y + A.y);

        /// <summary>
        /// Перегруженная операция сложения точки и вектора
        /// </summary>
        /// <param name="A"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Point operator +(Point A, Vector v) => new Point(A.x += v.A.x - v.B.x, A.y += v.A.y - v.B.y);
    }
}