using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkLib
{
    public class Drink
    {

        /*
         TODO
         Изменить свойства для проверки адекватности вводимых данных
         температура от 20 до 100, иначе рандомное число в этом промежутке
         тип только juice, tea или coffee. По умолчанию сок
         Вместимость от 1 до 1000, иначе случайное число в этом промежутке
        */
        public bool IsSugar { get; private set; }
        public bool IsMilk { get; private set; }
        public int Temperature { get; private set; }
        public string Type { get; private set; }
        public double Capacity { get; private set; }

        /* TODO 
          Реализовать индексатор, отслеживающий температуру чашки кофе
          принимаемое значение - int - время, прошедшее с заваривания (при заваривании температура 100)
          Возвращает Temperature^(1/time), температура не может быть меньше 20. Время не может быть меньше 0
        */

        public Drink()
        {
            IsSugar = false;
            IsMilk = false;
            Capacity = 200;
            Type = "Juice";
            Temperature = 20;
        }

        /*
         * TODO создать конструктор от пяти параметров - наличие молока, сахара, емкость, тип напитка и температура
         */

    }
}
