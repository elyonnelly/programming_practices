/*
Написать метод, вычисляющий значение функции G=F(X,Y):
𝑋 + sin 𝑌 , 𝑋/Y > 0
𝑌 − cos 𝑋 , Y/(X*X) <= 1
0.5 ∙ 𝑋 ∙ 𝑌, в остальных случаях
Деление на 0 - выколотая точка!
*/

using System;

class Program
{
    public static double Input()
    // декомпозиция - вынесли считывание и парсивание входных данных в отдельный метод
    {
        bool p = false;
        double x = 0;
        do
        {
            Console.WriteLine("Введите число ");
            p = double.TryParse(Console.ReadLine(), out x);
            if (!p) // не нужно писать if (p == false) !!!!
                Console.WriteLine("Некорректный ввод!");
        } while (!p);
        return x;
    }
    public static double G()
    {
        double x = Input();
        double y = Input();
        if (y != 0 && x / y > 0)
            // if (y != 0 & x/y > 0 ) - выведет исключение при y == 0
            // т.к. & (в отличие от &&) всегда проверяет все условия, а && вернет False, если y == 0
            return x + Math.Sin(y);
        if (x != 0 && y / (x * x) <= 1)
            return y - Math.Cos(x);
        return 0.5 * x * y;
    }
    static void Main()
    {
        do
        {
            Console.WriteLine(G());
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
