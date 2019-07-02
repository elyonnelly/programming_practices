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
            int a0;
            do // ввод первого члена последовательности
            {
                Console.WriteLine("Введите a0");
            } while (!int.TryParse(Console.ReadLine(), out a0) || a0 < 1);

            int[] sequense = CreateArray(a0);

            PrintArray(sequense);
            Console.ReadLine();
        }

        static int[] CreateArray(int a0)
        {

            /*
             TODO: реальзовать метод генерирующий массив по следующему правилу:
             ai+1 = ai%2==0 ? ai/2 :(3*ai+1)
             генерация заканчивается, когда ai+1 становится равно 1
             */

            return null;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"[{i}] = {arr[i]}");
            }
        }
    }
}
