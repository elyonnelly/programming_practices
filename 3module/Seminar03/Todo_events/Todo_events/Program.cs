using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Реализовать в статическом классе MatrixOperations методы для работы с
 двумерными массивами:
 double[,] MatrixMultiplication(double[,] ,double[,]) - умножение матриц,
 double printMax(double[,]) - поиск максимального элемента в матрице
 double printSum(double[,])  - сумма элементов в матрице
 Создать событийный делегат void EventDel(double[,]) 
 Событие multEvent

    В основной программе подписать на событие multEvent методы printMax и printSum
Создвать матрицы размерами 3x5 и 5x3 и заполнить их случайными числами
выполнить умножение матриц (сначала 3x5 * 5x3, потом 5x3 * 3x5) и с помощью события вывести максимальный
элемент и сумму элементов в матрице.
     */
namespace Todo_events
{
    static class MatrixOperations
    {
        public static double[,] MatrixMultiplication(double[,] A , double[,] B)
        {
            //Todo: Реализовать функцию, используя знания из алгебры
            //Вызвать из него событие

        }

        public static void printMax(double[,] Matrix)// Todo Исправить ошибки в функции
        {
            double max = 0;
            for (int i = 0; i < Matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j < Matrix.GetUpperBound(1); j++)
                {
                    if(Matrix[i,j] > max) max = Matrix[i,j];
                }
            }
            Console.WriteLine(max);
        }

        public static void printSum(double[,] Matrix)
        {
            double sum = 0;
            for (int i = 0; i < Matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j < Matrix.GetUpperBound(1); j++)
                {
                    sum += Matrix[i,j];
                }
            }
            Console.WriteLine(sum);
        }
    }

    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Todo
            //Создайте матрицы размерами N x M, M x N, M и N считывайте с клавиатуры.
            double[,] firstMatrix = new double[N, M];
            double[,] secondMatrix = new double[M, N];
            //Считайте с клавиатуры a и b и заполните матрицу резмером N x M случайными числами из диапазона [a,b)
            //Считайте с клавиатуры c и d и заполните матрицу резмером M x N случайными числами из диапазона [c,d)
            //Todo сделайте необходимые действия

            MatrixOperations.MatrixMultiplication(firstMatrix,secondMatrix);

            
        }
    }
}
