using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Task1
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] matrix = new int[rnd.Next(4, 17), rnd.Next(4, 17)];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(-5, 6);

            PrintMatrix(matrix);

            Console.WriteLine("\n====================\n");

            int count = 0;
            foreach (int item in matrix) // Заменить, где возможно на var. Добавить осмысленные комментарии к происходящему в программе.
                if (item < 0) count += 1;


            if (count >= matrix.Length / 2)
            {
                ReplaceItems(matrix);
                PrintMatrix(matrix);
            }

            Console.Read();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString() + " \t");
                Console.WriteLine();
            }
        }

        static void ReplaceItems(int[,] matrix) // Возращаемое значение void так как массив -  
        {// ссылочный тип данных и в метод передается не объект, а ссылка на него в куче
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0) matrix[i, j] *= -1;
                }
        }
    }
}
