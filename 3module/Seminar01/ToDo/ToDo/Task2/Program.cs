using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate double MyDel(double x, double y);
        static void Main(string[] args)
        {
            MyDel sum = delegate (double x, double y)
            {
                return x + y;
            };
            MyDel mult = (double x, double y) =>
            {
                return x * y;
            };
            Console.WriteLine(sum(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))+mult(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));//ToDo введите с клавиатуры два числа и выведите сумму их суммы и умножения с помощью делегатов
            MyDel del = sum + mult;//ToDo сделайте так чтобы при выводе del выводилась сумма двух чисел
            Console.WriteLine(del(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));//ToDo напишаите правильно del
            Console.Read();
        }
    }
}
