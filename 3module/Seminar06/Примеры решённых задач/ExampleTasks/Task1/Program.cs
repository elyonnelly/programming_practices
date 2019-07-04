/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: показать работу потоков
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.threading.thread?view=netframework-4.8
 */

using System;
using System.Threading;

namespace ExampleTasks
{
    public class Program
    {
        public static void ThreadProc()
        {
            Console.WriteLine("ThreadProc: Я запустился!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: Делаю работу, {0}/10", i);
                Thread.Sleep(0);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Main thread: Я запустился!");
            Thread[] t = new Thread[4];
            for (int i = 0; i < 4; ++i)
                t[i] = new Thread(new ThreadStart(ThreadProc));
            for (int i = 0; i < 4; ++i)
                t[i].Start();

            //Thread.Sleep(0);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Main thread: Делаю работу, {i}/4");
                Thread.Sleep(0);
            }

            Console.WriteLine("Main thread: Вызываю Join() для ожидания завершения остальных потоков.");
            for (int i = 0; i < 4; ++i)
                t[i].Join();
            Console.WriteLine("Main thread: Работа потоков завершена!");
            Console.ReadKey();
        }
    }
}