/*
Написать метод, переводящий оценку из десятибалльной шкалы в
четырёхбалльную шкалу:
 1, 2, 3 балла – неудовлетворительно;
 4,5 – удовлетворительно;
 6,7 – хорошо;
 8, 9, 10 – отлично.
Используйте переключатель.
В основной программе в получайте от пользователя оценки (целые числа из
диапазона 1..10) и выводите значение в четырёхбалльной шкале.
 */
using System;

class Program
{
    static void Main()
    {
        do
        {
            int x = 0;
            do { Console.WriteLine("Введите оценку"); }
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > 10);
            int k = 3;
            // используем switch
            switch (x)
            {
                case 1:
                case 2:
                case 3:  // case k: - ошибка компиляции т.к. k - переменная
                    Console.WriteLine("неудовлетворительно");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("удовлетворительно");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("хорошо");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("отлично");
                    break;
            }

            // используем if
            if (x >= 1 && x <= 3) // или if (x > 0 && x < 4), т.к. x - целое число
                Console.WriteLine("неудовлетворительно");
            if (x >= 4 && x <= 5)
                Console.WriteLine("удовлетворительно");
            if (x >= 6 && x <= 7)
                Console.WriteLine("хорошо");
            if (x >= 8 && x <= 10)
                Console.WriteLine("отлично");
            /* if в отличие от switch пройдётся по всем сравнениям
             * если же применять else, то будет выглядеть намного менее лаконично,
             * чем со switch => понижается читаемость кода
             */

            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}