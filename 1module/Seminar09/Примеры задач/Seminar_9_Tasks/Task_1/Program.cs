/*
Определить методы: 
1.	CreateString() - для создания строки заданной длины из символов, случайно выбираемых из указанного диапазона.
2.	MoveOff() - для удаления из строки всех символов другой строки.

В основной программе получите от пользователя целое число N, 
создайте строку из символов N десятичных цифр. Удалите из нее четные цифры.
*/
using System;

namespace Task_1
{
    class Program
    {
        // Создать строку заданных размеров из заданных символов:
        static string CreateString(int k, char minChar, char maxChar)
        {
            if (k <= 0)
                throw new Exception("Аргумент метода должен быть положительным!");
            // minChar, minChar - границы диапазона символов
            if (maxChar < minChar)
            {
                char c = minChar;
                minChar = maxChar;
                maxChar = c;
            }
            // пустая строка, останется пустой, если символов 0
            string line = String.Empty;
            for (int i = 0; i < k; i++)
                line += (char)gen.Next(minChar, maxChar + 1);
            return line;
        } // end of GetString()

        static Random gen = new Random();

        // comment - строка-сообщение для получения данных (Input)
        static int GetIntValue(string comment)
        {
            int intVal;
            do Console.WriteLine(comment);
            while (!int.TryParse(Console.ReadLine(), out intVal));
            return intVal;
        }

        // Удалить из строки s1 все символы другой строки s2:
        static string MoveOff(string s1, string s2)
        {
            string res = s1;
            int index;
            for (int i = 0; i < s2.Length; i++)
                while ((index = res.IndexOf(s2[i])) >= 0)
                    res = RemoveAt(res, index);               
            return res;
        } // end of MoveOff()

        // метод поиска первого вхождения символа в строке
        static int IndexOf(string res, char find, int index)
        {
            int temp = -1;
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == find)
                    temp = i;
            }
            return temp;
        }

        // метод удаления из строки символа с определённым индексом
        static string RemoveAt(string res, int index)
        {
            string temp = String.Empty;
            if (index < 0)
                return res;
            if (index < res.Length)
            {
                for (int i = 0; i < res.Length; i++)
                    if (i != index)
                        temp += res[i];
            }
            else return res;
            return temp;
        }

        static void Main(string[] args)
        {
            do
            {
                int N = GetIntValue("Введите N");
                string str = String.Empty;
                do
                {
                    try
                    {
                        str = CreateString(N, '0', '9');
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        N = GetIntValue("Введите N");
                    }
                } while (str == String.Empty);
                Console.WriteLine("Составленная строка \t" + str);
                string even = "02468"; // 0 - чётный
                Console.WriteLine("Редактированная строка \t" + MoveOff(str, even));
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
