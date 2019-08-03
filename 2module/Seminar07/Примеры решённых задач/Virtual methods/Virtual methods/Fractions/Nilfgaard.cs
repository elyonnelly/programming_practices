namespace Fractions
{
    /// <summary>
    /// Класс Нильфгаард
    /// </summary>
    public class Nilfgaard : Deck
    {
        /// <summary>
        /// Сила способности колоды
        /// </summary>
        public int DiplomacyForce { get; private set; }
        /// <summary>
        /// Уловка
        /// </summary>
        public string Subterfuge { get; private set; }

        /// <summary>
        /// Конструктор для создания экземпляра колоды Нильфгаарда
        /// </summary>
        /// <param name="amountOfGoldenCards">Количество золотых карт</param>
        /// <param name="amountOfSilverCards">Количество серебряных карт</param>
        /// <param name="amountOfBronzeCards">Количество бронзовых карт</param>
        /// <param name="leaderName">Имя лидера</param>
        /// <param name="leaderStrength">Сила лидера</param>
        /// <param name="diplomacyForce">Сила способности колоды</param>
        /// <param name="subterfuge">Уловка</param>
        public Nilfgaard(int amountOfGoldenCards, int amountOfSilverCards, int amountOfBronzeCards, string leaderName, 
                         int leaderStrength, int diplomacyForce, string subterfuge) : 
                         base(amountOfGoldenCards, amountOfSilverCards, amountOfBronzeCards, leaderName, leaderStrength)
        {
            this.DiplomacyForce = diplomacyForce;
            this.Subterfuge = subterfuge;
        }

        /// <summary>
        /// Метод для определения вероятности выигрыша партии
        /// </summary>
        /// <returns></returns>
        public virtual double ProbabilityToWinTheGame()
        {
            int length = (AmountOfCards * DiplomacyForce).ToString().Length;
            int powTen = 1;
            while (length != 0)
            {
                powTen *= 10;
                length--;
            }
            return AmountOfCards * DiplomacyForce / (double)powTen * 100;
        }

        /// <summary>
        /// Цитата фракции
        /// </summary>
        public virtual string Quote { get => "All roads lead to Nilfgaard!"; }

        /// <summary>
        /// Метод для вывода информации о колоде
        /// </summary>
        public override string ToString() => base.ToString() + $"\nDiplomacy force: {DiplomacyForce}\nSubterfuge: {Subterfuge}";
    }
}
