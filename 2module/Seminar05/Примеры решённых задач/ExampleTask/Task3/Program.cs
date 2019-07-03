/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 03.07.2019
 * Задача: Без использования using в папке с решением
 *         создайте файл prime.txt и запишите в него
 *         все простые числа от 1 до 100
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i < x; ++i)
                if (x % i == 0) return false;
            return true;
        }

        static void Main(string[] args)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("../../../prime.txt", FileMode.Create);
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при создании файла!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            for (int i = 0; i < 100; ++i)
            {
                byte[] info = Encoding.Default.GetBytes(i.ToString() + ' ');
                if (IsPrime(i)) fs.Write(info, 0, info.Length);
            }
            fs.Close();
        }
    }
}
