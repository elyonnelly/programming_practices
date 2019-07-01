/*
 Написать метод, вычисляющий логическое значение функции G = F(X,Y). 
 Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, 
 и результат равен false, если точка с координатами (X,Y) не попадает в фигуру G. 
 Фигура G - сектор круга радиусом R = 2 в диапазоне углов -90 <= φ <= 45.
 */
using System;

class Program
{
    // декомпозиция - см. примеры задач
    public static double Input()
    {
        bool p = false;
        double x;
        do
        {
            Console.WriteLine("Введите число ");
            p = double.TryParse(Console.ReadLine(), out x);
            if (!p) Console.WriteLine("Некорректный ввод!");
        } while (!p);
        return x;
    }
    public static bool G(double x, double y)
    {
        return ((x * x + y * y) <= 4) && ((x >= 0 && y <= 0) || (x >= 0 && y >= 0 && y <= x));
        /* не нужно писать if ...
            return false;
        return true;*/
    }
    static void Main()
    {
        do
        {
            double x = Input();
            double y = Input();
            Console.WriteLine(G(x, y));
            // TODO: напишите условие попадания точки в ромб – центр точка(2, -1), 
            // диагональ, параллельная оси OX, имеет длину 12, 
            // диагональ, параллельная оси OY, имеет длину 7.
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}