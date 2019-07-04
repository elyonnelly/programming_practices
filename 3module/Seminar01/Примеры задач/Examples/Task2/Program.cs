using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate int[] IntToIntArrayDel(int value); // Объявляем делегаты - типы
        delegate void PrintArrayDel(int[] value);

        static int[] IntToIntArrayHandler(int value)
        {
            List<int> res = new List<int>();

            while (value != 0)
            {
                res.Add(value % 10);
                value /= 10;
            }

            res.Reverse();
            return res.ToArray();
        }

        static void PrintArrayHandler(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            IntToIntArrayDel del1 = new IntToIntArrayDel(IntToIntArrayHandler); // Инстанциируем (создаем объекты) делагатов
            PrintArrayDel del2 = new PrintArrayDel(PrintArrayHandler);



            int value;
            do
            {
                Console.WriteLine("Введите натуральное число");
            } while (!int.TryParse(Console.ReadLine(), out value) || value < 1);

            del2(del1(value));

            Console.ReadLine();
        }
    }
}