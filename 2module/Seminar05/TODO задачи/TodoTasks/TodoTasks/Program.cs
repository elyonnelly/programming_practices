/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: Сгенерировать файл с людьми, считать его, сделать файл
 *         results.txt, записать туда результаты
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTasks
{

    class Program
    {
        private const int NumberOfPeople = 100;
        private const int MinMark = 0;
        private const int MaxMark = 100;

        static string[] GenerateData(int n)
        {
            string[] result = new string[n];
            return result;
        }

        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("../../../people.txt", FileMode.Create))
            {
                for (int i = 0; i < NumberOfPeople; ++i)
                {
                    string human = Human.GetHuman();
                    // TODO: сделать записать человека в файл, на каждой строчке по одной записи
                }
            }

            string[] humans = new string[NumberOfPeople];
            // TODO: считать всех людей из файла в массив humans

            int[] mark = new int[NumberOfPeople];
            Array.ForEach(mark, x => x = Rand.Next(MinMark, MaxMark + 1));

            using (FileStream fs = new FileStream("../../../results.txt", FileMode.Create))
            {
                //TODO: записать в файл results.txt результаты в виде "Имя_человека Результат"
            }

        }
    }
}
