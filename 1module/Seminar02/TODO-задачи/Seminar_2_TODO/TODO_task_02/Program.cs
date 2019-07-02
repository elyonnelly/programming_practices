using System;

namespace TODO_task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            do
            {
                str1 = Console.ReadLine();
                // TODO: осуществить ввод остальных строк.
                // TODO: Вывести строки в столбик "лесенкой", используя табуляцию.
                Console.WriteLine("Для выхода нажмите Escape, для продолжения работы – любую клавишу");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
