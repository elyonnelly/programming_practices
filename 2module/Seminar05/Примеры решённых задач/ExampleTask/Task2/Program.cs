/*
 * В папке с решением 2 файла: odd.txt и even.txt. В одном цикле от 1 до 100
 * необходимо записать чётные числа в файл even.txt, а нечётные в odd.txt.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream oddStream = new FileStream("../../../odd.txt", FileMode.Create))
                using (FileStream evenStream = new FileStream("../../../even.txt", FileMode.Create))
                {
                    UTF8Encoding encoding = new UTF8Encoding(true);
                    for (int i = 0; i < 100; ++i)
                    {
                        byte[] info = encoding.GetBytes(i.ToString() + " ");
                        if (i % 2 == 0) oddStream.Write(info, 0, info.Length);
                        else evenStream.Write(info, 0, info.Length);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при работе с файлом!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
