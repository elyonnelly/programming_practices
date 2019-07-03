using System;

/*
Дано две вещественные переменные (variable_1, variable_2) с начальным значением 0
и два случайных вещественных числа в диапазоне [0,N) - шагов (step_1, step_2) увеличения этих переменных.
Найти сколько раз необходимо перезадать шаги (присвоить новые вещественные числа
в диапазоне [0,N)), чтобы, одновременно увеличивая каждое из переменных
на соответствующий шаг, они округленно (к ближайшему целому) равнялись K. 
N и K вводятся с клавиатуры (N и K лежат в диапазоне [1,100]).
*/

class Program
{
    // ввод чисел с клавиатуры
    static int Input(string Name)
    {
        int temp;
        while (true)
        {
            Console.WriteLine($"Введите {Name}");
            if (int.TryParse(Console.ReadLine(), out temp) && temp > 0 && temp < 101)
                break;
            Console.WriteLine("Некорректное число");
        }
        return temp;
    }

    static void Main(string[] args)
    {
        do
        {
            Random random_1 = new Random(), random_2 = new Random();
            double step_1 = 0d, step_2 = 0d;
            int N = Input("N"), K = Input("K");
            Console.WriteLine("Некорректное использование Random");
            double temp = 0d;
            // NextDouble возвращает вещественное число в диапазоне [0,1)
            // Next возвращает целое [0,K) <=> [0,K-1] (правая граница не включается)
            do { temp = random_1.Next(0, N) + random_1.NextDouble(); }
            while (temp == 0);
            step_1 = temp;
            do { temp = random_2.Next(0, N) + random_2.NextDouble(); }
            while (temp == 0);
            step_2 = temp;
            Console.Write($"step_1 = {step_1:f3}\t step_2 = {step_2:f3}");
            step_1 = step_2 = 0d;
            // Random в С# берётся от времени на текущий момент времени, 
            // поэтому, чтобы получить разные случайные числа, НЕ НУЖНО создавать два разных Random !!!

            Console.Write("\n \n"); // \n - escape - последовательность (новая строка)

            // https://docs.microsoft.com/ru-ru/cpp/c-language/escape-sequences?view=vs-2019
            
            int count = 0, output = 0; // обнуляем счётчик
            double variable_1 = 0d, variable_2 = 0d;
            for (variable_1 = 0, variable_2 = 0; true; // бесконечный цикл
                variable_1 += step_1, variable_2 += step_2)
            {
                if (K == Math.Round(variable_1) && K == Math.Round(variable_2))
                    break; // выход из цикла
                if (Math.Round(variable_1) > K || Math.Round(variable_2) > K || variable_1 == 0d || variable_2 == 0d)
                {
                    Console.WriteLine("Обнуляем счётчики и переменные, задаём новые шаги");
                    variable_1 = variable_2 = 0d;
                    count = 0;
                    do { temp = random_1.Next(0, N) + random_1.NextDouble(); }
                    while (temp == 0);
                    step_1 = temp;
                    do { temp = random_1.Next(0, N) + random_1.NextDouble(); }
                    while (temp == 0);
                    step_2 = temp;
                    Console.WriteLine($"step_1 = {step_1:f3}\t step_2 = {step_2:f3}");
                    output++; // счётчик изменения счётчиков
                }
                count++;
            }

            Console.WriteLine($"Количество перезадания шагов (случайных чисел): {output} \n" +
                $"(int)({step_1:f3} * {count} = {variable_1:f3}) = {K} \t " +
                $" (int)({step_2:f3} * {count} = {variable_2:f3}) = {K} \t");
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
