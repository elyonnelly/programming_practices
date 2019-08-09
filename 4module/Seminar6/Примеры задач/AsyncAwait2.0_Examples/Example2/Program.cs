using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Parallel linq!
 *
 * Пусть у нас есть большой список городов.
 * Будем обрабатывать список параллельно для быстроты работы.
 * Покажем использование различных методов для конструирования параллельных запросов
 */

namespace Example2
{
    class City
    {
        public string Name { get; }
        public int Population { get; }

        public double AverageTemperature { get; }

        public bool Livable { get; set; }

        public City()
        {
            int len = rnd.Next(10);
            string name = string.Empty;
            for (int i = 0; i < len; i++)
            {
                name += (char)rnd.Next('a', 'z' + 1);
            }
            
            Name = name;
            Population = rnd.Next(10000, 10000000);
            AverageTemperature = rnd.Next(-30, 30) + rnd.NextDouble();
        }

        private static readonly Random rnd = new Random();
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            for (int i = 0; i < 100000; i++)
            {
                cities.Add(new City());
            }

            /*
             * Следующий пример демонстрирует неупорядоченный параллельный запрос,
             * который отбирает все соответствующие условию элементы, не пытаясь упорядочивать
             * результаты.
             *
             * Этот запрос не всегда возвращает первые 1000 городов из исходной последовательности,
             * которые отвечают условию, а просто некоторый набор из 1000 подходящих городов.
             *
             * Результат имеет особый тип -- ParallelQuery<T>
             */

            ParallelQuery<City> cityQuery = (from city in cities.AsParallel()
                    where city.Population > 10000
                    select city)
                .Take(1000);

            /*
             * В следующем примере поведение по умолчанию переопределяется путем включения
             * оператора AsOrdered в исходную последовательность. Это гарантирует, что метод Take
             * всегда возвращает первые 1000 подходящих городов из исходной последовательности.
             *
             * Однако этот запрос, скорее всего, выполняется медленнее неупорядоченной версии,
             * так как он должен отслеживать исходный порядок во всех сегментах и контролировать его
             * во время слияния.
             */

            ParallelQuery<City> orderedCities = (from city in cities.AsParallel().AsOrdered()
                    where city.Population > 10000
                    select city)
                .Take(1000);

            /*
             * Если вы хотите продолжить выполнять некоторые запросы на основании старого
             * параллельного запроса -- вы можете применить операцию AsSequential, которая
             * навязывает последовательное выполнение.
             * Например, потому что ясно, что параллельное выполнение из-за перерасхода ресурсов
             * на выделение новых потоков только замедлит выполнение запроса.
             *
             * Обратите внимание, что у результата привычный тип Enumerable()
             */

            var cityEnumerable = from city in cityQuery.AsSequential()
                                 where city.AverageTemperature > 0
                                 select city;


            /*
             * Метод ForAll параллельно вызывает указанные действия для всех элементов
             * в последовательности.
             */
            var livableCities = from city in cities.AsParallel()
                where city.AverageTemperature > 0
                select city;

            livableCities.ForAll((city) =>
            {
                city.Livable = true;
            });
        }
    }
}
