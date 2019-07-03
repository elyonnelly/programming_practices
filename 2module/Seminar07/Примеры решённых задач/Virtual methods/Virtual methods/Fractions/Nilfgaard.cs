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
        int diplomacyForce;
        /// <summary>
        /// Уловка
        /// </summary>
        string subterfuge;
        /// <summary>
        /// Свойство доступа к полю силы способности колоды
        /// </summary>
        public int DiplomacyForce { get => diplomacyForce; set => diplomacyForce = value; }
        /// <summary>
        /// Свойство доступа к полю уловки
        /// </summary>
        public string Subterfuge { get => subterfuge; set => subterfuge = value; }

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
        public Nilfgaard(int amountOfGoldenCards, int amountOfSilverCards, int amountOfBronzeCards, string leaderName, int leaderStrength, int diplomacyForce, string subterfuge) : 
            base(amountOfGoldenCards, amountOfSilverCards, amountOfBronzeCards, leaderName, leaderStrength)
        {
            this.DiplomacyForce = diplomacyForce;
            this.Subterfuge = subterfuge;
        }

        /// <summary>
        /// Метод для определения вероятности выигрыша партии
        /// </summary>
        /// <returns></returns>
        public override double ProbabilityToWinTheGame()
        {
            int length = (AmountOfCards * diplomacyForce).ToString().Length;
            int powTen = 1;
            while (length != 0)
            {
                powTen *= 10;
                length--;
            }
            return AmountOfCards * diplomacyForce / (double)powTen * 100;
        }

        /// <summary>
        /// Цитата фракции
        /// </summary>
        public virtual string Quote { get => "All roads lead to Nilfgaard!"; }

        /// <summary>
        /// Метод для вывода информации о колоде
        /// </summary>
        public override string ToString() => base.ToString() + $"\nDiplomacy force: {diplomacyForce}\nSubterfuge: {subterfuge}";
    }
}
