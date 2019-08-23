using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyInt : IEnumerable, IEnumerator
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int i = -1;
        //реализуйте интерфейсы и попытайтесь понят что происходит
        //поставте точки остановки метод(-ы) отдного из интерфейсов не выполняются откуда следует простая инстина
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInt myint = new MyInt();
            foreach (var item in myint)
            {
                Console.WriteLine(item) ;
            }
            Console.Read();
        }
    }
}
