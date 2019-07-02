using System;
using System.IO;

namespace toDo
{
    class Program
    {/*
        Пользователь хочет узнать, сколько времени прошло с тех пор, как он создал файл
        Вывести время в днях и часах
         */
        static void Main(string[] args)
        {
            do
            {
                string path = Console.ReadLine();
                //TODO Проверить файл на существование. При его отсутствии создать новый
                DateTime creation ;//TODO Правильно определить время создания файла(Посмотрите его методы)
                DateTime timeNow = DateTime.Now;
                TimeSpan step = timeNow - creation;

                // TODO Выведите разницу времени после создания файла. Посмотрите поля класса TimeSpan
                // TODO Выведите разницу времени после создания файла. Посмотрите поля класса TimeSpan
                Console.WriteLine("Для выхода нажмите Enter");//TODO Создайте повтор решения
            } while (true);
        }
    }
}
