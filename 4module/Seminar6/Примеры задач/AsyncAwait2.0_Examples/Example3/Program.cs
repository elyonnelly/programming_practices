using System;
using System.IO;
using System.Threading.Tasks;

/*
 * Асинхронное чтение веб-страниц -- то, ради чего (во многом) всё и затевалось,
 * поскольку обращение к серверу может занимать много времени, в это время клиентское
 * приложение не должно виснуть.
 *
 * Реализуем простейший проход по веб-странице из консольного приложения, не вдаваясь в подробности
 * и схему работы http-запросов и всего подобного.
 *
 */

namespace TODO3
{
    class Program
    {
        /// <summary>
        /// Метод, считающий количество вхождений слова pattern в текст страницы
        /// </summary>
        /// <param name="data">Поток, содержащий веб-страницу</param>
        /// <param name="pattern">Паттерн поиска</param>
        /// <returns></returns>
        private static int FindWords(Stream data, string pattern)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(data))
            {
                string str = reader.ReadLine();
                while (str != null)
                {
                    var words = str?.Split();
                    foreach (var word in words)
                    {
                        if (word == pattern)
                        {
                            count++;
                        }
                    }

                    str = reader.ReadLine();
                }
            }

            Console.WriteLine($"количество найденных слов {pattern}: {count}");
            return count;
        }

        /// <summary>
        /// Метод, запускающий асинхронный процесс просмотра веб-страницы на предмет наличия слова pattern в тексте страницы
        /// </summary>
        /// <param name="pattern">Паттерн</param>
        /// <returns></returns>
        private static async Task<int> FindWordsAsync(string pattern)
        {
            //WebClient -- это, грубо говоря, контейнер всего, что нам было бы интересно узнать и сделать со страницей.
            //подробнее -- велком ту msdn
            //заодно узнайте про http-запросы.
            using (var client = new System.Net.WebClient())
            {
                //Запуск асинхронного чтения страницы
                var data = await client.OpenReadTaskAsync(new Uri("https://en.wikipedia.org/wiki/Philosophy"));
                //Запуск асинхронного процесса подсчета вхождений pattern на страницу
                return await Task.Run(() => FindWords(data, pattern));
            }
        }

        static void Main(string[] args)
        {
            Task.Run(() => FindWordsAsync("are")).Wait();
        }
    }
}

