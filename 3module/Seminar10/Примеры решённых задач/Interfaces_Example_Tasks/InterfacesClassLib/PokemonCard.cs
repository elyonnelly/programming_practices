using System;
using System.Collections;

namespace InterfacesClassLib
{
    /// <summary>
    /// Класс карты из игры Pokemon TCG
    /// </summary>
    public class PokemonCard : IComparable
    {
        /// <summary>
        /// Конструктор для создания экземпляра карты из игры Pokemon TCG
        /// </summary>
        /// <param name="name">Название карты (имя покемона)</param>
        /// <param name="hp">Количество очков здоровья</param>
        /// <param name="attackPower">Сила атаки карты </param>
        public PokemonCard(string name, int hp, int attackPower)
        {
            Name = name;
            HP = hp;
            AttackPower = attackPower;
        }
        /// <summary>
        /// Название карты (имя покемона)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Количество очков здоровья
        /// </summary> 
        public int HP { get; set; }
        /// <summary>
        /// Сила атаки карты 
        /// </summary>
        public int AttackPower { get; set; }
        /// <summary>
        /// Метод для сравнения двух карт по возрастанию количества очков здоровья
        /// </summary>
        /// <param name="anotherCard"></param>
        /// <returns></returns>
        public int CompareTo(object anotherCard) => this.HP.CompareTo((anotherCard as PokemonCard).HP);
        /// <summary>
        ///  Метод, возвращающий объект типа IComparer для сортировки по возрастанию силы атаки
        /// </summary>
        /// <returns></returns>
        public static IComparer SortByAscendingAttackPower() =>
            new PokemonCardSortByAscendingAttackPowerHelper();
        /// <summary>
        /// Метод, возвращающий объект типа IComparer для сортировки по убыванию силы атаки
        /// </summary>
        /// <returns></returns>
        public static IComparer SortByDescendingAttackPower() =>
            new PokemonCardSortByDescendingAttackPowerHelper();
        /// <summary>
        /// Метод, возвращающий объект типа IComparer для сортировки по убыванию количества очков здоровья
        /// </summary>
        /// <returns></returns>
        public static IComparer SortByDescendingHP() => new PokemonCardSortByDescendingHPHelper();
        /// <summary>
        /// Метод для приведения object к PokemonCard
        /// </summary>
        /// <param name="firstCard">Первая карта</param>
        /// <param name="secondCard">Вторая карта</param>
        /// <returns></returns>
        internal static (PokemonCard, PokemonCard) CastObjectsToPokemonCards(object firstCard, object secondCard) =>
            (firstCard as PokemonCard, secondCard as PokemonCard);
        /// <summary>
        /// Вспомогательный класс для сортировки по убыванию силы атаки
        /// </summary>
        private class PokemonCardSortByDescendingAttackPowerHelper : IComparer
        {
            public int Compare(object firstCard, object secondCard)
            {
                (PokemonCard card, PokemonCard anotherCard) cards = CastObjectsToPokemonCards(firstCard, secondCard);
                return cards.card.AttackPower == cards.anotherCard.AttackPower ? 0 :
                   cards.card.AttackPower < cards.anotherCard.AttackPower ? 1 : -1;
            }
        }
        /// <summary>
        /// Вспомогательный класс для сортировки по возрастанию силы атаки
        /// </summary>
        private class PokemonCardSortByAscendingAttackPowerHelper : IComparer
        {
            public int Compare(object firstCard, object secondCard)
            {
                (PokemonCard card, PokemonCard anotherCard) cards = CastObjectsToPokemonCards(firstCard, secondCard);
                return cards.card.AttackPower == cards.anotherCard.AttackPower ? 0 :
                   cards.card.AttackPower > cards.anotherCard.AttackPower ? 1 : -1;
            }
        }
        /// <summary>
        /// Вспомогательный класс для сортировки по убыванию количества очков здоровья
        /// </summary>
        private class PokemonCardSortByDescendingHPHelper : IComparer
        {
            public int Compare(object firstCard, object secondCard)
            {
                (PokemonCard card, PokemonCard anotherCard) cards = CastObjectsToPokemonCards(firstCard, secondCard);
                return cards.card.HP == cards.anotherCard.HP ? 0 : cards.card.HP < cards.anotherCard.HP ? 1 : -1;
            }
        }
        /// <summary>
        /// Метод для вывода информации о карте
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Name} card with {HP}HP and {AttackPower} attack power.";
    }
}