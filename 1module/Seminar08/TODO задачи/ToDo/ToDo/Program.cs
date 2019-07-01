using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольник_Паскаля
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк с массиве:");
            int n = Reading();
            int[][] array = new int[n][];//инициализируем массив массивов
            CreateAndFill(array);
            PrintF(array);
            Console.Read();
        }

        /// <summary>
        /// метод ввывода элментов массива
        /// </summary>
        /// <param name="array"></param>
        private static void PrintF(int[][] array)
        {
            foreach (var item in array)//сначала
            {
                foreach (var e in item)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// метод для треугольника паскаля       
        /// </summary>
        /// <param name="array"></param>
        private static void CreateAndFill(int[][] array)
        {
            //C(1,0)=C(1,1)=C(0,0)=1, C(2,0)=C(2,2)=1, C(n,0)=C(n,n)=1
            //с использованием формулы C(n, k)=C(n-1, k-1) + C(n-1, k).
            //TODO:
        }

        /// <summary>
        /// метод для чтения количества строк в треугольнике
        /// </summary>
        /// <returns></returns>
        private static int Reading()
        {
            int k;
            try
            {
                k = int.Parse(Console.ReadLine());
                if (k <= 0) throw new ArgumentException("колчество строк должно быть больше нуля");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                k = Reading();
            }
            catch (Exception)
            {
                Console.WriteLine("Eror");
                k = Reading();
            }
            return k;
        }
    }
}
