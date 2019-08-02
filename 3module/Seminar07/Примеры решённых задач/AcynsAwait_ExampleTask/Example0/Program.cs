using System;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задача: смоделировать процесс готовки завтрака.
 * Более подробное описание конструкций асинхронного программирования см в Example1
 */

namespace Example0
{
    class Program
    {
        /// <summary>
        /// Приготовление сока
        /// </summary>
        /// <returns>Кружечка сока</returns>
        private static Juice PourOJ()
        {
            return new Juice();
        }

        /// <summary>
        /// Добавление джема на тост
        /// </summary>
        /// <param name="toast"></param>
        private static void ApplyJam(Toast toast)
        {
            toast.HaveJam = true;
        }

        /// <summary>
        /// Добавление масла на тост
        /// </summary>
        /// <param name="toast"></param>
        private static void ApplyButter(Toast toast)
        {
            toast.HaveButter = true;
        }

        /// <summary>
        /// Готовка тоста
        /// </summary>
        /// <param name="i">Время готовки тоста в секундах</param>
        /// <returns>Поджаренный тост</returns>
        private static Task<Toast> ToastBread(int i)
        {
            Console.WriteLine("toasting started");
            return Task.Run(() =>
            {
                Thread.Sleep(i * 1000);
                return new Toast();
            });
        }

        /// <summary>
        /// Готовка бекона
        /// </summary>
        /// <param name="i">Время готовки бекона в секундах</param>
        /// <returns>Поджаренный бекон</returns>
        private static Task<Bacon> FryBacon(int i)
        {
            Console.WriteLine("bacon cooking started");
            return Task.Run(() =>
            {
                Thread.Sleep(i * 1000);
                return new Bacon();
            });
        }

        /// <summary>
        /// Готовка яиц
        /// </summary>
        /// <param name="i">Время готовки яиц</param>
        /// <returns>Пожаренные либо отваренные яйца (на ваш вкус)</returns>
        private static Task<Egg> FryEggs(int i)
        {
            Console.WriteLine("eggs cooking started");
            return Task.Run(() =>
            {
                Thread.Sleep(i * 1000);
                return new Egg();
            });
        }

        /// <summary>
        /// Приготовление кофе
        /// </summary>
        /// <returns>Кружечка кофе</returns>
        private static Coffee PourCoffee()
        {
            return new Coffee();
        }

        /// <summary>
        /// Приготовление завтрака
        /// </summary>
        static async Task MakeBreakfast()
        {
            /*
             * Приготовление завтрака можно описать следующим образом:
             *
             *
             * Coffee cup = PourCoffee();
               Console.WriteLine("coffee is ready");
               Egg eggs = FryEggs(2);
               Console.WriteLine("eggs are ready");
               Bacon bacon = FryBacon(3);
               Console.WriteLine("bacon is ready");
               Toast toast = ToastBread(2);
               ApplyButter(toast);
               ApplyJam(toast);
               Console.WriteLine("toast is ready");
               Juice oj = PourOJ();
               Console.WriteLine("oj is ready");
               
               Console.WriteLine("Breakfast is ready!");

               Заметьте, что тут мы постоянно сначала дожидаемся готовности одного из элементов завтрака,
               и только потом переходим к следующему блюду.
             *
             */


            /*
             * Если у вас есть кулинарный опыт, вы бы выполняли эти инструкции асинхронно.
             * Сначала вы бы поставили сковородку на огонь, а затем занялись бы беконом.
             * Потом бы поставили тосты, а вслед за этим принялись бы за яичницу.
             * На каждом этапе процесса необходимо запустить задачу, а затем обратить внимание на другие задачи,
             * которые требуют вашего внимания.
             *
             * Вы начинаете задачу и сохраняете объект Task, представляющий работу. Этот объект обещает вернуть вам результаты работы.
             * Вы вызываете await для каждой задачи, прежде чем начать работу с ее результатами. Так вы дожидаетесь окончания выполнения,
             * если этого не произошло раньше, и работаете с результатами операции.
             *
             */

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Task<Egg> eggTask = FryEggs(2);
            Task<Bacon> baconTask = FryBacon(3);
            Task<Toast> toastTask = ToastBread(2);
            var toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            Egg eggs = await eggTask;
            Console.WriteLine("eggs are ready");
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            Console.WriteLine("Breakfast is ready!");
        }


        static void Main(string[] args)
        {
            Task breakfast = MakeBreakfast();
            //Метод, который останавливает выполнение кода до тех пор, пока соответствующий таск не завершится
            breakfast.Wait();

        }
    }

    internal class Juice
    {
    }

    internal class Toast
    {
        public bool HaveJam { get; set; }
        public bool HaveButter { get; set; }
    }

    internal class Bacon
    {
    }

    internal class Egg
    {
    }

    internal class Coffee
    {
    }
}
