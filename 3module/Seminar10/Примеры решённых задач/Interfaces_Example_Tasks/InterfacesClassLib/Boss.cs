namespace InterfacesClassLib
{
    /// <summary>
    /// Класс босса
    /// </summary>
    public class Boss : Mob
    {
        /// <summary>
        /// Конструктор для создания экземпляра класса босса
        /// </summary>
        /// <param name="hp">Количество очков здоровья босса</param>
        /// <param name="attack">Сила атаки босса</param>
        public Boss(int hp, int attack) : base(hp, attack)
        {
        }
        /// <summary>
        /// Вывод информации о боссе
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Boss with HP = {HP} and attack = {Attack}";
    }
}
