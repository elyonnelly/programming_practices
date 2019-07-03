/*
Написать метод для вычисления по формуле Ньютона с точностью до
«машинного нуля» приближенного значения арифметического квадратного
корня.
Параметры: подкоренное значение, полученное значение корня и
значение точности, достигнутой при его вычислении. Если подкоренное
значение отрицательно - метод должен возвращать в точку вызова
значение false, иначе - true.
В основной программе вводить вещественные числа и выводить их корни.
При отрицательных числах выводить сообщения.
*/
using System;

class Program
{
    static void Main()
    {
        do
        {
            double x, result = 0, eps = 0;
            Console.Title = "Формула Ньютона";
            do
            {
                Console.Clear(); // очистка консольного окна
                Console.Write("x = ");
            } while (!double.TryParse(Console.ReadLine(), out x));

            if (!Newton(x, out result, out eps))
            {
                Console.WriteLine("Error!"); return;
            }
            Console.WriteLine("root({0}) = {1,8:f4}, eps = {2,8:e4}", x, result, eps);
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }

    static bool Newton(double x, out double sq, out double eps)
    {
        double r1, r2 = x;
        sq = eps = 0.0;
        if (x <= 0.0)
        {
            Console.WriteLine("Ошибка в данных!");
            return false;
        }
        do
        {
            r1 = r2;
            eps = (x / r1 - r1) / 2;
            r2 = r1 + eps;
        } while (r1 != r2); // пока приближения «различимы» для ЭВМ
        sq = r2;
        return true;
    }

}