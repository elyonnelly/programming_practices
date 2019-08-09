/*
Декларируйте делегат-тип Cast для представления методов с одним параметром типа double и 
возвращаемым значением типа int. 
•	 Создайте два экземпляра типа Cast. Первый (1) свяжите с анонимным методом, возвращающим 
ближайшее чётное целое к переданному в параметре вещественному числу. Второй (2) – с анонимным 
методом, вычисляющим порядок переданного в параметре положительного числа.
•	 Протестируйте вызовы при помощи делегатов (1) на одном тестовом вещественном значении; 
(2) на нескольких тестовых вещественных значениях 
•	 Используя операцию += свяжите оба анонимных метода из задачи 1 с одним многоадресным делегатом. 
Вызовите методы через него.
•	 Замените анонимные методы лямбда-выражениями.
*/
using System;

namespace Task_1
{
    class Program
    {
        delegate int Cast(double par);
        delegate void CastMultiple(double par);
        static void Main()
        {
            do
            {
                // Cast cast_1 = delegate (double par) { if ((int)par % 2 == 0) return (int)par; else return (int)par + 1; };
                // Cast cast_2 = delegate (double par) { int p = 0; while (par > 10) { par = par / 10; p++; }  return p; };
                Cast cast_1 = param => { if ((int)param % 2 == 0) return (int)param; else return (int)param + 1; };
                Cast cast_2 = param => { int p = 0; while (param > 10) { param = param / 10; p++; } return p; };
                Console.WriteLine("cast_1(2311.1) \t" + cast_1(2311.1));
                Console.WriteLine("cast_2(23718.1) \t" + cast_2(23718.1));
                Cast cast_3 = cast_1 + cast_2;
                Console.WriteLine("--------------------");
                Console.WriteLine(cast_3(23718.1)); // обратите внимение, выведится только результат последнего метода
                // создадим экзмепляр делегата CastMultiple
                CastMultiple castMul_1 = param =>
                {
                    if ((int)param % 2 == 0) Console.Write("\t" + (int)param);
                    else Console.Write("\t" + ((int)param + 1));
                };
                CastMultiple castMul_2 = param =>
                {
                    int p = 0; while (param > 10) { param = param / 10; p++; }
                    Console.Write("\t" + p);
                };
                CastMultiple castMultiple = castMul_1 + castMul_2;
                Console.WriteLine("--------------------");
                Console.Write("castMul_1(2311.1) and castMul_2(2311.1) \t"); castMultiple(2311.1);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
