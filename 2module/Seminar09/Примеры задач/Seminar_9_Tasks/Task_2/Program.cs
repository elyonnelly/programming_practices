/*
Реализовать математические операции (сложить, вычесть, умножить, поделить)
с помощью перечисления. В основной программе провести вычисления для любух двух операций.
*/
using System;

namespace Task_2
{
    class Program
    {
        //Инициализация перечисления
        enum Operation
        {
            Add = 1,
            Subtract, //2
            Multiply, //3
            Divide //4
        }
        static void Main()
        {
            // Тип операции задаем с помощью константы Operation.Add, которая равна 1
            // (приводим 1 |int| к Operation)
            MathOp(10, 5, (Operation)1);
            // Тип операции задаем с помощью константы Operation.Multiply, которая равна 3
            MathOp(11, 6, Operation.Multiply);
            Console.ReadKey(true);
        }
        static void MathOp(double x, double y, Operation op)
        {
            double result = 0;
            // Выбор операции
            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
                default:
                    Console.WriteLine("Неверная операция!");
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }
    }
}
