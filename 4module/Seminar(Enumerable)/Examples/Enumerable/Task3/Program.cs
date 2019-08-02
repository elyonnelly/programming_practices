using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    /*
     * Теперь мы посмотрим на крутую штуку
     * yeild return
     * если мы также запустим дебаг
     * то покажется что метод GetEnumrator()
     * на время прерывается, НО
     * 
     * На самом деле данная конструкция с помощью высшей магии на уровне языка
     * разворачивается в конструкцию, которую мы видели в предыдущем задании
     * и рботает по тем же самым правилам))
     */

    class Seqences<T> : IEnumerable<T>
    {
        T[] seqences;

        public Seqences(T[] seqences)
        {
            this.seqences = seqences;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < seqences.Length; i++)
            {
                yield return seqences[i];
            }
        }

        /// <summary>
        /// это синтаксических сахар, существующий из-за того что дженерики появились после итераторов((
        /// там IEnumerable<T> наследуется от IEnumerable и чуточку букв лишних приходится из-за этого писать
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Seqences<int> fib = new Seqences<int>(new int[] { 1, 1, 2, 3, 5, 8, 12, 21 });
            foreach (var item in fib)
            {
                Console.WriteLine(item);
            }
            Console.Read();
            //хорошо мы 3мя способоами написали бесполезную вещь теперь посмотрим как этим пользоваться более менее нормально))
        }
    }
}
