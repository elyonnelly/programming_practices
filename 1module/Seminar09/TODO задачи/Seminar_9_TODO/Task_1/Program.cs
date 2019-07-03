/*
Напишите метод IndexesOf() для работы со строками:
параметры - входная строка, символ
возвращаемое значение массив целых чисел - индексы символов в строке
Используйте (если необходимо) методы с примеров: Split, ArrayResize, Output, IndexOf, RemoveAt
*/
using System;

namespace Seminar_9_TODO
{
    class Program
    {
        // метод разделения строки по символу
        static string[] Split(string input, char find)
        {
            string[] strs = new string[0];
            int count = 0;
            string temp = String.Empty;
            input += find;
            int len = input.Length;
            for (int i = 0; i < len; i++)
            {
                if (input[i] == find)
                {
                    if (strs.Length <= count)
                        ArrayResize(ref strs);
                    strs[count++] = temp;
                    temp = String.Empty;
                }
                else
                    temp += input[i];
            }
            return strs;
        }
        // изменяет размерность массива
        static void ArrayResize(ref string[] strs)
        {
            int len = 0;
            if (strs.Length == 0)
                len = 1;
            else len = strs.Length * 2; // в 2 раза, а не на 1
            string[] temp = new string[len];
            for (int i = 0; i < strs.Length; i++)
                temp[i] = strs[i];
            strs = temp;
        }
        // вывод массива строк
        static void Output(string[] strs)
        {
            string output = String.Empty;
            foreach (var str in strs)
                if (str != null)
                    output += str + "\t | \t";
            Console.WriteLine(output);
        }
        // метод поиска индекса первого вхождения символа в строке
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

        // TODO: напишите метод IndexesOf()

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите строку");
                string input = Console.ReadLine();
                // TODO: проверить написанный метод для строки input
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
