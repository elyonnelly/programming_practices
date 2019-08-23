namespace Struct_Example_01
{
    /// <summary>
    /// Интерфейс для работы с геометрическими фигурами
    /// </summary>
    public interface IGeometry
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        double GetSquare();

        /// <summary>
        /// Получить периметр фигуры
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        double GetPerimeter();

        /// <summary>
        /// Сдвинуть фигуру на вектор
        /// </summary>
        /// <param name="v"></param>
        void DragOnVector(Vector v);
    }
}