namespace Fractions
{
    /// <summary>
    /// класс Скеллиге
    /// </summary>
    public class Skellige : Deck
    {
        /// <summary>
        /// Сила способности колоды
        /// </summary>
        int deathGloryForce;
        /// <summary>
        /// Количество медиков в колоде
        /// </summary>
        int amountOfMedics;

        /// <summary>
        /// Конструктор для создания экземпляра колоды Скеллиге
        /// </summary>
        /// <param name="amountOfGoldenCards">Количество золотых карт</param>
        /// <param name="amountOfSilverCards">Количество серебряных карт</param>
        /// <param name="amountOfBronzeCards">Количество бронзовых карт</param>
        /// <param name="leaderName">Имя лидера</param>
        /// <param name="leaderStrength">Сила лидера</param>
        /// <param name="deathGloryForce">Сила способности колоды</param>
        /// <param name="amountOfMedics">Количество медиков в колоде</param>
        public Skellige(int amountOfGoldenCards, int amountOfSilverCards, int amountOfBronzeCards, string leaderName, int leaderStrength, int deathGloryForce, int amountOfMedics) : 
            base(amountOfGoldenCards, amountOfSilverCards, amountOfBronzeCards, leaderName, leaderStrength)
        {
            this.DeathGloryForce = deathGloryForce;
            this.AmountOfMedics = amountOfMedics;
        }

        /// <summary>
        /// Свойство доступа к силе способности колоды
        /// </summary>
        public int DeathGloryForce { get => deathGloryForce; set => deathGloryForce = value; }
        /// <summary>
        /// Свойство доступа к количеству медиков
        /// </summary>
        public int AmountOfMedics { get => amountOfMedics; set => amountOfMedics = value; }

        /// <summary>
        /// Метод для определения вероятности выигрыша партии
        /// </summary>
        /// <returns></returns>
        public virtual double ProbabilityToWinTheGame()
        {
            int length = (AmountOfCards * deathGloryForce * amountOfMedics).ToString().Length + 1;
            int powTen = 1;
            while (length != 0)
            {
                powTen *= 10;
                length--;
            }
            return AmountOfCards * deathGloryForce * amountOfMedics / (double)powTen * 100;
        }

        /// <summary>
        /// Цитата фракции
        /// </summary>
        public override string Quote { get => "Skellige!"; }

        /// <summary>
        /// Метод для вывода информации о колоде
        /// </summary>
        public override string ToString() => base.ToString() + $"\nDeath glory force: {deathGloryForce}\nAmount of medics: {amountOfMedics}";
    }
}
