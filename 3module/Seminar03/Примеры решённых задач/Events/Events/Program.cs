using System;
/*
 Программа оценивает "трудоемкость" алгоритма сортировки массива. 
В конце каждой итерации внешнего цикла сортировки возникает событие. 
На событие реагируют два объекта-наблюдателя. 
Один выводит текущее значение счетчика выполненных обменов при сортировке. 
Второй - визуализирует с помощью "индикатора процесса" выполнение сортировки. 
Один из методов наблюдения статический, второй - метод объекта. 

 */


// Объявление делегата-типа:
public delegate void SortHandler(long cn, int si, int kl);
class Sorting
{ // класс сортировки массивов    
    int[] ar;   // ссылка на массив
    public long count; // счетчик выполненных обменов при сортировке
    public event SortHandler onSort; // объявление события
    public Sorting(int[] ls)
    { // конструктор            
        count = 0; ar = ls;
    }
    public void Sort()
    {// сортировка с посылкой извещений         
        int temp;
        for (int i = 0; i < ar.Length - 1; i++)
        {
            for (int j = i + 1; j < ar.Length; j++)
                if (ar[i] > ar[j])
                {
                    temp = ar[i];
                    ar[i] = ar[j];
                    ar[j] = temp;
                    count++;
                }
            if (onSort != null) // сортировка не завершена
                onSort(count, ar.Length, i); // генерация события 
        }
    }

}
class View
{    // Обработчик событий в объектах
    public void nShow(long n, int si, int kl)
    {
        Console.Write("\r" + n); // статус сортировки
    }
}
class Display
{ // Обработчик событий в этом классе
    static int len = 30;
    static string st = null;

    public static void BarShow(long n, int si, int kl)
    {
        int pos = Math.Abs((int)((double)kl / si * len));
        string s1 = new string('\u258c', pos); //код для вертикального бара
        string s2 = new string('-', len - pos - 1);
        st = s1 + '\u258c' + s2; //'\u258c' - код прямоугольника 
        Console.Write("\r\t\t" + st);
    }
}

class Controller
{
    static void Main()
    {
        Random ran = new Random(55);
        int[] ar = new int[19999];
        for (int i = 0; i < ar.Length; i++)
            ar[i] = ran.Next();
        Sorting run = new Sorting(ar);
        View watch = new View();    // Создан объект
        run.onSort += new SortHandler(Display.BarShow);
        run.onSort += new SortHandler(watch.nShow);
        run.Sort();
        Console.Write("\n");
        Console.WriteLine("Для выхода нажмите любую кнопку");
        Console.ReadKey();
    }
}
