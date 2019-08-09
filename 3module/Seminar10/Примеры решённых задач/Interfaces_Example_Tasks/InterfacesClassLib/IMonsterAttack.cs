namespace InterfacesClassLib
{
    /* NOTE: Интерфейс особенно необходим, к примеру, если далее дополнить программу другими типами врагов – 
     * наследников класса Mob, которым также нужен метод AttackHero, а также реализовать некоторый другой 
     * новый общий функционал. */
    /// <summary>
    /// Интерфейс атаки монстра.
    /// </summary>
    interface IMonsterAttack
    {
        /// <summary>
        /// Метод для атаки монстром героя
        /// </summary>
        /// <param name="hero">Экземпляр героя</param>
        /// <param name="position">Позиция монстра</param>
        void AttackHero(Mob hero, int position);
    }
}
