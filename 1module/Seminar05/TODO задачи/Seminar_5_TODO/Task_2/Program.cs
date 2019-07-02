/*
Написать программу для работы со сложными процентами. 
Использовать метод static double Total(double k, double r, uint n)
Параметры: начальный капитал, годовая процентная ставка, число лет (вклада). 
Возвращаемое значение – итоговая сумма в конце срока вклада. 
В основной программе ввести начальный капитал (больший нуля), процентную ставку и число лет. 
Вывести таблицу значений итоговых сумм в конце каждого года вплоть до заданного числа лет. 
*/
using System;

class Program
{
    public static double Input(string str)
    {
        bool p = false;
        double x;
        Console.WriteLine(str);
        do
        {
            p = double.TryParse(Console.ReadLine(), out x);
            if (!p) Console.WriteLine("Ошибка");
        }
        while (!p || x <= 0);
        return x;
    }

    // TODO: написать метод для подсчёта сложных процентов
    // TODO: реализовать вывод полученных результатов в виде таблицы 

    static void Main()
    {
        do
        {
            double k = 0, r = 0, n = 0;
            k = Input("Введите начальный капитал");
            r = Input("Введите процентную ставку");
            do
            {
                n = Input("Введите срок вклада");
                if (n != (int)n)
                    Console.WriteLine("Ошибка. Введите натуральное число");
            } while (n != (int)n);
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}