/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: Пример передачи параметров без создания класса
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{

    class Program
    {
        public static void PrintNumber(object obj)
        {
            // Если в кортежи тяжело, то можно создать класс/структуру ThreadArgs,
            // передавать ThreadArgs и приводить obj к ThreadArgs
            var (index, count) = (Tuple<int, int>)obj;

            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine($"PrintNumber[{index}]: {i}");
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintNumber);
            Thread thread2 = new Thread(PrintNumber);

            thread1.Start(new Tuple<int, int>(1, 100));
            thread2.Start(new Tuple<int, int>(2, 100));
            thread1.Join();
            thread2.Join();
            Console.ReadKey();
        }
    }
}
