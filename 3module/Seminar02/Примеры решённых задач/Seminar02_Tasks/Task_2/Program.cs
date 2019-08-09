/*
Напишите класс FileUsing для работы с объёмными файлами. В классе должно быть:
закрытое поле path – путь к файлу;
два конструктора – один пустой (задаёт путь к файлу по умолчанию @"..\..\..\Default.txt"), 
другой с пользовательским путём к файлу;
методы:
WriteFile (bool @override, int strMin, int strMax) –
создает файл (по указанному пути path, записывает в него случайное количество строчек 
в диапазоне от strMin до strMax). Параметр @override определяет будет ли перезаписываться файл при 
очередном запуске или нет. Каждая строка составляется случайно из букв 
латинского алфавита (строчных и заглавных) с помощью метода StringGenerator() и имеет длину от 60 до 100 символов.
Создайте делегат GetInfo(string message) и закрытое поле getInfo типа делегата GetInfo 
(так как оно закрытое, то нужен метод SetMethod() для присвоения полю getInfo метода из основной программы).
В основной программе создать новый файл (без перезаписи), присвоить метод для вывода 
в консоль соотношения уже обработанных строк от общего количества строк в файле 
в процентах от 0 до 100 (выводить только целые значения и первую строку, при которой это целое значение достигается *). 
Посчитать время считывания файла и вывести его на экран.

* – например, было записано 200 строк: 
Ada
afafhjFAaltu
fasHSF
jkgpoiUIO
и т.д.
Вывод будет:
Ada        0
afafhjFAaltu        1
jkgpoiUIO        2
*/
using System;
using MyLib;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                FileUsing fileUsing = new FileUsing();
                try
                {
                    fileUsing.WriteFile(true, 200, 200);
                    fileUsing.SetMethod(Output); // присвоили метод
                    fileUsing.ReadFile();
                }
                catch (Exception ex) // ловим исключения
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        // метод для передачи
        public static void Output(string str)
        {
            Console.WriteLine(str);
        }
    }
}
