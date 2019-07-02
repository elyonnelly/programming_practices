/*
Вычислить площадь под графиком функции X^2 на отрезке [0;A]
при помощи метода трапеций, вещественная точка A и шаг
интегрирования delta задаются с клавиатуры.
Чтобы организовать проверку корректности введённых данных,
определите ограничения на значения А и delta.
Как вычисляется значение, добавляемое к интегральной сумме на
каждом шаге.
Определите условие выхода из цикла формирования
интегральной суммы.
*/
using System;

class Program
{
    public static double Input(string str)
    {
        double x = 0d;
        bool p = false;
        do
        {
            Console.WriteLine(str);
            p = double.TryParse(Console.ReadLine(), out x);
            if (!p) Console.WriteLine("Некорректное число, попробуйте снова!");
        }
        while (!p);
        return x;
    }
    public static double Func(double x)
    {
        return (x * x);
    }

    // TODO: напишите метод непосредственно для подсчета площади под графиком

    static void Main()
    {
        do
        {
            double A, delta;
            // TODO: считайте значения A и delta, выполните необходимые проверки
            // (delta <= A), в противном случае заново запросите значение delta
            // A вводится первой!
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}