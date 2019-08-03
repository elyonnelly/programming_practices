using System;
using System.IO;
using System.Threading.Tasks;

/*
 * Иммитируйте работу комментариев к имиджборду.
 * Записывайте в файл, представляющий собой комменты,
 * гусей-работяг и гусей-гидр, пока от пользователей поступают соответствующие запросы.
 *
 * Возможные запросы от пользователей:
 *
 * worker N -- запостить в комментах N гусей-работяг
 * hydra N -- запостить в комментах N гусей-гидр
 * end -- конец всех запросов (комментарии переполнились)
 *
 * Записывайте гусей асинхронно. В случае, когда кому-то захотелось записать 10^7 гусей,
 * интерфейс должен продолжать откликаться, пока происходит запись.
 *
 */

namespace Async_Await_TODO
{
    class Program
    {
        static async void PostGoose(string path, string message, int n)
        {
            //TODO: напишите асинхронный метод, записывающий в файл гусей.

            using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        writer.Write(message);
                    }
                });
            }

            //TODO: Используйте WriteAsync или WriteLineAsync из класса StreamWriter. 
            //Добейтесь работоспособности программы.


            Console.WriteLine("Запрос обработан");
        }

        static void Main(string[] args)
        {
            string request;

            Console.WriteLine("готов записывать гусей...");
            do
            {
                request = Console.ReadLine();
                var parts = request.Split();
                if (parts[0] == "worker")
                {
                    PostGoose("../../../comments.txt", worker, int.Parse(parts[1]));
                }

                if (parts[0] == "hydra")
                { 
                    PostGoose("../../../comments.txt", hydra, int.Parse(parts[1]));
                }
            } while (request != "end");
        }



        private const string worker =
            "ЗАПУСКАЕМ" +
            "\r\n░ГУСЯ░▄▀▀▀▄░РАБОТЯГИ░░" +
            "\r\n▄███▀░◐░░░▌░░░░░░░" +
            "\r\n░░░░▌░░░░░▐░░░░░░░" +
            "\r\n░░░░▐░░░░░▐░░░░░░░" +
            "\r\n░░░░▌░░░░░▐▄▄░░░░░" +
            "\r\n░░░░▌░░░░▄▀▒▒▀▀▀▀▄" +
            "\r\n░░░▐░░░░▐▒▒▒▒▒▒▒▒▀▀▄" +
            "\r\n░░░▐░░░░▐▄▒▒▒▒▒▒▒▒▒▒▀▄" +
            "\r\n░░░░▀▄░░░░▀▄▒▒▒▒▒▒▒▒▒▒▀▄" +
            "\r\n░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄" +
            "\r\n░░░░░░░░░░░▌▌░▌▌░░░░░" +
            "\r\n░░░░░░░░░░░▌▌░▌▌░░░░░" +
            "\r\n░░░░░░░░░▄▄▌▌▄▌▌░░░░░ ";

        private const string hydra =

            "ЗАПУСКАЕМ░░\r\n░ГУСЯ░▄▀▀▀▄░ГИДРУ░░" +
            "\r\n▄███▀░◐░▄▀▀▀▄░░░░░░" +
            "\r\n░░▄███▀░◐░░░░▌░░░" +
            "\r\n░░░▐░▄▀▀▀▄░░░▌░░░░" +
            "\r\n▄███▀░◐░░░▌░░▌░░░░" +
            "\r\n░░░░▌░░░░░▐▄▄▌░░░░░" +
            "\r\n░░░░▌░░░░▄▀▒▒▀▀▀▀▄" +
            "\r\n░░░▐░░░░▐▒▒▒▒НАС▒▒▀▀▄" +
            "\r\n░░░▐░░░░▐▄▒▒▒▒НЕ▒▒▒▒▒▀▄" +
            "\r\n░░░░▀▄░░░░▀▄▒▒▒ОТЧИСЛЯТ▀▄" +
            "\r\n░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄" +
            "\r\n░░░░░░░░░░░▌▌░▌▌░░░░░" +
            "\r\n░░░░░░░░░░░▌▌░▌▌░░░░░" +
            "\r\n░░░░░░░░░▄▄▌▌▄▌▌░░░░░";

    }
}


