/*
Написать метод Function() с двумя логическими параметрами,
вычисляющий и возвращающий значение логического выражения
!(p & q) & !(p | !q)
(конкретное выражение в условии должно быть явно задано).
В основной программе построить таблицу истинности логического
выражения, заданного методом.

ToDO: добавить метод Parser, который будет вместо True или False
выводить 1 или 0 соответсвенно.
*/
using System;

namespace Task_if
{
    class Program
    {
        static bool Function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        static void Main()
        {
            do
            {
                bool p = true, q, res;
                Console.WriteLine("Таблица истинности !(p & q) & !(p | !q)");
                Console.WriteLine("p\tq\tF");
                do
                {
                    q = true;
                    do
                    {
                        res = Function(p, q); // Вызов Function()
                        Console.WriteLine("{0}\t{1}\t{2}", p, q, res);
                        q = !q;
                    } while (!q);
                    p = !p;
                } while (!p);

                // TODO: добавить метод Parser, который будет вместо True или False
                // выводить 1 или 0 соответсвенно

                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
