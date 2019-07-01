/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 01.07.2019
 * Задача: Счтитать 3 целых числа с клавиатуры, вывести среднее значение этих чисел
 *         с точностью до трёх знаков после запятой. 
 *         
 */

using System;

namespace ExampleTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Введите первое число: ");
                string input = Console.ReadLine();
                a = int.Parse(input);
                Console.WriteLine("Введите второе число: ");
                b = int.Parse(Console.ReadLine()); // так короче и проще
                Console.WriteLine("Введите третье число: ");
                c = int.Parse(Console.ReadLine());
            }
            catch (FormatException) // Ошибка при форматировании числа (присутствуют не числа, число вещественное)
            {
                Console.WriteLine("Ошибка при считывании числа (это не число)!");
                return;
            }
            catch (OverflowException ex) // Число вылезает за пределы границ инта
            {
                Console.WriteLine(ex.Message); // Когда нет времени писать юзер-френдли ошибку, можно просто выводить ex.Message
                return;
            }
            catch (Exception ex) // Если вдруг вылезет какой-то левый эксепшн, то ловим его общим эксепшном
            {
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                double average = checked((a + b + c) / (double)3);
                Console.WriteLine($"Среднее значение: {average:F3}"); // Выводим через интерполяцию строк
                                                                      // https://docs.microsoft.com/ru-ru/dotnet/csharp/tutorials/string-interpolation а вообще такие длинные строки делать нельзя, как по мне длиннее 100 символов их стоит юзать только в крайних случаях
            }
            catch (OverflowException ex) // ex не используется, но лучше так не оставлять
            {
                Console.WriteLine("Ошибка во время вычисления среднего числа, сумма выходит за пределы инта!");
                //Можете подумать, как избежать переполнения в формуле без приведения к лонгу
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey(); // Оставляем, чтобы программа не закрывалась при дебаге (F5) после завершения
                               // (Если запускать без отладки (Ctrl+F5), то программа закрываться не будет
        }
    }
}
