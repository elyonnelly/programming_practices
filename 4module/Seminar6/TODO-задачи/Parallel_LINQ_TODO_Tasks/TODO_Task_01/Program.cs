/* В csv-файле input.csv хранятся квадратные целочисленные матрицы, значения в строке разделены запятыми, каждая новая строка матрицы начинается 
 * с новой строки файла. В файле могут содержаться неполные и некорректные данные, например, данных может не хватать для квадратной матрицы. 
 * Пример содержимого файла:
 * 5,10,12
 * 4,4,35
 * 45,78,12
 * 0,0,0,4
 * 12,101,15,100
 * 7,12,99,38
 * В консольном приложении организовать диалог с пользователем при помощи экранного меню:
 * 1. В программе прочитать из input.csv матрицы в коллекцию.
 * 2. Вывести все матрицы из коллекции на экран (в отформатированном виде).
 * 3. Получить все матрицы, у которых на главной диагонали больше трёх нулей (использовать параллельный LINQ-запрос). 
 *    Полученные матрицы записать в xml-файл zeros.xml (асинхронная сериализация).
 * 4. Получить все матрицы, у которых максимальный элемент стоит выше главной диагонали (использовать LINQ-запрос). Полученные матрицы вывести на экран. */
 using ParallelClassLibrary;
using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TODO_Task_01
{

    class Program
    {
        // TODO: Написать методы для асинхронной сериализации и десериализации списка матриц, содержащих более трех нулей на главной диагонали.
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            /*   foreach (var item in matrix.GetEnumerator)
                   Console.WriteLine(item); */
            // TODO: осуществить параллельный LINQ-запрос по поиску матриц, содержащих более трех нулей на главной диагонали.
            // SerializeMatricesAsync(matrixWithMoreThan3ZerosOnDiagonal.ToList());
            // TODO: осуществить LINQ-запрос по поиску матриц, у которых максимальный элемент находится выше главной диагонали.
            /* foreach (var item in matrixWithMaximumElementBelowMainDiagonal)
                Console.WriteLine(item); */
            Console.ReadKey();
        }
    }
}
