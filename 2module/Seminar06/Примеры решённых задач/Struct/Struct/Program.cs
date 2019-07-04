using System;
using System.Diagnostics;

/*
 Сравним классы и структуры, измеряя производительность программы. Для этого разработаем тестовый класс TestClass 
 с одним автореализуемым свойством целого типа. Класс реализует интерфейс IComparable. Сравнение происходит по значению свойства. 
 Также разработаем тестовую структуру TestStruct с одним открытым автореализуемым свойством. Структура реализует интерфейс IComparable.
 Сравнение происходит по значению свойства.

 В основной программе создать массивы объектов TestClass и TestStruct, состоящие из 1000000 элементов. Отсортировать элементы
 массивов, используя Array.Sort(). Время сортировки измерить, используя средства пространства имён System.Diagnostics
*/

class TestClass : IComparable
{ // тестовый класс
    public int X { get; set; }
    public int CompareTo(Object another)
    {
        if (this.X > ((TestClass)another).X) return 1;
        else if (this.X < ((TestClass)another).X) return -1;
        return 0;
        
    }

}
struct TestStruct : IComparable
{ // тестовая структура
    public int X{ get;set;}
    public int CompareTo(Object another)
    {
        if (this.X > ((TestStruct)another).X) return 1;
        else if (this.X < ((TestStruct)another).X) return -1;
        return 0;
    }
}


class Program
{
    public static Random rnd = new Random();
    private const int N = 1000000;
    public static void PrintTime(TimeSpan timesp)
    {

        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                  timesp.Hours, timesp.Minutes, timesp.Seconds,
                  timesp.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
    static void Main(string[] args)
    {
        TestClass[] tc = new TestClass[N]; // 
        TestStruct[] ts = new TestStruct[N]; // 
        for (int i = 0; i < N; i++)
        {
            tc[i] = new TestClass();
            int tmp = rnd.Next();
            tc[i].X = tmp;
            ts[i].X = tmp;
        }
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Array.Sort(ts); // сортируем массив структур
        sw.Stop(); Console.WriteLine("Struct time"); PrintTime(sw.Elapsed);
        sw.Start();
        Array.Sort(tc); // сортируем массив объектов классов
        sw.Stop(); Console.WriteLine("Class time"); PrintTime(sw.Elapsed);
        Console.ReadKey();
    }
}
