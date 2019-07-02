using System;

/*
Необходимо написать цикл глубины 4 и найти количество прохождений всего цикла 
(столько же, сколько выполнится цикл, вложенный во все другие). 
Границы для каждого уровня [0,10], шаг случайный вещественный в диапазоне [0,3] 
(если случайный шаг получился 0, то присваивать переменной другие вещественные значения 
в диапазоне [0,3], пока он не станет ненулевым 
P.S. шаг должен быть не 0, т.к. иначе возникнет бесконечный цикл).
*/

class Program
{
    static void Main(string[] args)
    {
        do
        {
            int count = 0;
            Random[] rans = new Random[4];
            for (int i = 0; i < 4; i++)
            {
                rans[i] = new Random();
            }
            double[] steps = new double[4];
            Console.WriteLine("Некорректное использование Random");
            for (int i = 0; i < 4; i++)
            {
                double temp = 0d;
                // NextDouble возвращает вещественное число от 0 до 1
                // Next возвращает целое [0,3) <=> [0,2] (правая граница не включается)
                do { temp = rans[i].Next(0, 3) + rans[i].NextDouble(); }
                while (temp == 0);
                steps[i] = temp;
                Console.Write($"rand_{i} = {steps[i]}\t"); // Random в С# берётся от времени на текущий момент времени, 
                                                           // поэтому чтобы получить разные случайные шаги НЕ НУЖНО создавать четыре разных Random !!!
            }
            Console.Write("\n"); // \n - escape - последовательность (новая строка)
            Console.WriteLine("Корректное использование Random");
            Random random = rans[0]; // берём один (экземпляр класса) Random
            for (int i = 0; i < 4; i++)
            {
                double temp = 0d;
                do { temp = random.Next(0, 3) + random.NextDouble(); }
                while (temp == 0);
                steps[i] = temp;
                Console.Write($"rand_{i} = {steps[i]}\t");
            }
            Console.Write("\n");
            // https://docs.microsoft.com/ru-ru/cpp/c-language/escape-sequences?view=vs-2019

            for (double i = 0; i < 10; i += steps[0])
            {
                for (double j = 0; j < 10; j += steps[1])
                {
                    for (double k = 0; k < 10; k += steps[2])
                    {
                        for (double m = 0; m < 10; m += steps[3])
                        {
                            if ("3333" == ((int)i).ToString() + ((int)j).ToString() +
                                ((int)k).ToString() + ((int)m).ToString())
                            {
                                goto A;
                            }
                            count++;
                        }
                    }
                }
            }
        A: Console.WriteLine($"Количество полных итераций {count}");

            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine("Для выхода из программы нажмите Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
