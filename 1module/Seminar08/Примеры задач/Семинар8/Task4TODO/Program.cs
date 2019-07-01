using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4TODO
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк с массиве:");
            int n = Reading();
            int[][] array = new int[n][];
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
        /// метод создания и заполнения массива
        /// </summary>
        /// <param name="array"></param>
        private static void CreateAndFill(int[][] array)
        {
            //TODO
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
