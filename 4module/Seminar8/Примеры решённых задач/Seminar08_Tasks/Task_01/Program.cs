/*
Предположим, что список рассылки содержит имена, в которые 
иногда входит обращение (Mr., Mrs., Miss или Ms.) в дополнение 
к имени и фамилии. Если вы не хотите включать обращения 
при создании этикеток для конвертов из списка, с помощью 
регулярного выражения их можно удалить, как показано в примере.
Шаблон регулярного выражения (Mr\\.? |Mrs\\.? |Miss |Ms\\.?) 
сопоставляет любые вхождения строк "Mr", "Mr.", "Mrs", "Mrs.", 
"Miss", "Ms" и (или) "Ms.". После вызова метода Regex.Replace 
сопоставленная строка заменяется на String.Empty; другими словами, 
она удаляется из исходной строки.
*/
using System;
using System.Text.RegularExpressions;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
                         "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
            Console.ReadKey(true);
        }
    }
}