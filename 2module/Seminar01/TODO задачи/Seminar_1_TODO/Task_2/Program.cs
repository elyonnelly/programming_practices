﻿/*
Написать статический класс SuperMarket в который люди, ищущие работу, подают свое резюме. 
Реализовать статический метод Interview, проверяющий подходит ли человек для работы или нет. 
Кандидат подходит, если он старше 17 лет. Если человек подходит, то его имя и возраст должны 
быть занесены в статический массив строк. Пример элемента <Витя 19>. Количество кандидатов вводится с клавиатуры.
 */
using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            int N;
            int age;
            string name;
            Console.WriteLine("Введите количество людей");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                Console.WriteLine("Количество людей должно быть положительныйм и целым");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите возраст:");
                while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                    Console.WriteLine("Возраст людей должен быть положительныйм и целым");
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
                // TODO: отформатируйте имя (первая буква заглавная, остальные строчные), длина не больше 20 символов
                // TODO: проведите отбор кандидатов
            }
            // TODO: выведите всех кандидатов, кто подошёл по критериям
        }
    }
    static class SuperMarket
    {
        // TODO: реализовать статический класс
    }
}