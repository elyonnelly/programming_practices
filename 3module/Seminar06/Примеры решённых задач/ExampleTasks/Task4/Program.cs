/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: deadlock Получить справки (пункт А забрал себе А и ждёт В, пункт B забрал B и ждёт A)
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {

        static object lockerA = new object();
        static object lockerB = new object();

        public static void GetCertificateA()
        {
            lock (lockerA)
            {
                Thread.Sleep(400);
                lock (lockerB)
                {
                    Console.WriteLine("Справка A успешно получена!");
                }
            }
        }

        public static void GetCertificateB()
        {
            lock (lockerB)
            {
                Thread.Sleep(400);
                lock (lockerA) // Если закомментировать этот lock, то B не будет ждать справки А и отдаст 
                               // справку B просто так, дедлок не возникнет
                {
                    Console.WriteLine("Справка B успешно получена!");
                }
            }
        }

        static void Main(string[] args)
        {
            Thread threadA = new Thread(GetCertificateA);
            Thread threadB = new Thread(GetCertificateB);

            threadA.Start();
            threadB.Start();

            // Каждую секунду проверяем, получили ли мы справки
            while (threadA.ThreadState != ThreadState.Stopped && threadB.ThreadState != ThreadState.Stopped)
            {
                Console.WriteLine("Получаем справки...");
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
