using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 1 };
            int n;
            do
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 3);

            Console.Write(mas[0] + " " + mas[1] + " ");

            for (int i = 0; i < n - 2; i++)
            {
                mas = Fibonacci(mas); // дополняем массив очередным числом Фибоначчи
                Console.Write(mas[mas.Length - 1] + " "); // дописываем последний элемент из массива
            }
            Console.Read();
        }

        static int[] Fibonacci(int[] arr)
        {
            int k = arr[arr.Length - 1] + arr[arr.Length - 2];
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = k;
            return arr;
        }
    }
}
