/* Представим, что мы вернулись в двухтысячные и все снова коллекционируют карты для игры в Pokemon Trading Card Game. 
 * Собрав достаточное количество карт, чтобы не запутаться и ничего не потерять, будем вести их учет с возможностью сортировки
 * карт по некоторым параметрам. Для этого в библиотеке классов необходимо определить класс PokemonCard, реализующий интерфейс
 * IComparable и содержащий:
 * • Поля/свойства: 
 * 1) Название карты(Name);
 * 2) Количество очков здоровья(HP);
 * 3) Сила атаки покемона(AttackPower). 
 * • Реализацию метода CompareTo интерфейса IComparable, для сортировки карт по возрастанию количества очков здоровья.
 * • Методы:
 * 1) SortByAscendingAttackPower, для сортировки карт по возрастанию силы атаки;
 * 2) SortByDescendingAttackPower, для сортировки карт по убыванию силы атаки;
 * 3) SortByDescendingHP, для сортировки карт по убыванию количества очков здоровья;
 * Значения методов возвращать с помощью вспомогательных классов, реализующих интерфейс IComparer.
 * 
 * В основной программе создать массив карт, вывести информацию о них. Затем отсортировать карты по возрастанию силы атаки
 * и по убыванию количества очков здоровья, снова вывести массив. */
using InterfacesClassLib;
using System;

namespace Interfaces_Example_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonCard[] pokemonCards = new PokemonCard[]
            {
                new PokemonCard("Pikachu", 60, 20),
                new PokemonCard("Raichu", 90, 120),
                new PokemonCard("Flareon", 90, 60),
                new PokemonCard("Parasect", 110, 80)
            };
            foreach (var card in pokemonCards)
                Console.WriteLine(card);
            Array.Sort(pokemonCards, PokemonCard.SortByAscendingAttackPower());
            Array.Sort(pokemonCards, PokemonCard.SortByDescendingHP());
            Console.WriteLine("\nSorted by ascending attack power and by descending HP array:");
            foreach (var card in pokemonCards)
                Console.WriteLine(card);
            Console.ReadKey();
        }
    }
}
