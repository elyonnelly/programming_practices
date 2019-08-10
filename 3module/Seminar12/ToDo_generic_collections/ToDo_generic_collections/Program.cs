using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
TODO
Используя пример задачи, приведенный ниже, добавьте в код следующие методы:
Remove(item) -- удаление элемента item, если он есть в коллекции
Find(item) -- Поиск элемента и возврат индекса элемента. Если элемента нет, то вернуть -1
Sort() -- метод, который сортирует элементы массива
Наложить ограничения на классы, чтобы они реализовывали сортировку
В основной программе проверить работоспособность всех методов, отловить все ошибки.
 */
namespace Generic_class
{

    class MyArray<T>
    {
        public int Length { get; private set; }// Текущее количество элементов
        T[] list;


        public MyArray()
        {
            Length = 0;
            list = new T[1];
        }

        public void Add(T item)
        {
            if (list.Length == Length)
                this.Increase();
            list[Length] = item;
            ++Length;
        }

        void Increase()
        {
            T[] tmp = new T[list.Length * 2];
            for (int i = 0; i < list.Length; i++)
            {
                tmp[i] = list[i];
            }
            list = tmp;
        }

        public T this[int index]
        {
            get {
                if (index >= Length)
                    throw new IndexOutOfRangeException();
                return list[index];
            }
            set {
                if (index >= Length)
                    throw new IndexOutOfRangeException();
                list[index] = value;
            }
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            MyArray<int> test = new MyArray<int>();
            for (int i = 0; i < 20; i++)
            {
                test.Add(rnd.Next(0, 10001));
            }

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            Console.ReadKey();
        }
    }
}
