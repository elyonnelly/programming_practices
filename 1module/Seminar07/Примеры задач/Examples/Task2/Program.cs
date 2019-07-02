using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            int[] mas = new int[n];
            for (int i = 0; i < n; i++) // генерируем массив случайных чисел
                mas[i] = rnd.Next(-100, 100);

            Array.Sort(mas); // сортировка массива по возрастанию
            Array.Reverse(mas); // меняем порядок следования элементов

            int count = 0;
            for (int i = 0; i < mas.Length; i++) // считаем кол-во элементов меньше 0
            {
                if (mas[i] < 0) count++;
                Console.Write(mas[i] + " "); // выводим изначальный массив на экран
            }
            Console.WriteLine();
            Array.Resize(ref mas, n - count); // изменяем размер массива, удаляя отрицательные элементы в конце


            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.Read();
        }
    }
}
