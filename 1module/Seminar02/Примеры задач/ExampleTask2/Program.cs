/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 01.07.2019
 * Задача: Каждому школьнику из курса органической химии известна формула 
 *         молекулы этилового спирта – C2H5(OH). Откуда видно, что молекула 
 *         спирта состоит из двух атомов углерода (C), шести атомов водорода (H) 
 *         и одного атома кислорода (O).
 *         
 *         По заданному количеству атомов каждого из описанных выше элементов 
 *         требуется определить максимально возможное количество молекул спирта, 
 *         которые могут образоваться в процессе их соединения.
 *         
 *         Необходимо считать нужные числа с клавиатуры и вывести ответ. 
 *         
 *         http://acmp.ru/index.asp?main=task&id_task=757
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            long c, h, o; // лучше избегать название переменной o и l, легко спутать: o0O0oo01II1lI1 (вижак норм рисует, но не стоит)
            try
            {
                Console.WriteLine("Введите количество молекул углерода: ");
                c = long.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество молекул водорода: ");
                h = long.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество молекул кислорода: ");
                o = long.Parse(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Заданное число слишком большое!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            long ans = Math.Min(Math.Min(c / 2, h / 6), o / 1); // Минимум из трёх чисел
            Console.WriteLine($"Мы можем получить {ans} молекул спирта!)");

            Console.ReadKey();
        }
    }
}
