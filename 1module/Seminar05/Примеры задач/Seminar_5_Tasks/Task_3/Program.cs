using System;

/*
Дано: 4 переменной типа Random
Необходимо найти количество прохождений всего цикла глубины 4 
(границы для каждого уровня от 0 до случайной величины в диапазоне 1…10). 
Будет ли разница, если создать одну переменную типа Random.
*/

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        Random[] rans = new Random[4];
        for (int i = 0; i < 4; i++)
        {
            rans[i] = new Random();
        }
        int[] edges = new int[4];

        for (int i = 0; i < 4; i++)
        {
            edges[i] = rans[i].Next(0, 10);
            Console.Write($"{edges[i]} \t");
        }
        Console.Write("\n");
        for (int i = 0; i < edges[0]; i++)
        {
            for (int j = 0; j < edges[1]; j++)
            {
                for (int k = 0; k < edges[2]; k++)
                {
                    for (int m = 0; m < edges[3]; m++)
                    {
                        if ("3333" == i.ToString() + j.ToString() + k.ToString() + m.ToString())
                        {
                            goto A;
                        }
                        count++;
                    }
                }
            }
        }
    A: Console.WriteLine($"Количество полных итераций {count}");
        Console.ReadKey(true);
    }
}

