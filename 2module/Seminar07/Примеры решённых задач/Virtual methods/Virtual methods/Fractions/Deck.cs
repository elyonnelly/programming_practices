using System;

namespace Fractions
{
    /// <summary>
    /// Класс колоды
    /// </summary>
    public class Deck 
    {
        static Random random = new Random();

        /// <summary>
        /// Количество золотых карт
        /// </summary>
        public int AmountOfGoldenCards { get; private set; }
        /// <summary>
        /// Количество серебряных карт
        /// </summary>
        public int AmountOfSilverCards { get; private set; }
        /// <summary>
        /// Количество бронзовых карт
        /// </summary>
        public int AmountOfBronzeCards { get; private set; }
        /// <summary>
        /// Сила лидера колоды
        /// </summary>
        public int LeaderStrength { get; private set; }
        /// <summary>
        /// Имя лидера колоды
        /// </summary>
        public string LeaderName { get; private set; }

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
            this.LeaderStrength = leaderStrength;
        }

        /// <summary>
        /// Свойство для определения количества карт в колоде
        /// </summary>
        public int AmountOfCards { get => AmountOfGoldenCards + AmountOfSilverCards + AmountOfBronzeCards + 1; }

        /// <summary>
        /// Метод для определения вероятности выигрыша партии
        /// </summary>
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
        public override string ToString() => $"Leader name: {LeaderName}\n" +
                                             $"Leader strength: {LeaderStrength}\n" +
                                             $"Amount of golden cards: {AmountOfGoldenCards}\n" +
                                             $"Amount of silver cards: {AmountOfSilverCards}\n" +
                                             $"Amount of bronze cards: {AmountOfBronzeCards}\n" +
                                             $"Total amount of cards: {AmountOfCards}";
    }
}
