/* 
TODO: Перепишите код программы из примера 1 так, чтобы можно было работать с
матрицами с вещественными числами. Добавьте в статический класс
метод ReadFile():
параметр - массив строк
возвращаемое значение - массив матриц
*/
using System;
using System.IO;

static class MatrixOperations
{
    // метод умножения
    public static int[,] Mulitply(int[,] arr_1, int[,] arr_2)
    {
        if (arr_1 == null || arr_2 == null)
            return null;
        int[,] arr = new int[arr_1.GetLength(0), arr_2.GetLength(1)];
        // 0 измерение - строки, 1 измерение - столбцы
        if (arr_1.GetLength(1) == arr_2.GetLength(0))
        {
            for (int i = 0; i < arr_1.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr_1.GetLength(1); k++)
                        arr[i, j] += arr_1[i, k] * arr_2[k, j];
                }
            }
            return arr;
        }
        else
            return null;
    }

    internal static int[,] Parser(string[] strs)   // internal можно, т.к. Program и 
                                                   // находятся в одной сборке
    {
        // в Parser (методе парсере) мы возвращаем null, если из массива строк 
        // нельзя сформировать матрицу (значит, в других методах 
        // уже нет необоходимости делать проверки, кроме проверки на null)
        if (strs.Length <= 0)            // есть хотя бы одна строка
            return null;
        int constant = strs[0].Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Length; // удаляем вхождения пустых строк
        int[,] arr = new int[strs.Length, constant];
        for (int i = 0; i < strs.Length; i++)
        {
            string[] temp = strs[i].Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            int tmp = temp.Length;
            if (tmp <= 0 || tmp != constant)      // если длина очередной строки 
                // не равна длине первой (с индексом 0) или меньше 1, возвращаем null
                return null;
            for (int j = 0; j < constant; j++)
            {
                int next;
                if (!int.TryParse(temp[j], out next))
                    return null;
                arr[i, j] = next;
            }
        }
        return arr;
    }
    // метод вывода
    public static string ToString(int[,] arr)
    {
        string output = string.Empty;
        for (int i = 0; i < arr.GetLength(0); i++, output += "\r\n")
            // при записи строки в файл, чтобы поставить Enter, нужно писать \r\n
            for (int j = 0; j < arr.GetLength(1); j++)
                output += $"{arr[i, j]}\t";
        return output;
    }
    // TODO: реализуйте методы для транспонирования и нахождения обратной 
    // для данной матрицы(решите с помощью написанной программы СЛАУ Ax = B).
}

class Program
{
    static Random rand = new Random();
    static void Main(string[] args)
    {
        do
        {
            string inputPath = "../../input.txt";
            string outputPath = "../../output.txt";
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("input.txt не существует");
                continue;
            }
            int[,] arr_1 = MatrixOperations.Parser(File.ReadAllLines(inputPath));
            if (arr_1 != null)
            {
                Console.WriteLine(MatrixOperations.ToString(arr_1));
                int[,] mul = MatrixOperations.Mulitply(arr_1, arr_1);
                if (mul != null)
                {
                    string str = MatrixOperations.ToString(mul);
                    Console.WriteLine(str);
                    File.WriteAllLines(outputPath, new string[] { str });
                }
                else Console.WriteLine("Умножение невозможно");
            }
            else Console.WriteLine("Ошибка в файле!");
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
}
