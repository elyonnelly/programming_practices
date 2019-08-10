using System;

namespace Task_2
{
    class Program
    {
        static Random rand = new Random();
        static void Main()
        {
            do
            {
                Power power1 = new Power(rand.Next(0, 150), rand.Next(0, 150), rand.Next(0, 150));
                Power power2 = new Power(rand.Next(0, 150), rand.Next(0, 150), rand.Next(0, 150));
                Power power3 = power1 + power2;
                Console.WriteLine(power3);
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
