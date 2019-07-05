/*
Написать статический класс PolynomOperations для работы с полиномами n-ой степени.
Добавить методы для Сложения, Вычитания, Умножения, метод, преобразующий строку в полином,
и представления полиномов в виде строки. В основной программе ввести с клавиатуры число N и считать из консоли N
полиномов (поместить их в массив). Если N >= 2 вывести сумму, разность и произведение
первых двух введённых полиномов.
Пример:
1 2 3 </парсинг/> 1 * (x ^ 0) + 2 * (x ^ 1) + 3 * (x ^ 2)
*/
using System;

namespace Task_2
{
    static class PolynomOperations
    {
        // сумма
        internal static int[] Sum(int[] arr_1, int[] arr_2)
        {
            if (arr_1 == null || arr_2 == null)
                return null;
            int len = Math.Max(arr_1.Length, arr_2.Length);
            int[] temp_1 = new int[len]; int[] temp_2 = new int[len];
            Array.Copy(arr_1, temp_1, arr_1.Length);
            Array.Copy(arr_2, temp_2, arr_2.Length);
            int[] res = new int[len];
            for (int i = 0; i < len; i++)
                res[i] = temp_1[i] + temp_2[i];
            return res;
        }
        // вычитание (из первого второго)
        internal static int[] Minus(int[] arr_1, int[] arr_2)
        {
            if (arr_1 == null || arr_2 == null)
                return null;
            int len = Math.Max(arr_1.Length, arr_2.Length);
            int[] temp_1 = new int[len]; int[] temp_2 = new int[len];
            Array.Copy(arr_1, temp_1, arr_1.Length);
            Array.Copy(arr_2, temp_2, arr_2.Length);
            int[] res = new int[len];
            for (int i = 0; i < len; i++)
                res[i] = temp_1[i] - temp_2[i];
            return res;
        }
        // произведение
        internal static int[] Multiply(int[] arr_1, int[] arr_2)
        {
            if (arr_1 == null || arr_2 == null)
                return null;
            int len = arr_1.Length + arr_2.Length - 1;
            int[] res = new int[len];
            for (int i = 0; i < arr_1.Length; i++)
                for (int j = 0; j < arr_2.Length; j++)
                    res[i + j] += arr_1[i] * arr_2[j];
            return res;
        }
        // представление в виде строки
        internal static string Print(int[] arr)
        {
            if (arr == null)
                return string.Empty;
            string output = string.Empty;
            for (int i = 0; i < arr.Length; i++)
                if (i != arr.Length - 1)
                    output += $"({arr[i].ToString()}) * x ^ {i}" + "\t + \t";
                else
                    output += $"({arr[i].ToString()}) * x ^ {i}";
            return output;
        }
        // парсинг строки
        internal static int[] Parser(string str)
        {
            if (str.Length == 0)
                return null;
            string[] temp = str.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            int tmp = temp.Length;
            if (tmp <= 0)
                return null;
            int[] arr = new int[tmp];
            for (int i = 0; i < tmp; i++)
            {
                int next;
                if (!int.TryParse(temp[i], out next))
                    return null;
                arr[i] = next;
            }
            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int N;
                while (true)
                {
                    Console.WriteLine("Введите N");
                    if (int.TryParse(Console.ReadLine(), out N) && N > 0 && N < 11)
                        break;
                    Console.WriteLine("0 < N < 11");
                }

                int[][] polynoms = new int[N][];
                Console.WriteLine("Введите коэффиценты полинома (через пробел)");
                int count = 0;
                do
                {
                    if (count == N)
                        break;
                    string str = Console.ReadLine();
                    int[] arr = PolynomOperations.Parser(str);
                    if (arr == null)
                    {
                        Console.WriteLine("Неверная строка");
                        continue;
                    }
                    polynoms[count++] = arr;
                    Console.WriteLine($"Вы ввели:\t \n{PolynomOperations.Print(arr)}");

                } while (true);
                Console.WriteLine("Все введённые полиномы");
                foreach (int[] arr in polynoms)
                    Console.WriteLine($"{PolynomOperations.Print(arr)}");
                if (N >= 2)
                {
                    Console.WriteLine($"Сумма \t" + PolynomOperations.Print(
                        PolynomOperations.Sum(polynoms[0], polynoms[1])));
                    Console.WriteLine($"Разность \t" + PolynomOperations.Print(
                        PolynomOperations.Minus(polynoms[0], polynoms[1])));
                    Console.WriteLine($"Произведение \t" + PolynomOperations.Print(
                        PolynomOperations.Multiply(polynoms[0], polynoms[1])));
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
