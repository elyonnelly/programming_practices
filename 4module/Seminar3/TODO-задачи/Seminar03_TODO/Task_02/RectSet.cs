using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_02
{
    public class RectSet
    {
        public static Random rnd;
        // координаты левой границы
        int x1;
        // координаты правой границы
        int x2;
        // множество представлено объектом HashSet<>
        HashSet<int> set;
        public HashSet<int> GetSet { get { return set; } }
        public RectSet()
        {
            set = new HashSet<int>();
        }
        public RectSet(int min, int max, int N)
        {
            // создаём массив случайных чисел
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = rnd.Next(min, max + 1);
            set = new HashSet<int>(arr); // конструируем множество
                                         // добавляем границы
            Array.Sort(arr);
            x1 = arr[0]; x2 = arr[arr.Length - 1];
        }
        public RectSet(HashSet<int> mySet)
        {
            set = mySet; // ToDO_1 
        }
        // перегружаем + для объединения множеств RectSet
        public static RectSet operator +(RectSet a, RectSet b)
        {
            // используем метод Concat() из HashSet<>
            return new RectSet(new HashSet<int>(a.GetSet.Concat(b.GetSet)));
        }
        // ToDO_2
        // ToDO_3
    }
}
