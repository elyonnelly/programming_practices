/*
Написать программу для работы с приборами измерения времени, 
для этого реализовать классы Stopwatch (секундомер) и Digital_Clock (цифровые часы).
Stopwatch хранит время в секундах, Digital_Clock в часах, минутах и секундах. 
Переопределить метод ToString () в обоих классах (при этом учтите, что 
цифровые часы должны выводить время в формате ЧЧ:ММ:СС, проще всего использовать 
класс DateTime для такого вывода). В классе Stopwatch реализовать: 
неявное приведение к Stopwatch из int, явное приведение к int из Stopwatch, 
явное приведение к Stopwatch из Digital_Clock, неявное приведение к Digital_Clock из Stopwatch. 
Проверить написанный код, вводя с клавиатуры число – количество секунд. 
Неявно привести его к Stopwatch, вывести с помощью ToString (), 
затем неявно привести Stopwatch к Digital_Clock и 
снова вывести результат, используя ToString ().
*/
using System;

namespace Task_1
{
    class Program
    {
        static Random random = new Random();

        static void Main()
        {
            do
            {
                int N = 0;
                Input(ref N);
                Stopwatch stopwatch_1 = N; // неявное приведение
                Console.WriteLine($"Время в секундах \t {stopwatch_1.ToString()}");
                Digital_Clock digital_Clock = stopwatch_1; // неявное приведение
                Console.WriteLine($"Время в ЧЧ:ММ:СС \t {digital_Clock.ToString()}");
                Console.WriteLine($"\t (Проверка)"); 
                // явное приведение
                Console.WriteLine($"Время в секундах \t {((Stopwatch)digital_Clock).ToString()}");
                Console.WriteLine("---------------------------------");
                Stopwatch stopwatch_2 = random.Next(5000, 10000);
                Console.WriteLine($"{stopwatch_1} + {stopwatch_2} = " +
                    $"{stopwatch_1 + stopwatch_2} = {(Digital_Clock)(stopwatch_1 + stopwatch_2)}");
                // заметьте что мы определили (в классе Stopwatch) только неявное приведение
                // Stopwatch к Digital_Clock, однако мы можем ЯВНО приводить Stopwatch к Digital_Clock.
                // При этом будет вызываться неявное приведение (см. последний пример выше).
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        // считывание числа с консоли
        static void Input(ref int N)
        {
            do
            {
                Console.WriteLine("Введите время в секундах");
                int.TryParse(Console.ReadLine(), out N);
                if (N > 0)
                    break;
                Console.WriteLine("Некорректный ввод");
            } while (true);
        }

    }
}
