using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODO_Files
{
    /*
        Написать программу, которая считывет в текстовом файле численные значения по строкам и в конце добавляет
        на новой строке их округленное вверх среднее арифметическое. Вывести на экран полученное среднее арифметическое.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../MyFile.txt";
            // TODO: Проверка на существования файла
            string[] lines = File.ReadAllLines(path);
            int SUM = 0;
            foreach (var item in lines) // TODO проверить корректность файла
            {
                //TODO Посчитать сумму элементов
            }
            //TODO Дописать в конец файла среднее арифметическое
            Console.WriteLine(SUM/lines.Length);//TODO Округлить вверх значение(Используйте Math)
            
        }
    }
}
