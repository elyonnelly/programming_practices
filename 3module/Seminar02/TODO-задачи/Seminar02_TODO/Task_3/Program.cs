﻿/*
Создадим библиотеку классов с именем Numerical.
В библиотеке опишем метод поиска вещественного корня функции
одного аргумента на заданном интервале.
Используем в качестве прототипа для решения нашей задачи алгоритм
под номером 4б «Нахождение корней непрерывной функции методом
деления интервала пополам» из книги «Библиотека алгоритмов 1б-50б
(Справочное пособие.)» М., «Сов. радио», 1975. -176 с.
Метод бисекции (https://ru.wikipedia.org/wiki/Метод_бисекции) 
*/
using System;
using Numerical;
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ToDO:
            Создадим консольное приложения для тестирования библиотеки классов Numerical. 
            Найдем корни математических функций, используя библиотечный метод bisec(). 
            В качестве аргументов, заменяющих параметрделегат, используем:
            • библиотечную функцию (метод из стандартной библиотеки),
            • статический метод, явно определенный в программе,
            • анонимный метод,
            • лямбда-выражение. 
            */
            /* (Со звёздочкой)
             Дополним библиотеку Numerical численным методом для поиска 
             минимума одномерной вещественной функции.
             Выберем алгоритм на основе метода золотого сечения, описанный в
             работе
             NUMERICAL METHODS for Mathematics, Science and Engineering, 2nd Ed,
             1992 Prentice Hall, Englewood Cliffs, New Jersey, 07632, U.S.A.
             Prentice Hall, Inc.; USA, Canada, Mexico ISBN 0-13-624990-6
             Prentice Hall, International Editions: ISBN 0-13-625047-5
             Существует реализация алгоритма на языке Си:
             NUMERICAL METHODS: C Programs, (c) John H. Mathews 1995.
             
             ToDO: 
             Для тестирования метода Optimum_1 создадим консольное
             приложение и запрограммируем поиск минимума следующих функций
             (используйте лямбда выражения):
             • cos(x) на интервале А=3, В=6;
             • x*(x*x-2)-5 на интервале А=0, В=1;
             • -Sin(x)-Sin(3*x)/3 на интервале A = 0; B = 1;
            */
        }
    }
}
