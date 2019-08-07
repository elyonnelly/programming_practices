using System;

namespace InterfacesClassLib
{
    /// <summary>
    /// Делегат для события атаки героя
    /// </summary>
    /// <param name="mob"></param>
    /// <param name="position"></param>
    public delegate void AttackHeroOnPosition(Mob mob, int position);
    /// <summary>
    /// Класс игры
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Расположение финальной зоны
        /// </summary>
        int FinalZonePosition { get; set; }
        /// <summary>
        /// Количество монстров
        /// </summary>
        int AmountOfMonsters { get; set; }
        /// <summary>
        /// Экземпляр героя
        /// </summary>
        public Hero Hero { get; set; }
        /// <summary>
        /// Экземпляр босса
        /// </summary>
        public Boss Boss { get; set; }
        /// <summary>
        /// Конструктор экземпляра игры
        /// </summary>
        /// <param name="finalZonePosition">Расположение финальной зоны</param>
        /// <param name="amountOfMonsters">Количество монстров</param>
        /// <param name="hero">Экземпляр героя</param>
        /// <param name="boss">Экземпляр босса</param>
        public Game(int finalZonePosition, int amountOfMonsters, Hero hero, Boss boss)
        {
            FinalZonePosition = finalZonePosition;
            AmountOfMonsters = amountOfMonsters;
            Hero = hero;
            Boss = boss;
        }
        /// <summary>
        /// Событие атаки героя
        /// </summary>
        public event AttackHeroOnPosition OnAttackHeroOnPosition;
        /// <summary>
        /// Метод игровых событий
        /// </summary>
        public void Play()
        {
            for (int i = 0; i < FinalZonePosition; i++)
            {
                OnAttackHeroOnPosition(Hero, i);
                if (Hero.HP <= 0)
                {
                    Console.WriteLine("You Lose! Game over!");
                    return;
                }
            }
            Hero.AttackMob(Boss);
            string gameResult = Hero.HP <= 0 ? "You Lose! Game over!" : "You win!";
            Console.WriteLine(gameResult);
        }
    }
}
