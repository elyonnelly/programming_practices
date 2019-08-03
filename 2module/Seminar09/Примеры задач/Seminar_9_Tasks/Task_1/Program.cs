/*
Создать перечисление Months (месяцы) и использовать его для определения
количества дней в месяце.
*/
 using System;

namespace Task_1
{
    class Program
    {
        // Объявить тип Month
        enum Month
        {
            January = 31, February = 28, March = 31, April = 30, May, June = 30,
            July, August = 31, September = 30, October, November = 30, December
        }
        static void Main()
        {
            // Определение количества дней в месяце
            Month M;
            int days;

            M = Month.December; //
            days = (int)M; // days = 31
            Console.WriteLine($"{M} = {days}");

            M = Month.October;
            days = (int)M; // days = 31
            Console.WriteLine($"{M} = {days}");

            M = Month.February;
            days = (int)M; // days = 28
            Console.WriteLine($"{M} = {days}");

            Console.ReadKey(true);
        }
    }
}
