/* 
TODO: Модифицировать код задания 1 из примеров так, чтобы создавалось N строк
(N вводится с клавиатуры). Строки записываются в файл, потом считываются оттуда
и выполняются все проверки на правильность написанной программы.
*/
using System;

class Program
{
    static Random gen = new Random();

    // Создать строку заданных размеров из заданных символов:
    static string CreateString(int k, char minChar, char maxChar)
    {
        if (k <= 0)
            return "";
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

    // метод смешивания строк
    static string MixUp(string first, string second)
    {
        string output = string.Empty;
        int len = first.Length + second.Length;
        string concat = first + second;
        do
        {
            int temp = gen.Next(0, len);
            int possibility = gen.Next(0, 11);
            if (possibility < 3)                             // вероятность 0,3
                output += concat[temp].ToString().ToUpper();
            else output += concat[temp];
            concat = concat.Remove(temp, 1);
            len--;
        } while (len > 0);  // цикл выбирает случайный символ из строки, меняет регист с шансом,
                            // удаляет его из начальной строки и добавляет к выходной строке
        return output;
    }
    // проверяет содержимое строк на равенство
    static bool IsEqual(string str_1, string str_2)
    {
        return string.Compare(SortString(str_1), SortString(str_2)) == 0;
    }
    // сортирует содержимое строки 
    static string SortString(string str)
    {
        char[] chr = str.ToCharArray();
        Array.Sort(chr); // сортируем массив символов
        string opt = string.Empty;
        for (int i = 0; i < chr.Length; i++)
        {
            opt += chr[i];
        }
        return opt;
    }
    // разделяет строку на три содержащие определённые символы (цифры, русский и латинские буквы) 
    static string[] Separate(string input, out int mistake)
    {
        input = input.ToLower();   // приводим строку к нижнему регистру
        string[] output = new string[3];
        mistake = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= '0' && input[i] <= '9')
            {
                output[0] += input[i]; continue;
            }
            if (input[i] >= 'a' && input[i] <= 'z')
            {
                output[1] += input[i]; continue;
            }
            if (input[i] >= 'а' && input[i] <= 'я')
            {
                output[2] += input[i]; continue;
            }
            mistake++;
        }
        return output; // по-хорошему нужно выкидывать исключение если mistake > 0
                       // ловить его и выводить соответствующее сообщение
    }
    // вывод массива строк
    static void ArrayOutput(string[] opt)
    {
        Console.WriteLine("Извлекли строки");
        foreach (string str in opt)
            Console.Write($"{str} \t | \t");
        Console.Write("\n");
    }
    // проверка исходных и конечных строк
    static void EqualityCheck(string[] strs_1, string[] strs_2)
    {
        if (strs_1.Length == strs_2.Length)
        {
            for (int i = 0; i < strs_1.Length; i++)
            {
                Console.Write(IsEqual(strs_1[i], strs_2[i]) + "\t | \t");
            }
            Console.Write("\n");
        }
        else Console.WriteLine("Ошибка");
    }

    static void Main()
    {
        do
        {
            int len_1 = gen.Next(1, 11), len_2 = gen.Next(1, 11), len_3 = gen.Next(1, 11);
            string[] strs = new string[3];
            strs[0] = CreateString(len_1, '0', '9'); strs[1] = CreateString(len_2, 'a', 'z');
            strs[2] = CreateString(len_3, 'а', 'я');
            string output = MixUp(MixUp(strs[0], strs[1]), strs[2]);
            Console.WriteLine($"Сформированные строки: \n{strs[0]} \t | \t {strs[1]}" +
                $"\t | \t {strs[2]}");
            Console.WriteLine("Смешали строки \t" + output);
            int mistake;
            string[] opt = Separate(output, out mistake);
            ArrayOutput(opt);
            Console.WriteLine("контрольная строка (проверяем, " +
                "что полученные строки совпадают с изначальными)");
            EqualityCheck(strs, opt);
            Console.WriteLine($"Ошибки \t {mistake}");
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}