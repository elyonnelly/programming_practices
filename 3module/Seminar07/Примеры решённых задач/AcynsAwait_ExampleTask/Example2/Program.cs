using System;
using System.IO;
using System.Threading.Tasks;

/*
 * Задача: реализовать работу с базой данных, записанной в файле dates.txt
 * В файле записано 30^7 целых чисел из диапазона [-10.000.000;10.000.000]
 * Реализовать пользовательский интерфейс:
 * 1 N -- Посчитать количество чисел в БД, равных N
 * 2 L R -- Посчитать сумму чисел на интервале
 * 3 L R Delta -- изменить значения на интервале на дельту.
 *
 * Программа не должна "виснуть" после каждого запроса пользователя.
 */

namespace Example2
{
    /*
     * Теперь мы знаем про работу тасков. Теперь надо показать, с чем ее едят. Покажем асинхронную работу с файлами...
     */

    class Program
    {
        static int ReadInt()
        {
            string request;
            int number;
            do
            {
                //Console.WriteLine("")
                request = Console.ReadLine();
            } while (!int.TryParse(request, out number));


            return number;
        }

        static void CreateFile()
        {
            var rnd = new Random();

            using (StreamWriter reader = new StreamWriter(File.Create(@"../../../dates.txt")))
            {
                for (int i = 0; i < 3e7; i++)
                {
                    reader.WriteLine(rnd.Next((int)-1e5, (int)1e5));
                }
            }
        }

        static async void CountEqualAsync(DataBase db, int order)
        {
            //синхронное выполнение
            Console.WriteLine("Введите число");
            string request = Console.ReadLine();
            int number = ReadInt();

            Console.WriteLine("Выполнение команды началось...");

            //асинхронное выполнение
            var result = await Task.Run(() => db.NumberOfEqual(number));

            //снова синхронное
            Console.Write($"***Результат команды №{order}: ");
            Console.Write(result + "\n");
        }
        static async void SumOnSegmentAsync(DataBase db, int order)
        {
            //синхронное выполнение
            Console.WriteLine("Введите левую границу интервала");
            int L = ReadInt();

            Console.WriteLine("Введите правую границу интервала");
            int R = ReadInt();

            Console.WriteLine("Выполнение команды началось...");

            //асинхронное выполнение
            var result = await Task.Run(() => db.SumOnSegment(L, R));

            //снова синхронное
            Console.Write($"***Результат команды №{order}: ");
            Console.Write(result + "\n");
        }

        static async void ChangeValueAsync(DataBase db, int order)
        {
            //синхронное выполнение
            Console.WriteLine("Введите левую границу интервала");
            int L = ReadInt();

            Console.WriteLine("Введите правую границу интервала");
            int R = ReadInt();

            Console.WriteLine("Введите разницу между итоговым и начальным значением");
            int delta = ReadInt();

            Console.WriteLine("Выполнение команды началось...");

            //асинхронное выполнение
            await Task.Run(() => db.ChangeValue(delta, L, R));

            //снова синхронное
            Console.Write($"***Команда №{order} завершена");
        }

        static async void ReadOnSegment(DataBase db, int order)
        {
            //синхронное выполнение
            Console.WriteLine("Введите левую границу интервала");
            int L = ReadInt();

            Console.WriteLine("Введите правую границу интервала");
            int R = ReadInt();

            Console.WriteLine("Выполнение команды началось...");

            //асинхронное выполнение
            var result = await Task.Run(() => db.ReadOnSegment(L, R));

            //снова синхронное
            Console.Write($"***Результат команды №{order}:\n***\n");
            foreach (var x in result)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n***\n");
        }

        static async void WriteToFile(DataBase db, int order)
        {
            //синхронное выполнение
            Console.WriteLine("Введите левую границу интервала");
            int L = ReadInt();

            Console.WriteLine("Введите правую границу интервала");
            int R = ReadInt();

            Console.WriteLine("Выполнение команды началось...");

            using (StreamWriter writer = new StreamWriter(@"../../../dates.txt"))
            {
                //writer.WriteAsync();
            }

            //TODO: Асинхронно записать в файл значения с интервала 
            //Hint: использование встроенных WriteAsync...

            //возможно это лучше оставить в качестве примера, а предыдущую -- дать на TODO.. Пусть встанут на грабли... 
            //мне вообще не нравится, да
        }

        static void Main(string[] args)
        {
            CreateFile();
            DataBase db = new DataBase(@"../../../dates.txt");

            Console.WriteLine("Доступные команды:" +

                              "\r\n 0 L R -- Вывести числа на интервале" +
                              "\r\n 1 N -- Посчитать количество чисел в БД, равных N" +
                              "\r\n 2 L R -- Посчитать сумму чисел на интервале" +
                              "\r\n 3 L R Delta -- изменить значения на интервале на дельту.");
            int index = 0;
            do
            {
                Console.WriteLine("Введите команду:");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "0":
                        {
                            ReadOnSegment(db, ++index);
                            break;
                        }
                    case "1":
                        {
                            CountEqualAsync(db, ++index);
                            break;
                        }

                    case "2":
                        {
                            SumOnSegmentAsync(db, ++index);
                            break;
                        }
                    case "3":
                        {
                            ChangeValueAsync(db, ++index);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Некорректный номер команды");
                            break;
                        }
                }

                Console.WriteLine("Для ввода дополнительных комманд нажмите любую клавишу");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}


