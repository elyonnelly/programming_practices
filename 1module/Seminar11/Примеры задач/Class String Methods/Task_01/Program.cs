/* На вход подается строка произвольной длины, состоящая из различных символов, среди которых могут находиться и цифры. 
 * К сожалению, если цифры присутствуют, они могут располагаться в хаотичном порядке. 
 * Переставить все встретившиеся в строке цифры по возрастанию, оставив при этом остальные символы на своих местах, и вывести полученную строку.  */

using System;

namespace Example_Task_01
{
    class Program
    {
        /// <summary>
        /// Метод для создания отсортированного массива из чисел, встречающихся в строке.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int[] GenerateArrayFromNumbersInString(string str)
        {
            int[] numbers = new int[str.Length];
            int count = 0;
            foreach (var symb in str)
            {
                int num = 0;
                if (int.TryParse(symb.ToString(), out num))
                {
                    numbers[count] = num;
                    count++;
                }
            }

            // Во избежание возникновения лишних нулей, изменяем размер массива до количества чисел, встретившихся в строке.
            Array.Resize(ref numbers, count);
            Array.Sort(numbers);

            return numbers;
        }

        /// <summary>
        /// Метод, переставляющий цифры в строке по возрастанию.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="numbers"></param>
        public static void ChangeString(ref string str, int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int num = 0;
                if (int.TryParse(str[i].ToString(), out num))
                {
                    // Не забываем, что методы Insert и Remove не изменяют значение самой строки.
                    str = str.Insert(i + 1, numbers[count].ToString()).Remove(i, 1);
                    count++;
                }
            }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] numbers = GenerateArrayFromNumbersInString(str);
            ChangeString(ref str, numbers);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
