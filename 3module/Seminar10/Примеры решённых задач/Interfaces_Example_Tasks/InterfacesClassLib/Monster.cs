using System; 

namespace InterfacesClassLib
{
    /* NOTE: Интерфейсы позволяют реализовать так называемое "множественное" наследование. */
    /// <summary>
    /// Класс монстра
    /// </summary>
    public class Monster : Mob, IMonsterAttack
    {
        /// <summary>
        /// Расположение монстра
        /// </summary>
        int Position { get; set; }
        /// <summary>
        /// Конструктор для создания экземпляра монстра
        /// </summary>
        /// <param name="hp">Количество очков здоровья монстра</param>
        /// <param name="attack">Сила атаки монстра</param>
        public Monster(int hP, int attack, int position) : base(hP, attack)
        {
            Position = position;
        }
        /// <summary>
        /// Метод для атаки монстром героя
        /// </summary>
        /// <param name="hero">Экземпляр героя</param>
        /// <param name="position">Позиция монстра</param>
        public void AttackHero(Mob hero, int position)
        {
            if (Position == position)
            {
                Console.WriteLine($"Sonic meet monster on {Position}");
                AttackMob(hero);
            }
        }
        /// <summary>
        /// Вывод информации о монстре
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Monster with HP = {HP} and attack = {Attack}";
    }
}
