/*
Для того, чтобы создать метод расширения, вначале надо 
создать статический класс, который и будет содержать 
этот метод. В данном случае это класс StringExtension. 
Затем объявляем статический метод. Суть нашего метода 
расширения - подсчет количества определенных символов в строке.

Собственно метод расширения - это обычный статический 
метод, который в качестве первого параметра всегда принимает 
такую конструкцию: this имя_типа название_параметра, то есть 
в нашем случае this string str. Так как наш метод будет 
относиться к типу string, то мы и используем данный тип.

Затем у всех строк мы можем вызвать данный метод: 
int i = s.WordCount(c);. Причем нам уже не надо 
указывать первый параметр. Значения для остальных 
параметров передаются в обычном порядке.
*/
using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Привет интернет";
            char c = 'т';
            Console.WriteLine("Счётчик букв");
            Console.WriteLine(s + "\t" + s.WordCount());
            Console.WriteLine("Счётчик слов");
            Console.WriteLine(s + "\t(символ\tт)\t" + s.WordCount(c));
            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        // подсчёт количества определённого символа в строке
        public static int WordCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
        // подсчёт количества слов в строке
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
