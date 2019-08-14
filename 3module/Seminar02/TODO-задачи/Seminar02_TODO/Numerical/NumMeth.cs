using System;

namespace Numerical
{
    public delegate double function(double x); //Объявление делегата-типа
    public class NumMeth
    {
        // Метод поиска корня функции делением интервала пополам:
        static public double bisec(double a, double b, // Границы интервала
        double epsX, double epsY, // точность по абсциссе и ординате
        function f)
        { // f - исследуемая функция
            double x, y, z; // локальные переменные
            x = a; y = f(x);
            if (Math.Abs(y) <= epsY) return x;
            x = b; z = f(x);
            if (Math.Abs(z) <= epsY) return x;
            if (y * z > 0)
                throw new Exception("Интервал не локализует корень функции!");
            do
            {
                x = a / 2 + b / 2; y = f(x);
                if (Math.Abs(y) <= epsY) return x;
                if (y * z > 0) b = x; else a = x;
            } while (Math.Abs(b - a) >= epsX);
            return x;
        } // bisec()

        //.. Одномерная минимизация:
        // Делегат-тип для представления критерия оптимизации:
        public delegate double Functional_1(double x);
        // Метод для поиска минимума методом золотого сечения (Algo8-1.c).
        // Возвращает значение аргумента:
        public static double Optimum_1(Functional_1 fun,
        // fun - минимизируемая функция (функционал)
        double A, double B, //границы интервала
        double Delta, double Epsilon)
        { // точности по абсциссе и ординате
            double Rone = (Math.Sqrt(5.0) - 1.0) / 2.0; // Determine constants
            double Rtwo = Rone * Rone; /* for golden search */
            double YA, YB; /* function values at A and B */
            double C, D; /* interior points */
            double H; /* width of interval */
            double P, YC, YD, YP; /* minimum and function values */
            YA = fun(A);
            YB = fun(B);
            H = B - A;
            C = A + Rtwo * H;
            YC = fun(C);
            D = A + Rone * H;
            YD = fun(D);
            while (Math.Abs(YA - YB) > Epsilon || H > Delta)
            {
                if (YC < YD)
                {
                    B = D;
                    YB = YD;
                    D = C;
                    YD = YC;
                    H = B - A;
                    C = A + Rtwo * H;
                    YC = fun(C);
                }
                else
                {
                    A = C;
                    YA = YC;
                    C = D;
                    YC = YD;
                    H = B - A;
                    D = A + Rone * H;
                    YD = fun(D);
                }
            }
            P = A;
            YP = YA;
            if (YB < YA)
            {
                P = B;
                YP = YB;
            }
            return P;
        }//Optimum_1
    }
}
