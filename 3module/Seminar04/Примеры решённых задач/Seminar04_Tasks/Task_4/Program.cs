/*
В библиотеке классов Mathematics находятся:
• Класс Expression - представляет математическое выражение.
Поле ex - ссылка на метод-выражение, exEvent – событие, происходящее 
при смене выражения, ExVal – метод вычисления значения выражения
для заданного значения аргумента, конструктор.
• Класс ValueStore - хранит значение выражения. 
Поле exp – ссылка на выражение, x0 – значение аргумента, 
expCurrValue – значение выражения, CurrVal – ссылка на expCurrValue, 
Конструктор: ValueStore (Expression e, double x)
• Классы находятся Expression и ValueStore в отношении агрегации.
В основной программе создать объект me класса Expression, использовать 
ссылку me в конструкторе объекта vs класса ValueStore. Задавая разные 
выражения поля me.ex, выводить значения vs.expCurrValue.
*/
using System;
using Mathematics;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Expression me = new Expression(x => { return x * x + 2 * x - 3; });
            ValueStore vs = new ValueStore(me, 0);
            // Подписываем объект vs на события объекта me
            me.OnExpChanged += vs.OnExpChangedHandler;
            Console.WriteLine(vs.CurrVal);

            // изменяем выражение:
            me.Ex = x => { return Math.Sqrt(Math.Abs(x)); };
            Console.WriteLine(vs.CurrVal);
            me.Ex = x => { return Math.Sin(x); };
            Console.WriteLine(vs.CurrVal);
            me.Ex = x => { return x * x * x - 1; };
            Console.WriteLine(vs.CurrVal);
            Console.ReadLine();
        }
    }
}

