using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется написать обобщенный класс MyArray<T>, который будет реализовывать динамический массив
 В классе должны быть определены следующие свойства и поля:
        int Length -- количество элементов в массиве,
        T[]  сам массив с элементами.
а так же методы:
        Add(T iten) -- добавлетие элемента в коллекцию
        Increase() -- увеличение размера массива в 2 раза
        Индексатор с get и set аксессорами, которые возвращают/присваивают i-му элементу массива значение
В основной программе создать объект этого класса и добавить в него 10 элементов типа int с помощью методов класса. 
Вывести все значения массива на экран.
 */
namespace Generic_class
{

    class MyArray<T> 
    {
        public int Length { get; private set;}// Текущее количество элементов
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
            get 
            { 
                if (index >= Length)
                    throw new IndexOutOfRangeException();
                return list[index];
            }
            set 
            {
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
                test.Add(rnd.Next(0,10001));
            }

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            Console.ReadKey();
        }
    }
}
