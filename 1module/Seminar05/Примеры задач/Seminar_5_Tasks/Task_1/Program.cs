﻿/*
Вычислите приближённое значение бесконечной суммы
1/(1*2)+1/(2*3)+1/(3*4)+⋯
Протестируйте программу для разных типов данных с плавающей точкой (float и double).
В чём различие результатов?
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double Sum = 0;
        for (int n = 2; n < int.MaxValue; n++)
            // если мы напишем n <= int.MaxValue, 
            // то цикл никогда не прервётся (возникнет бесконечный цикл).
            // Операция n++ присвоит n значение int.MinValue (возникнет переполнение) 
            // целые цисла в C# - кольцо, как и в алгебре множество целых чисел (см. Кольца (алгебра))
        {
            Sum += 1 / ((double)n * (n - 1));
            // приведение типов в знаменателе, чтобы не возникло переполнения int
            // (int * int возвращает int)
        }
        /* 
         * любой for можно переписать в виде цикла с while
         * в таком случае главное следить, чтобы цикл был не бесконечным
         * (нужно чтобы условие выхода из цикла было достижимым, то есть
         * нужно в примере ниже не забыть написать k++)
        int k = 2;
        Sum = 0;
        while (k < int.MaxValue)
        {
            Sum += 1 / ((double)k * (k - 1));
            k++; 
        }
        do {} while отличается тем, что он как минимум один раз выполняет тело цикла
        P.S. do {} while, например, очень уместен, когда нужно создавать экземпляр класса (см. второй модуль) 
        со случайными свойствами (полями) из диапазона так, чтобы они попадали в какие-то ограничения
        */
        Console.WriteLine($"Sum = {Sum:f3}");
        Console.ReadKey(true);
    }
}

