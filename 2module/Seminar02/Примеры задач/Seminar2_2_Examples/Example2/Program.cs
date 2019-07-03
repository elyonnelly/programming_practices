using System;
using System.IO;

namespace Example2
{
    class Program
    {
        //напомним, что слэш -- это служебный символ, так что их необходимо
        //или экранировать, или использовать @, тогда все литеры будут распознаваться буквально 
        private const string path = @"../../../Library.txt";
        static void Main(string[] args)
        {
            string name;
            Library wizardLibrary = new Library();

            string booksInLibrary = string.Empty;

            Console.WriteLine("Введите названия желаемых книг. В конце списка укажите End.");
            while ((name = Console.ReadLine()) != "End")
            {
                booksInLibrary += wizardLibrary[name].GetInfo() + "\n";
            }

            try
            {
                File.WriteAllText(path, contents: booksInLibrary);
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

            Console.WriteLine("Запись успешно завершена!");
        }
    }
}
