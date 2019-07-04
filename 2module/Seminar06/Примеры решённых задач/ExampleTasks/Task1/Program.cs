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
    class Program
    {
        private const int NumberOfStudents = 20;

        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("../../../students.txt", FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = 0; i < NumberOfStudents; ++i)
                {
                    sw.WriteLine(Human.GetHuman());
                }
            }
        }
    }
}
