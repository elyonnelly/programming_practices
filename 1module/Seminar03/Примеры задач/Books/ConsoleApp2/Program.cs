using System;
/*
 Первоклассник читает книгу. В первый день он читает k страниц. В каждый последующий день
 он дочиывает до страницы, которая в k раз страниц больше предыдущей (например, в первый день до 2й, во второй день до 4 и.т.д.).
 Через сколько дней он прочитает всю книгу в которой N страниц?

 Входные данные: На вход подаётся два натуральных числа, отличных до 1
 Выходные  данные - номер дня, на котором школьник прочитает книгу целиком

    Пример входных данных:
    2
    8
    Пример выходных данных:
    3
 */
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint k = 2, N= 1;
            try { 
                k = uint.Parse(Console.ReadLine());
                N = uint.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            try 
            { 
                int answ = (int)Math.Ceiling(Math.Log(N,k));
                Console.WriteLine(answ);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
