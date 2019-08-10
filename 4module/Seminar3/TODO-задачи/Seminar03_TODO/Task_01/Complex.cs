using System;

namespace Task_01
{
    class Complex
    {
        // действительная и мнимая части комплексного числа 
        public double re, im;
        // конструктор
        public Complex(double xre, double xim)
        { re = xre; im = xim; }
        // перегрузка --
        public static Complex operator --(Complex mc)
        { mc.re--; mc.im--; return mc; }
        // public static myComplex operator ++(myComplex mc)
        // { mc.re++; mc.im++; return mc; }
        // модуль комплексного числа
        public double Mod() { return Math.Abs(re * re + im * im); }
        // перегрузка true
        static public bool operator true(Complex f)
        {
            if (f.Mod() > 1.0) return true;
            else return false;
        }
        // перегрузка false
        static public bool operator false(Complex f)
        {
            if (f.Mod() <= 1.0) return true;
            else return false;
        }
        /*
        Дополнить код класса Complex перегрузками бинарных операций:
        1. +, для сложения комплексных чисел
        2. * для умножения комплексных числе
        3. - для вычисления разности комплексных чисел
        4. / получения частного от деления комплексных чисел
        Создайте два комплексных числа и продемонстрируйте работу перегруженных операций.
        */
    }
}
