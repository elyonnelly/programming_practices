/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: показать работу адаптеров потоков
 */

using HumanLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct TestResult
    {
        public TestResult(string studentName, string studentSurname, int firstMark, int secondMark)
        {
            StudentName = studentName;
            StudentSurname = studentSurname;
            FirstMark = firstMark;
            SecondMark = secondMark;
        }

        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int FirstMark { get; set; }
        public int SecondMark { get; set; }

        public override string ToString() => $"{StudentName} {StudentSurname}: {FirstMark} {SecondMark}";
    }

    class Program
    {
        private const int NumberOfStudents = 20;
        private const int MinMark = 0;
        private const int MaxMark = 10;

        static void Main(string[] args)
        {
            try
            {
                using (FileStream fs = new FileStream("../../../students.txt", FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < NumberOfStudents; ++i)
                    {
                        sw.WriteLine(Human.GetHuman() + ' ' + Rand.Next(MinMark, MaxMark + 1) +
                            ' ' + Rand.Next(MinMark, MaxMark + 1));
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Возникло исключение - проверьте, что путь к файлу не равен null");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Возникло исключение ArgumentOutOfRangeException" +
                    $"\nCледующая информация возможно будет полезна: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Возникло исключение - проверьте, что путь к файлу имеет верный формат");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Возникло исключение - проверьте, что путь к файлу не слишком длинный");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Возникло исключение - проверьте, что путь к каталогу существует");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Возникло исключение - проверьте, что заданный каталог или файл существует");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Возникло исключение при записи данных в файл");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Возникло исключение, так как разрешения недостаточно для открытия указанного файла");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Возникло исключение - Потому что поток не поддерживает некоторый функционал");
            }
            catch (System.Security.SecurityException ex)
            {
                Console.WriteLine("Возникло исключение - обнаружена ошибка безопасности");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло неопознанное исключение типа {ex.GetType()}" +
                        $"\nCледующая информация возможно будет полезна: {ex.Message}");
            }

            List<TestResult> testResults = new List<TestResult>();

            try
            {

                using (StreamReader sr = new StreamReader("../../../students.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] input = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string name = input[0];
                        string surname = input[1];
                        int firstMark = int.Parse(input[2]);
                        int secondMark = int.Parse(input[3]);
                        testResults.Add(new TestResult(name, surname, firstMark, secondMark));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (!testResults.Any())
            {
                Console.WriteLine("Нет студентов");
                return;
            }

            var bestResult = testResults.OrderByDescending(x => x.FirstMark + x.SecondMark).First();
            double averageMark = testResults.Average(x => (x.FirstMark + x.SecondMark) / (double)2);

            Console.WriteLine($"Лучший студент: {bestResult}");
            Console.WriteLine($"Средняя оценка: {averageMark}");

            Console.ReadKey();
        }
    }
}
