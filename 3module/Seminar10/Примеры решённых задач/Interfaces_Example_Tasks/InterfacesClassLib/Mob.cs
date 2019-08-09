using System; 
namespace InterfacesClassLib
{
    /// <summary>
    /// Класс моба
    /// </summary>
    public abstract class Mob
    {
        /// <summary>
        /// Количество очков здоровья моба
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// Сила атаки моба
        /// </summary>
        public int Attack { get; set; }
        /// <summary>
        /// Конструктор для создания моба
        /// </summary>
        /// <param name="hp">Количество очков здоровья моба</param>
        /// <param name="attack">Сила атаки моба</param>
        protected Mob(int hp, int attack)
        {
            HP = hp;
            Attack = attack;
        }
        /// <summary>
        /// Метод для атаки мобом другого моба
        /// </summary>
        /// <param name="other">Экземпляр другого моба</param>
        public void AttackMob(Mob other)
        {
            Console.WriteLine($"{ToString()} attacked {other.ToString()} ");
            while (HP > 0 | other.HP > 0)
            {
                HP -= other.Attack;
                other.HP -= Attack;
                if (HP <= 0 | other.HP <= 0) break;
            }
        }
    }
}
