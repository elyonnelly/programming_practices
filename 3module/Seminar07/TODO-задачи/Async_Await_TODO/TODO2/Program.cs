using System;
using System.Threading.Tasks;

/*
 * С помощью асинхронных операций также можно ускорять вычисления.
 * Например, вычислим интеграл на отрезке, разделив эти вычисления на несколько потоков.
 */

namespace TODO2
{
    class Program
    {
        /// <summary>
        /// Подсчет интеграла на отрезке методом трапеции
        /// </summary>
        /// <param name="f">Подынтегральное выражение</param>
        /// <param name="l">Левая граница отрезка</param>
        /// <param name="r">Правая граница отрезка</param>
        /// <param name="delta">Точность вычисления</param>
        /// <returns></returns>
        static double CalcIntegral(Func<double, double> f, double l, double r, double delta)
        {
            double sum = 0;
            for (double x = l; x <= r; x += delta)
            {
                sum += (f(x) + f(x - delta)) * delta /2;
            }

            return sum;
        }

        /// <summary>
        /// Асинхронный метод, подсчитывающий значение интеграла на отрезке
        /// </summary>
        /// <param name="f">Подынтегральное выражение</param>
        /// <param name="l">Левая граница отрезка</param>
        /// <param name="r">Правая граница отрезка</param>
        /// <param name="delta">Точность вычисления</param>
        /// <param name="numberOfThread">Количество потоков, на которые дробится вычисление</param>
        /// <returns></returns>
        static async Task<double> CalcIntegralAsync(Func<double, double> f, double l, double r, double delta, int numberOfThread)
        {
            //В данный момент код работает синхронно
            //TODO: исправьте код так, чтобы он работал асинхронно

            double len = (r - l) / numberOfThread;
            double x = l;

            double integral = 0;

            for (int i = 0; i < numberOfThread; i++)
            {
                integral += await Task<double>.Run(() => CalcIntegral(f, x, x + len, delta));
                x += len;
            }

            return integral;
        }

        static void Main(string[] args)
        {
            //Делегат обобщенного типа Func<T, TResult>, принимает функцию с параметром типа T и возвращаемым значением типа TResult
            //В данном случае мы присваиваем делегату лямбда-фунцию, вычисляющую квадрат числа.
            Func<double, double> f = (x) => x * x;
            double L = 0, R = 5, delta = 0.001;
            int numberOfThread = 2;
            //TODO: добавить ввод с клавиатуры параметров операций

            //Вероятно, это более корректная стратегия общения с асинхронными методами в Main:

            Task<double> calcIntegral = CalcIntegralAsync(f, L, R, delta, numberOfThread);
            //Метод, который останавливает выполнение кода до тех пор, пока соответствующий таск не завершится
            calcIntegral.Wait();
            //Так как таск завершил свое выполнение, мы можем обратиться к его свойству Result (хранящему, собственно, результат выполнения)
            var integral = calcIntegral.Result;

            //TODO: с помощью таймера измерьте время подсчета интеграла на одном потоке и на нескольких.
            //TODO: выясните, какое количество потоков оптимальнейшее
            Console.WriteLine(integral);
        }   
    }
}
