using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Написать метод swap, который меняет два объекта друг с другом.
     */ 

namespace Generic_and_Collections
{     
    class Program
    {
        static void Swap<T>(ref T first, ref T second) //Обобщенный метод swap, который может выполнять обмен с любыми типами объектов
        {
            T tmp = first;
            first = second;
            second = tmp;
        }
        static void Main(string[] args)
        {
            //В данном примере мы можем увидеть, что теперь метод Swap может взаимодействовать с объектами разных типов
            string one = "one";
            string two = "two";
            Console.WriteLine($"{one}, {two}");
            Swap<string>(ref one, ref two);
            Console.WriteLine($"{one}, {two}");
            int num1 = 1;
            int num2 = 2;
            Console.WriteLine($"{num1}, {num2}");
            Swap<int>(ref num1, ref num2);
            Console.WriteLine($"{num1}, {num2}");

            Console.ReadLine();

        }
    }
}
