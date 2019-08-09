using System;
using System.Collections.Generic;
using System.IO;

namespace ParallelClassLibrary
{
    /// <summary>
    /// Класс матриц
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Путь к файлу с матрицами
        /// </summary>
        private const string PATH = @"..\..\..\input.csv";
        /// <summary>
        /// Список квадратных матриц
        /// </summary>
        public List<SquaredMatrix> matrices = new List<SquaredMatrix>();
        /// <summary>
        /// Конструктор, в котором происходит прочтение файла и разбиение его на отдельные матрицы
        /// </summary>
        public Matrix() => ReadFile();

        /* TODO: Написать метод для проверки корректности прочитанной строки. Параметры метода: строка и количество некорректных 
         * элементов в строке (выходнйо параметр). Возвращаемое значение метода – массив целых чисел, элементов из строки. */

        /// <summary>
        /// Метод для проверки корректности прочитанной строки
        /// </summary>
        /// <param name="row">Проверяемая строка</param>
        /// <param name="incorrectElementsAmount">Количество некорректынх элементов в строке</param>
        /// <returns></returns>
        public List<int> CheckString(string row, ref int incorrectElementsAmount)
        {
            List<int> matrixRow = new List<int>();
            var elements = row.Trim(';').Split(';');
            foreach (var element in elements)
                try
                {
                    int n = int.Parse(element);
                    matrixRow.Add(n);
                }
                catch (Exception) { incorrectElementsAmount++; }
            return matrixRow;
        } 
        /// <summary>
        /// Метод для чтения файла
        /// </summary>
        public void ReadFile()
        {
            if (File.Exists(PATH))
            {
                try
                {
                    FileStream fs = new FileStream(PATH, FileMode.Open);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        int matrixSize = 0;
                        int incorrectElementsAmount = 0;
                        string row = string.Empty;
                        while (sr.Peek() != -1)
                        {
                            row = row == string.Empty ? sr.ReadLine() : row;
                            var elements = CheckString(row, ref incorrectElementsAmount);
                            // Если строка содержит хотя бы один некорректный элемент – пропускаем ее.
                            if (incorrectElementsAmount > 0)
                                row = sr.ReadLine();
                            else
                            {
                                SquaredMatrix matrix = new SquaredMatrix(elements);
                                {
                                    matrixSize = elements.Count;
                                    int correctRows = 0;
                                    for (int i = 0; i < matrixSize - 1; i++)
                                    {
                                        row = sr.ReadLine();
                                        var rowElements = CheckString(row, ref incorrectElementsAmount);
                                        if (rowElements.Count != elements.Count)
                                        {
                                            Console.WriteLine("Входной файл содержит ошибки форматирования. " +
                                                              "Входные данные были интерпретированы с учетом этих ошибок.\n");
                                            break;
                                        }
                                        if (incorrectElementsAmount > 0)
                                            break;
                                        else
                                        {
                                            foreach (var element in rowElements)
                                                matrix.matrix.Add(element);
                                            correctRows++;
                                        }
                                    }
                                    if (correctRows == matrixSize - 1)
                                    {
                                        matrices.Add(matrix);
                                        row = string.Empty;
                                    }
                                }
                            }
                        };
                    }
                    if (matrices.Count == 0) Console.WriteLine("Не удалось распознать ни одну матрицу.");
                }
                catch (UnauthorizedAccessException) { Console.WriteLine("Ошибка доступа к файлу input.csv."); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else Console.WriteLine("Файл input.csv не существует.");
        }

        // TODO: Написать итератор, возвращающий матрицы из списка (НЕ использовать yield return).
    }
}
