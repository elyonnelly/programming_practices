using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    /*
     * начнем с самого простого
     * у нас есть последовательность нам нужно пойтись по ней 
     * с помощью цикла foreach
     */
    class Seqences:IEnumerable
    {
        int[] array;

        public Seqences(int[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Seqences fib = new Seqences(new int[] { 1,1,2,3,5,8,13,21});
            foreach (var item in fib)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
