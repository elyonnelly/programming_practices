using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5);

            Addition(new int[] { 1, 2, 3, 4 });

            Addition();
            Console.ReadLine();
        }

        static void Addition(params int[] integers) // метод вычисляющий сумму с ключевым словом params
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
    }
}
