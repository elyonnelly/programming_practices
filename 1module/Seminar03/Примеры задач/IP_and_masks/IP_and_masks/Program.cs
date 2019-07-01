using System;

namespace IP_and_masks
{/*
    Написать программу, которая определяет номер компьютера в локальной сети, используя
    только побитовые сдвиги и побитовую операцию XOR.
    На вход программе подается 4 числа в диапазоне [0;255] и одно число в диапазоне [1;32]
    На выходе программы должно получиться одно целое число – номер компьютера в локальной сети.
 */
    class Program
    {
        static void Main(string[] args)
        {
            byte a,b,c,d; // Байьы в IP
            int x;// длина маски
            try //проверка на ввод
            {
                a = byte.Parse(Console.ReadLine());
                b = byte.Parse(Console.ReadLine());
                c = byte.Parse(Console.ReadLine());
                d = byte.Parse(Console.ReadLine());
                x = int.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            long IP = (((((a << 8) + b) << 8) + c) << 8) + d;// Составляем число IP
            int step = 32 - x;// Находим сдвиг
            long locNum = ((IP >> step) << step)^IP;// Сдвигаем и находим число компьютера в локальной сети
            Console.WriteLine(locNum);
            Console.ReadKey();
        }
    }
}
