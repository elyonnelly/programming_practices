/*
Доработать задание 2 из примеров:
добавить проверку на соотвествие символов в строке формату,
проверить работоспособность программы
*/
using System;

class Program
{
    // TODO: реализуйте метод проверки static bool Validate(string str),
    // что строки состоят только из символов латинского алфавита
    // и пробелов

    // получение массива строк
    // каждый элемент проверен на соответствие формату
    public static string[] ValidatedSplit(string str, char ch)
    {
        string[] output = null;
        output = str.Split(new char[] { ch }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string s in output)
        {
            //if (!Validate(s)) return null;
        }
        return output;
    } // end of ValidatdSplit(string, char)
      // Обрезка строки по первому гласному
    public static string Shorten(string str)
    {
        // TODO: учесть заглавные гласные
        char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y' };
        int ind = str.IndexOfAny(alph);
        return str.Substring(0, ind + 1);
    } // end of Shorten(string)
      // Метод создания аббревиатуры для ПОДстроки (в ней много слов)
    public static string Abbrevation(string str)
    {
        string output = String.Empty;
        if (str != String.Empty)
        {
            string[] tmp = str.Split(' ');
            foreach (string s in tmp)
            {
                string shortenS = Shorten(s);
                FirstUpcase(ref shortenS);
                output += shortenS;
            }
        }
        return output;
    } // end of Abbrevation(string)
      // Метод преобразования первого символа к заглавному
    public static void FirstUpcase(ref string str)
    {
        // TODO: буквы после первой могут быть не приведены к нижнему регистру
        char[] chars = str.ToCharArray();
        str = str[0].ToString().ToUpper() + str.Substring(1);
    } // end of FirstUpcase(ref string)

    static void Main(string[] args)
    {
        do
        {
            String str = "Let it be; All you need is love; Dizzy Miss Lizzy";
            string[] strings = ValidatedSplit(str, ';');
            foreach (string strs in strings)
                Console.WriteLine(strs);
            string[][] group = new string[strings.Length][];
            for (int i = 0; i < group.Length; i++)
            {
                group[i] = ValidatedSplit(strings[i], ' ');
                for (int j = 0; j < group[i].Length; j++)
                {
                    group[i][j] = Shorten(group[i][j]);
                    group[i][j] = Abbrevation(group[i][j]);
                }
            }
            foreach (string[] ad in group)
            {
                foreach (string asf in ad)
                    Console.Write(asf);
                Console.Write("\n");
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

