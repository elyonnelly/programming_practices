using System;

namespace TODO_task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt, secondInt;
            // TODO: осуществить ввод переменных firstInt и secondInt, используя метод TryParse().
            Console.WriteLine($"Введенные числа:\n{firstInt}\t{secondInt}");
            // TODO: добавить проверку корректности деления.
            Console.WriteLine(firstInt / secondInt);
            // TODO: вывести результат деления с точностью трех знаков после запятой.
            Console.WriteLine((double)firstInt / secondInt);
            // TODO: заменить умножение на 4 операцией побитового сдвига.
            Console.WriteLine(firstInt * 4);
            // TODO: добавить повтор решения.
        }
    }
}
