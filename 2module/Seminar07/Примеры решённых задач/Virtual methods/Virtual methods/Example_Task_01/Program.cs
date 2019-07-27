/* Создайте библиотеку классов Fractions, где определите три класса: 
 * 1) Класс колоды карт Deck 
 * 2) Унаследованный от Deck класс фракции Нильфгаард Nilfgaard 
 * 3) Унаследованный от Deck класс фракции Скеллиге Skellige
 * 
 * Члены класса Deck:
 * I. Поля или автореализуемые свойства:
 * 1) Количество карт каждого типа: amountOfGoldenCards, amountOfSilverCards, amountOfBronzeCards 
 * 2) Имя лидера колоды 
 * 3) Сила лидера колоды 
 * II. Свойства: 
 * 1) Количество карт в колоде (карта лидера не входит в количество карт других типов) 
 * 2) Виртуальная свойство: цитата колоды
 * III. Методы: 
 * 1) Виртуальный метод ProbabilityToWinTheGame(), вычисляющий вероятность выигрыша партии случайным образом в процентах. Вероятность – вещественное число. 
 * 2) Переопределенный метод ToString() для вывода информации о колоде, включая общее количество карт. 
 * 
 * Члены класса Nilfgaard:
 * I. Поля или автореализуемые свойства:
 * 1) Сила способности колоды
 * 2) Уловка (поле строкового типа)
 * II. Виртуальное свойство: цитата фракции
 * III. Методы:
 * 1) Переопределенный метод ProbabilityToWinTheGame(), вычисляющий вероятность выигрыша партии в зависимости от силы лидера и силы способности колоды.
 * 2) Переопределенный метод ToString() для вывода информации о колоде, включая общее количество карт. 
 * IV. Конструктор общего вида с семью параметрами
 *
 * Члены класса Skellige:
 * I. Поля или автореализуемые свойства:
 * 1) Сила способности колоды
 * 2) Количество медиков в колоде
 * II. Виртуальное свойство: цитата фракции
 * III. Методы:
 * 1) Переопределенный метод ProbabilityToWinTheGame(), вычисляющий вероятность выигрыша партии случайным образом в зависимости от силы лидера, 
 * силы способности колоды и количества медиков в колоде.
 * 2) Переопределенный метод ToString() для вывода информации о колоде, включая общее количество карт. 
 * IV. Конструктор общего вида с семью параметрами */

using System;
using Fractions;

namespace Example_Task_01
{
    class Program
    {
        /// <summary>
        /// Генератор псевдослучайных чисел
        /// </summary>
        static Random random = new Random();
        /// <summary>
        /// Метод для нахождения случайной буквы
        /// </summary>
        /// <param name="left">Левая граница диапазона</param>
        /// <param name="right">Правая граница диапазона</param>
        /// <returns></returns>
        public static char GetRandomLetter(char left, char right)
        {
            int Letter = random.Next((int)left, (int)right + 1);
            return (char)Letter;
        }
        /// <summary>
        /// Метод для нахождения рандомного слова
        /// </summary>
        /// <returns></returns>
        public static string GetRandomSubterfuge()
        {
            string Subterfuge = string.Empty;
            int length = random.Next(3, 11);
            for (int i = 0; i < length; i++)
            {
                if (i == 0) Subterfuge += GetRandomLetter('A', 'Z').ToString();
                else Subterfuge += GetRandomLetter('a', 'z').ToString();
            }
            return Subterfuge;
        }
        static void Main(string[] args)
        {
            // NOTE: Запустите программу несколько раз. 
            // Получив результаты, уберите из определения класса Nilfgaard модификаторы virtual и вновь запустите приложение. Объясните и исправьте ошибки.
            Deck deck = new Deck(5, 6, 14, "Brouver Hoog", 4);
            Console.WriteLine($"Deck info:\n{deck}");
            Console.WriteLine($"Probability to win the game: {deck.ProbabilityToWinTheGame():f2}%");
            Console.WriteLine(deck.Quote);
            deck = new Nilfgaard(4, 7, 16, "Jan Calveit", 5, 40, GetRandomSubterfuge());
            Console.WriteLine($"\nDeck info:\n{deck}");
            Console.WriteLine($"Probability to win the game on Nilfgaard: {deck.ProbabilityToWinTheGame():f2}%");
            Console.WriteLine(deck.Quote);
            deck = new Skellige(6, 6, 15, "Crach an Craite", 5, 12, 6);
            Console.WriteLine($"\nDeck info:\n{deck}");
            Console.WriteLine($"Probability to win the game on Skellige: {deck.ProbabilityToWinTheGame():f2}%");
            Console.WriteLine(deck.Quote);
            Console.ReadKey();
        }
    }
}
