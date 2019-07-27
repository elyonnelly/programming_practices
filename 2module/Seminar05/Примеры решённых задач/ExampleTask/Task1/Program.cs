/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 03.07.2019
 * Задача: В папке с решением создать файл text.txt, записать в него строчку
 *         "Использую FileStream для создания текстовых файлов и радуюсь жизни B)\n" (\n для 
 *         перехода на новую строчку). Не забывайте про то, что строка содержит
 *         кириллицу. Затем дозапишите в файл строчку
 *         "London is the capital of Great Britain" и закройте поток.
 *         
 *         Затем в новом потоке считайте из файла эту строчку и выведите её 
 *         в консоль.  
 * 
 */
using System;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        private const string PATH = "../../../file.txt";

        static void Main(string[] args)
        {
            try
            {
                using (FileStream fs = new FileStream(PATH, FileMode.Create))
                {
                    string s = "Использую FileStream для создания текстовых файлов и радуюсь жизни B)\n";
                    byte[] info = new UTF8Encoding(true).GetBytes(s);
                    fs.Write(info, 0, info.Length);
                    s = "London is the capital of Great Britain";
                    info = new UTF8Encoding(true).GetBytes(s);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при работе с файлом!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                using (FileStream fs = File.OpenRead(PATH))
                {
                    byte[] info = new byte[fs.Length];
                    fs.Read(info, 0, (int)fs.Length);

                    string result = new UTF8Encoding().GetString(info);
                    Console.WriteLine(result);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при чтении из файла!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
