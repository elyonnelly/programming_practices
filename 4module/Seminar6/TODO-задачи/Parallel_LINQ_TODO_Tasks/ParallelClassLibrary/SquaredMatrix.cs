using System;
using System.Collections.Generic;
using System.Linq;

namespace ParallelClassLibrary
{
    /// <summary>
    /// Класс квадартных матриц
    /// </summary>
    public class SquaredMatrix
    {
        /// <summary>
        /// Матрица в виде списка чисел
        /// </summary>
        public List<int> matrix;
        /// <summary>
        /// Конструктор для создания экземпляра квадратной матрицы
        /// </summary>
        /// <param name="elements">Элементы матрицы</param>
        public SquaredMatrix(List<int> elements) => matrix = new List<int>(elements);
        /// <summary>
        /// Конструктор без параметров для возможности осуществления XML-сериализации
        /// </summary>
        public SquaredMatrix() { }
        /// <summary>
        /// Метод для формирования матрицы
        /// </summary>
        /// <returns></returns>
        public int[,] MatrixForm()
        {
            int n = (int)Math.Sqrt(matrix.Count());
            int[,] matrixArr = new int[n, n];
            for (int i = 0; i < matrix.Count(); i += n)
                for (int j = i; j < i + n; j++)
                    matrixArr[i / n, j % n] = matrix[j];
            return matrixArr;
        }
        /// <summary>
        /// Метод для подсчета нулей на главной диагонали матрицы
        /// </summary>
        /// <returns></returns>
        public int CountZeros()
        {
            int amount = 0;
            int n = (int)Math.Sqrt(matrix.Count());
            int[,] matrixArr = MatrixForm();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrixArr[i, j] == 0 && i == j)
                        amount++;
            return amount;
        }
        /// <summary>
        /// Метод для проверки находится ли максимальный элемент над главной диагональю
        /// </summary>
        /// <returns></returns>
        public bool IsMaximumElementBelowDiagonal()
        {
            int maxElement = matrix.Max();
            int[,] matrixArr = MatrixForm();
            int n = (int)Math.Sqrt(matrix.Count());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrixArr[i, j] == maxElement && j > i)
                        return true;
            return false;
        }
        // TODO: переопределить ToString() для отформатированного вывода матрицы.
    }
}
