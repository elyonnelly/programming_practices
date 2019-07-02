using System;
using System.Linq;
using System.IO;

/*Создать программным путем файл, в котором записывать натуральные числа подряд.
 * При создании файла, записать в него число "1"
 * С каждым новым запуском программы, в файле должно появляться новое число, которое на единицу больше предыдущего записанного
 */

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Numbers.txt"; // Путь для файла
            do // Повтор решения
            {
                if (!File.Exists(path)) // Проверка на существование файла
                {
                    File.WriteAllText(path, "1"); // Создаем файл
                    Console.WriteLine("Файл создан");
                    Console.WriteLine("Записано число 1");
                    Console.WriteLine("Для выхода нажмите Esc");
                    continue;
                }
                string[] text = File.ReadAllText(path).Split();
                try
                {
                    int last = int.Parse(text.Last<string>()) + 1; // Парсим число
                    File.AppendAllText(path, " " + last.ToString());
                    Console.WriteLine($"Записано число {last}");
                }
                catch (FormatException) // Проверка на входные данные
                {
                    Console.WriteLine("Не тот формат входных данных");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Слишком большое число");
                }

                Console.WriteLine("Для выхода нажмите Esc");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
