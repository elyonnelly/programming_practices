using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int c = rnd.Next(5, 15);
            int[,] matrix = new int[c,c];
            FillMatrix(matrix);
            PrintF(matrix);
            Console.WriteLine("Cумма чисел на диагонали:");
            Console.WriteLine(SumDiag(matrix));
            Console.WriteLine("Cумма чисел на побочной диагонали:");
            Console.WriteLine(SumSecondDiag(matrix));
            Console.WriteLine("Среднее арифметическое чисел матрицы");
            Console.WriteLine(SumAllNumbers(matrix));
            Console.Read();
        }

        /// <summary>
        /// среднее арифметическое чисел в матрице
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private static bool SumAllNumbers(int[,] matrix)
        {
            //посчитать среднее всех чисел в матрице
        }

        /// <summary>
        /// сумма чисел на пободной диаганали
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private static int SumSecondDiag(int[,] matrix)
        {
            //посчитать сумму на побочной диагонали матрицы
        }

        /// <summary>
        /// сумма чисел на основной диаганали
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private static int SumDiag(int[,] matrix)
        {
            //посчитать сумму чисел на основной диагонали
        }

        private static void PrintF(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = i + j;
                }
            }
        }
    }
}
