using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    /*
     * Ваше задание поставить точку остановки в foreach и
     * посомтреть как происходит итерирование внутри класса
     * дебагер не будет заходить в метод Current , чтобы удостовериться, что программа туда заходит
     * поставьте точку остановки также и в метод Current
     * 
     * кажется мы написали какую-то очень страшную штуку 
     * не понятно для чего тк результат даже не изменился,
     * но благодаря такой конструкции можно прописать логику итерирования
     * но не беспокойтесь данная конструкция нужна больше для понимания
     * переходим к следующей таске
     */
    class Seqences<T>
    {
        T[] array;

        public Seqences(T[] array)
        {
            this.array = array;
        }
         
        public IEnumerator<T> GetEnumerator()
        {
            return new SeqencesEnumerator(array);
            //по хорошему нужно передавать this те обьект, но я хотел показать, что вложенный класс понимает обобщени по автомату))
        }
        //засунули класс внутрь теперь необязательного его обобщать
        //также часто используются поля и базового класса в итерировании
        //те чтобы класс итерирования видел поля из базового класса их надо было бы делать публичными, а это нарушает инкапсуляцию
        class SeqencesEnumerator : IEnumerator<T>
        {
            T[] seqences;
            int position = -1;//-1, потому что сначала при итерирования вызывается метод MoveNext и position  станет равным нулю
            public SeqencesEnumerator(T[] seqences)
            {
                this.seqences = seqences;
            }

            /// <summary>
            /// вызвращает элемент на котором стоит каретка
            /// </summary>
            public T Current
            {
                get => seqences[position];
                
            }

            object IEnumerator.Current => Current;//исправьте и объясните, что это такое

            public void Dispose() { }//не вызыывается при итерировании
            

            /// <summary>
            /// передвигает каретку
            /// </summary>
            /// <returns>возвращает истину если получилось передвинуть каретку, ложь в другом случае</returns>
            public bool MoveNext()
            {
                if (position < seqences.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                    return false;

            }

            /// <summary>
            /// передвигает каретку на изначальное положение
            /// </summary>
            public void Reset()
            {
                position = -1;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Seqences<int> fib = new Seqences<int>(new int[] { 1,1,2,3,5,8,13,21});
            foreach (var item in fib)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
