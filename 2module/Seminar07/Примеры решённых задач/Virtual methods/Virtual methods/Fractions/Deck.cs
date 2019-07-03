using System;

namespace Fractions
{
    /// <summary>
    /// Класс колода
    /// </summary>
    public class Deck 
    {
        static Random random = new Random();
        /// <summary>
        /// Количество золотых карт
        /// </summary>
        int amountOfGoldenCards;
        /// <summary>
        /// Количество серебряных карт
        /// </summary>
        int amountOfSilverCards;
        /// <summary>
        /// оличество бронзовых карт
        /// </summary>
        int amountOfBronzeCards;
        /// <summary>
        /// Сила лидера
        /// </summary>
        int leaderStrength;
        /// <summary>
        /// Имя лидера
        /// </summary>
        string leaderName;

        /// <summary>
        /// Конструктор для создания экземпляра колоды
        /// </summary>
        /// <param name="amountOfGoldenCards">Количество золотых карт</param>
        /// <param name="amountOfSilverCards">Количество серебряных карт</param>
        /// <param name="amountOfBronzeCards">Количество бронзовых карт</param>
        /// <param name="leaderName">Имя лидера</param>
        /// <param name="leaderStrength">Сила лидера</param>
        public Deck(int amountOfGoldenCards, int amountOfSilverCards, int amountOfBronzeCards, string leaderName, int leaderStrength)
        {
            this.AmountOfGoldenCards = amountOfGoldenCards;
            this.AmountOfSilverCards = amountOfSilverCards;
            this.AmountOfBronzeCards = amountOfBronzeCards;
            this.LeaderName = leaderName;
            this.leaderStrength = leaderStrength;
        }

        /// <summary>
        /// Сврйство доступа к количеству золотых карт
        /// </summary>
        public int AmountOfGoldenCards { get => amountOfGoldenCards; set => amountOfGoldenCards = value; }
        /// <summary>
        /// Сврйство доступа к количеству серебряных карт
        /// </summary>
        public int AmountOfSilverCards { get => amountOfSilverCards; set => amountOfSilverCards = value; }
        /// <summary>
        /// Сврйство доступа к количеству бронзовых карт
        /// </summary>
        public int AmountOfBronzeCards { get => amountOfBronzeCards; set => amountOfBronzeCards = value; }
        /// <summary>
        /// Свойство доступа к полю силы лидера
        /// </summary>
        public int LeaderStrength { get => leaderStrength; set => leaderStrength = value; }
        /// <summary>
        /// Свойство доступа к полю имени лидера
        /// </summary>
        public string LeaderName { get => leaderName; set => leaderName = value; }

        /// <summary>
        /// Свойство для определения количества карт в колоде
        /// </summary>
        public int AmountOfCards { get => amountOfGoldenCards + amountOfSilverCards + amountOfBronzeCards + 1; }

        /// <summary>
        /// Метод для определения вероятности выигрыша партии
        /// </summary>0
        /// <returns></returns>
        public virtual double ProbabilityToWinTheGame()
        {
            return random.NextDouble() * 100;
        }

        /// <summary>
        /// Цитата колоды
        /// </summary>
        public virtual string Quote { get => "No passage!"; }

        /// <summary>
        /// Метод для вывода информации о колоде
        /// </summary>
        public override string ToString() => $"Leader name: {leaderName}\n" +
                                             $"Leader strength: {leaderStrength}\n" +
                                             $"Amount of golden cards: {amountOfGoldenCards}\n" +
                                             $"Amount of silver cards: {amountOfSilverCards}\n" +
                                             $"Amount of bronze cards: {amountOfBronzeCards}\n" +
                                             $"Total amount of cards: {AmountOfCards}";
    }
}
