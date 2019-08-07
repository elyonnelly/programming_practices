namespace InterfacesClassLib
{
    /// <summary>
    /// Класс героя
    /// </summary>
    public class Hero : Mob
    {
        /// <summary>
        /// Конструктор для создания экземпляра героя
        /// </summary>
        /// <param name="hp">Количество очков здоровья героя</param>
        /// <param name="attack">Сила атаки героя</param>
        public Hero(int hp, int attack) : base(hp, attack)
        {
        }
        /// <summary>
        /// Вывод информации о герое
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Sonic with HP = {HP} and attack = {Attack}";
    }
}
