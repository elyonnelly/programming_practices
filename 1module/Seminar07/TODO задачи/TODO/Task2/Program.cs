using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length;
            do // ввод размера массива
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out length) || length < 1);

            int[] array = new int[length];
            for (int i = 0; i < length; i++) // генерация массива
            {
                array[i] = rnd.Next(100);
            }

            /*TODO
            Найти количество элементов, у которых ОБА соседа меньше.
            */

            Console.Read();
        }
    }
}
