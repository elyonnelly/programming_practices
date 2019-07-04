using System;

namespace Seminar2_7_TODO
{  /*
    Здравствуйте, дорогие любители природы. Это программа "В мире животных" 
    и сегодня мы узнаем, в каких отношениях состоят разные виды млекопитающих друг с другом.
    Вооружитесь Википедией, и мы начинаем.

    Реализуйте цепочку наследований: 
    1) Animal -- базовый абстрактный класс с абстрактным же методом
    Movement и абстрактное свойство Habitat.
    2) От него унаследуйте класс Laurasiatheria. Общий предок всех животных, входящих в надотряд Лавразиате́рии,
    жил на суше, разумно переопределите члены базового класса.
    3) От класса Laurasiatheria унаследуйте класс Рукокрылые, притом метод Movement и свойство Habitat
    необходимо объявить с модификаторами new virtual.
    4) От Рукокрылых отнаследуйтесь с методами Летучая Мышь и Крылан, переопределив методы привычным образом.
    5) От класса Laurasiatheria унаследуйте класс Китопарнокопытные 
    6) И от последнего -- Киты, Бегемоты и Олени. Разумно переопределите свойства. (у Кита -- new virtual)
    7) отнаследуйтесь от Китов, создав классы Кашалота и Нарвала.

    А теперь создайте объекты самого базового класса, инициализируя их теми или иными ссылками 
    производных классов. 
    И посмотрите, что будет, если изменять модификаторы членов классов. 
    
    */

    /// <summary>
    /// Самое первое животное на земле
    /// </summary>
    public class Animal
    {
        public virtual string Movement() => "Я живу где-то в мировом океане. ";
        public virtual string Habitat { get => "Я не передвигаюсь, я похожа на губочку. "; }
    }

    /// <summary>
    /// Лавразиате́рии — надотряд плацентарных млекопитающих
    /// </summary>
    public class Laurasiatheria : Animal
    {
        public override string Movement() => "Я передвигаюсь на четырех лапках. ";
        public override string Habitat { get => "Я живу на суше."; }
    }

    /*
     TODO создайте класс Chiroptera, наследника Laurasiatheria, добавив наследуемые методы 
     с модификаторами new virtual.
     Мы прерываем цепочку наследования, поскольку потомки рукокрылых не могут
     наследовать напрямую свойства его потомков, они пошли по другому пути эволюции и начали летать
     new virtual именно за этим и используется -- чтобы прервать цепочку наследования и начать новую,
     чтобы новые животные не могли использовать base() его предков
     */

    //TODO добавьте классы Pteropodidae, Microchiroptera, переопределите их метод ToString()


    /// <summary>
    /// Китопарнокопытные (да, они находятся в более близком родстве, чем с другими животными)
    /// </summary>
    public class Cetartiodactyla : Laurasiatheria
    {
        public override string ToString()
        {
            return Movement() + Habitat + "Я из клады Китопарнокопытных. Все животные этого класса -- потомки пакицета, " +
                   "прародитель китов, бегемотиков и оленей.";
        }
    }

    /// <summary>
    /// Киты
    /// </summary>
    public class Whale : Cetartiodactyla
    {
        //аналогично произошло с китами, они начали плавать, в отличие от его предков.
        public new virtual string Movement() => "Я передвигаюсь c помощью плавников. ";
        public new virtual string Habitat { get => "Я живу в воде в океанах по всему миру."; }

        public override string ToString()
        {
            return Movement() + Habitat;
        }

    }

    /// <summary>
    /// Бегемоты
    /// </summary>
    public class Hippopotamus : Cetartiodactyla
    {
        public override string ToString()
        {
            return Movement() + Habitat + "Я живу в Африке. Я бегемот. ";
        }
    }

    //добавьте класс Deer (они потомки Cetartiodactyla!) и переопределите его свойство Habitat и ToString() 


    /// <summary>
    /// Кашалоты
    /// </summary>
    public class Cachalot : Whale
    {

        //TODO попробуйте использовать методы классов предков, base.Habitat и base.base.Habitat
        public override string ToString()
        {
            return Movement() + Habitat + "Я кашалот. ";
        }

    }

    //TODO добавьте класс Narwhal, переопределите его методы Habitat (он живет только в Арктике) и ToString()


    class Program
    {


        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Cetartiodactyla(),
                new Whale(),
                new Narwhal(),
                new Cachalot(),
                new Deer(),
                new Hippopotamus(),
                new Microchiroptera(),
                new Pteropodidae()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }


            Cetartiodactyla[] cetartiodactylas =
            {
                new Whale(),
                new Hippopotamus(),
                new Deer(),
                new Narwhal()
            };

            Console.WriteLine();

            foreach (var cetartiodactyl in cetartiodactylas)
            {
                Console.WriteLine(cetartiodactyl);
            }
        }
    }
}
