using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        delegate void Message();
        static int counter = 0;
        static void Main(string[] args)
        {
            Message[] delarray = new Message[6];
            //delarray[1]();// - так выпадет эксепшен
            //delarray[1].Invoke();// и так выпадает эксепшен
            delarray[1]?.Invoke();// не выпадает эксепшен проверка делегата на null
            for (int i = 0; i < delarray.Length-1; i++)//последний элемеент остается null
            {
                delarray[i] += delegate ()
                {
                    Console.Write(++counter + " " );
                };               
                delarray[i] += () =>
                {
                    delarray[i+1]?.Invoke();
                    //ToDo происходит захват переменных исправьте
                };
            }
            foreach (var item in delarray)
            {
                //item(); // - выпадет эксепшен
                //ToDo выведете последовательность от 1 до 6
                Console.WriteLine();
            }
            Console.Read();
            
        }
    }
}
