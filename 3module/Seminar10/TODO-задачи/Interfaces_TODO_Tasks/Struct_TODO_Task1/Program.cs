using System;
using System.Collections.Generic;
namespace Struct_TODO_Task1
{
    interface ICalc
    {
        /// <summary>
        /// Отобразить число в каноническом виде
        /// </summary>
        void Show();

        /// <summary>
        /// Получить сумму двух гиперкомплексных чисел
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        void Sum(ICalc X, ICalc Y);

        /// <summary>
        /// Получить сопряженное 
        /// </summary>
        /// <returns></returns>
        ICalc GetPaired();

        /// <summary>
        /// Получить норму числа
        /// </summary>
        /// <returns></returns>
        double GetNorm();
    }

    //TODO Реализуйте интерфейс ICalc для вещественного числа
    struct Complex
    {
        private double a, b;

    }

    //TODO реализуйте интерфейс ICalc для кватернионов
    struct Quaternion
    {
        private double a, b, c, d;
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TODO создайте 5 комплексных чисел и 5 кватернионов, добавьте их в список типа ICalc
            //TODO Последовательно выведите нормы всех попарных сумм чисел одного вида
        }
    }
}
