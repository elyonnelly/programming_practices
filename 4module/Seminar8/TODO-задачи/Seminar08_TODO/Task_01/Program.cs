// Проверить в каких элементах массива есть совпадения со строкой "World"
using System;
using System.Text.RegularExpressions;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = {
            "Wuck World", "Hello world", "My wonderful world"
            };
            Regex regex = new Regex("World");
            Console.WriteLine("Регистрозависимый поиск: ");
            // TODO
            Console.ReadKey(true);
        }
    }
}
