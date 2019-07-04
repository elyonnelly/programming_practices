/* Разработать библиотеку классов, в которой разместить:
I. Абстрактный Класс SymbolChain
Члены класса:
1. Chain – защищённое поле класса: массив или список для представления цепочки символов;
2. GetChainLength – абстрактное свойство: количество символов в цепочке chain;
3. AddToChain(char newSimb) – абстрактный метод для добавления элемента в цепочку.

II. Класс LimitedSymbolChain, унаследованный от SymbolChain и реализующий все его абстрактные члены. 
Представляет цепочки символов, для которых диапазон кодов символов ограничен.
Члены класса:
1. поле StartCode хранит код левой границы кодов допустимых символов;
2. поле EndCode хранит код правой границы кодов допустимых символов;
3. Реализация метода AddToChain(char newSymb), если код newSymb не входит в диапазон [StartCode, EndCode], метод выбрасывает исключение ArgumentOutOfRangeException;
4. Переопределение метода ToString(). Возвращает строку, состояющую из символов chain.

В основной программе, используя классы библиотеки, создать три объекта типа LimitedSymbolChain:
1. цепочка, состоящая из латинских строчных букв;
2. цепочка, состоящая из цифр;
3. цепочка, состоящая из латинских прописных букв.

На вход программе подаётся двоичный файл, в котором сохранены целые неотрицательные числа, представленные одним байтом. 
Файл сформировать самостоятельно, при первом выполнении программы записать в него 1000 случайных значений типа byte из диапазона [0;127]. 
Для датчика случайных чисел установить стартовое значение 1024.
Последовательно, получая из файла значения типа byte, определять являются ли они кодами латинских строчных, прописных символов или цифр. 
Если код символа распознан, добавлять его в цепочку соответствующего объекта, нераспознанные символы подсчитывать.
На экран вывести строковые представления цепочек символов, количество элементов в каждой цепочке и количество нераспознанных символов.
 */

using System;
using System.IO;
using SampleTaskLib;

namespace Sample_Task_01
{
    class Program
    {
        public static Random random = new Random(1024);
        static void Main(string[] args)
        {
            LimitedSymbolChain numberChain = new LimitedSymbolChain('0', '9');
            LimitedSymbolChain latinSmallChain = new LimitedSymbolChain('a', 'z');
            LimitedSymbolChain latinHighChain = new LimitedSymbolChain('A', 'Z');

            string path = @"..\..\..\symbols.txt";

            /*FileStream fs = new FileStream(path, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = 0; i < 1000; i++)
                    sw.WriteLine(random.Next(0, 128));
            };*/

            if (File.Exists(path))
            {
                long incorrectChars = 0;
                long fileLength = 0;
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (sr.Peek() != -1)
                        {
                            fileLength++;
                            try
                            {
                                char x = (char)byte.Parse(sr.ReadLine());
                                try
                                {
                                    latinSmallChain.AddToChain(x);
                                }
                                catch (ArgumentException)
                                {
                                    try
                                    {
                                        numberChain.AddToChain(x);
                                    }
                                    catch (ArgumentException)
                                    {
                                        try
                                        {
                                            latinHighChain.AddToChain(x);
                                        }
                                        catch (ArgumentException) { incorrectChars++; }
                                    }
                                }
                            }
                            catch (ArgumentException) { incorrectChars++; }
                            catch (FormatException) { incorrectChars++; }
                            catch (OverflowException) { incorrectChars++; }
                        }
                    };
                    if (incorrectChars > 0) Console.WriteLine($"{incorrectChars}/{fileLength} символов не было распознано.\n");
                }
                catch (IOException) { Console.WriteLine("Ошибка чтения файла."); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else Console.WriteLine("Файл symbols.txt не найден.");

            Console.WriteLine($"Цепочка цифр: {numberChain} \nДлина: {numberChain.GetChainLength}\n");
            Console.WriteLine($"Цепочка строчных латинских символов: {latinSmallChain} \nДлина: {latinSmallChain.GetChainLength}\n");
            Console.WriteLine($"Цепочка прописных латинских символов: {latinHighChain} \nДлина: {latinHighChain.GetChainLength}");

            Console.ReadKey();
        }
    }
}
