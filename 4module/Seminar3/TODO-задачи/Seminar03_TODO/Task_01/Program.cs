/*
Написать класс Complex для работы с комплексными числами. 
Напишите метод (публичный) для получения модуля комплексного числа. 
Переопределите: инкременты “--” и “++”, true (если модуль 
комплексного числа больше 1), false (если модуль ≤ 1). 
*/
using System;

namespace Task_01
{
    class Program
    {
        static void display(Complex cs)
        {
            Console.WriteLine("real=" + cs.re + ", image=" + cs.im);
        }
        static void Main()
        {
            Complex c1 = new Complex(4, 3.3);
            Console.WriteLine("Модуль исходного комплексного числа = " + c1.Mod());
            while (c1)
            {
                Console.Write("c1 => "); display(c1);
                c1--;
            }
            Console.WriteLine("Модуль полученного числа = " + c1.Mod());
            Console.WriteLine("Число принадлежит кругу с радиусом 1.");
            Console.ReadLine();
        }
    }
}
