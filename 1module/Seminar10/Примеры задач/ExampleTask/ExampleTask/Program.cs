/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 02.07.2019
 * Задача: В текстовом файле, расположенном в папке с решением (.sln)
 *         расположен файл с результатами теста results.txt. Строчки
 *         записаны в формате "Фамилия Имя Балл", где балл за тест находится
 *         в пределах от 0 до 100.
 *         
 *         Например:

Василий Пупкин 50
Петелин Максим 100
Фомин Сергей 70
Ленивый Человек 10
Дерябин Федор 35

 *         В консоль необходимо вывести среднюю оценку студентов (рассчитывается как
 *         средний балл / 10), количество неудовлетворительных оценок (балл за тест
 *         меньше, чем 35) и всех студентов, которые могут пойти на пересдачу
 *         (оценка не выше, чем 5). В папке с решением создать/перезаписать файл
 *         sorted_resuls.txt с отсортированными оценками в порядке убывания.
 *
 * */

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ExampleTask
{
    class Program
    {
        // Пути к файлам, границы допустимых значений и прочие важные
        // константы лучше выносить в константы
        private const string INPUT_PATH = "../../../results.txt";
        private const string OUTPUT_PATH = "../../../sorted_results.txt";
        private const int MinMark = 0;
        private const int MaxMark = 100;
        private const int PassMark = 35;

        static void Main()
        {
            string[] s;
            try
            {
                s = File.ReadAllLines(INPUT_PATH, Encoding.GetEncoding(1251));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
                return;
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при считывании файла!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string[] students = new string[s.Length];
            int[] marks = new int[s.Length];

            for (int i = 0; i < s.Length; ++i)
            {
                try
                {
                    string[] input = s[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    // Можно просто s[i].Split(' '), но тогда два пробела подряд будут записывать пустую строку
                    if (input.Length != 3)
                        throw new ArgumentException();
                    students[i] = $"{input[0]} {input[1]}";
                    marks[i] = int.Parse(input[2]);
                    if (!(marks[i] >= MinMark && marks[i] <= MaxMark)) throw new OverflowException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"В строке {i} более трёх аргументов!");
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"В строке {i} ошибка форматирования в байте!");
                    return;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"В строке {i} оценка выходит за пределы!");
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                /*
                 * На практике из-за одной ошибки в строке программа должна пропустить
                 * эту строку, вывести сообщение об ошибке с номером строки и считывать
                 * дальше (для пропуска неправильных строк очень хорошо подходит List, но мы
                 * его пока что не знаем).
                 */
            }

            Console.WriteLine($"Средняя оценка за тест: {marks.Sum() / marks.Length / 10}");
            int failsCount = 0;
            foreach (var i in marks)
                if (i < PassMark) ++failsCount;
            // Можно записать красивее через LINQ (возможно, пригодится эрудитам): 
            // falisCount = marks.Where(q => q < PassMark).Count();
            Console.WriteLine($"Количество неудовлетворительных оценок: {failsCount}");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Список студентов, которые могут пойти на пересдачу: ");
            for (int i = 0; i < marks.Length; ++i)
            {
                if (marks[i] <= 50)
                    Console.WriteLine(students[i] + " " + marks[i]);
            }

            Array.Sort(marks, students); // Сортировка сразу двух массивов по ключу marks 
            Array.Reverse(marks);        // https://docs.microsoft.com/ru-ru/dotnet/api/system.array.sort#System_Array_Sort_System_Array_System_Array_   
            Array.Reverse(students);

            try
            {
                string[] retakes = new string[students.Length];
                for (int i = 0; i < marks.Length; ++i)
                    retakes[i] = students[i] + " " + marks[i];
                File.WriteAllLines(OUTPUT_PATH, retakes);
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при записи файла!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.ReadKey();
        }
    }
}
