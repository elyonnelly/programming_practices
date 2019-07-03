/*
Написать метод для разделения строк по символу 
(возвращаемое значение массив строк) и метод для
вывода массива строк
*/
using System;

namespace Task_2
{
    class Program
    {
        // P.S. ставите три слэша над методом и появиться форма xml-комментариев
        /// <summary>
        /// метод разделения строк по символу
        /// </summary>
        /// <param name="input"> строка для разделения </param>
        /// <param name="find"> символ по которому разделяем </param>
        /// <returns> массив строк </returns>
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

        // Так нужно изменять увеличивать размер массива
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

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите строку");
                string input = Console.ReadLine(); char chr;
                while (true)
                {
                    Console.WriteLine("Введите символ");
                    if (char.TryParse(Console.ReadLine(), out chr))
                        break;
                    Console.WriteLine("Некорректный ввод");
                }
                Output(Split(input, chr));
                Console.WriteLine("------------------------");
                Console.WriteLine("Проверка \t");
                Output(input.Split(chr));
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
