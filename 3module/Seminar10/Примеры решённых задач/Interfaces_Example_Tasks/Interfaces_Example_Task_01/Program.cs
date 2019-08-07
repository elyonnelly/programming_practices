/* Смоделируйте игру Sonic в виде консольного приложения. 
 * Для этого в отдельной библиотеке классов определите:
 * I. Класс Mob, содержащий:
 * • Свойства/поля: 
 * 1) Количество очков здоровья моба (HP);
 * 2) Сила атаки моба (attack).
 * • Метод для атаки мобом другого моба AttackMob, выводящий информацию о том, что какой-то из мобов был
 *  атакован другим. Атака продолжается до тех пор, пока здоровье одного из мобов не станет <= 0.
 *  • Защишенный конструктор из двух параметров.
 *  II. Класс Hero – наследник класса Mob, содержащий:
 *  • Метод для вывода информации о герое (переопределить ToString).
 *  III. Интерфейс IMonsterAttack, содержащий:
 *  • Метод для атаки монстром героя с двумя параметрами: экземпляр героя и позиция героя.
 *  IV. Класс Monster – наследник класса Mob, содержащий:
 *  • Свойство/поле расположения монстра (position).
 *  • Конструктор из трех параметров.
 *  • Метод для вывода информации о монстре (переопределить ToString).
 *  • Реализовать интерфейс IMonsterAttack путем реализации метода AttackHero, в котором, если позиция 
 *    монстра равна позиции героя, выводить сообщение о том, что Соник встретил монстра на такой-то позиции,
 *    и атаковать героя (с помощью метода AttackMob).
 *  • Метод для вывода информации о монстре (переопределить ToString).
 *  V. Класс Boss – наследник класса Mob, содержащий:
 *  • Метод для вывода информации о боссе (переопределить ToString).
 *  VI. Класс Game для осуществления основного игрового процесса, содержащий:
 *  • Свойства/поля:
 *  1) Расположение финальной зоны (final zone position);
 *  2) Количество монстров на уровне (amount of monsters);
 *  3) Экземпляр героя (hero);
 *  4) Экземпляр босса (boss).
 *  • Конструктор из четырех параметров.
 *  • Событие атаки героя монстром на определенной позиции OnAttackHeroOnPosition и соответствующий делегат
 *    AttackHeroOnPosition.
 *  • Метод моделирования игрового процесса Play, в котором происходит событие OnAttackHeroOnPosition на
 *    каждой итерации цикла, пока персонаж не достигнет Final Zone. Если в течении этого времени количество
 *    очков здоровья становится меньше или равным 0, выводить на экран надпись: "You Lose! Game over!". Дойдя
 *    до финальной зоны персонаж начинает атаковать босса путем вызова метода AttackMob. Если после этого 
 *    количество очков здоровье становится меньше или равным нуля, выводить на экран надпись: "You Lose! Game over!",
 *    иначе выводить: "You win!".
 *    
 *  В основной программе считать необходимые данные и создать экземпляр класса Game. Количество очков здоровья
 *  и силу атаки монстра генерировать случайным образом в заданных границах. Подписать всех монстров
 *  на событие OnAttackHeroOnPosition. Запустить игровой процесс. Предусмотреть возможность повторения игры. */
using InterfacesClassLib;
using System;

namespace Interfaces_Example_Task_01
{
    class Program
    {
        /// <summary>
        /// Генератор псевдослучайных чисел
        /// </summary>
        static Random rand = new Random();
        /// <summary>
        /// Метод для ввода целочисленных переменных, значение которых не ограничено другими
        /// </summary>
        /// <param name="description">Описание переменной</param>
        /// <param name="parameter">Переменная</param>
        static void Input(string description, out int parameter)
        {
            do Console.WriteLine(description);
            while (!int.TryParse(Console.ReadLine(), out parameter) || parameter <= 0);
        }
        /// <summary>
        /// Метод для ввода целочисленных переменных, значение которых ограничено другими
        /// </summary>
        /// <param name="description">Описание переменной</param>
        /// <param name="parameter">Переменная</param>
        /// <param name="lowerBound">Нижняя граница переменной</param>
        static void InputInBounds(string description, out int parameter, int lowerBound)
        {
            do Console.WriteLine(description);
            while (!int.TryParse(Console.ReadLine(), out parameter) || parameter <= lowerBound);
        }
        /// <summary>
        /// Метод для генерации игры
        /// </summary>
        /// <param name="game">Экземпляр класса игры</param>
        static void GenerateGame(out Game game)
        {
            int amountOfMonsters, finalZonePosition, SonicHP, SonicAttack, bossHP, bossAttack,
                dMonsterAttack, uMonsterAttack, dMonsterHP, uMonsterHP;
            Input("Enter amount of monsters (>0): ", out amountOfMonsters);
            Input("Enter final zone position (>0): ", out finalZonePosition);
            Input("Enter Sonic HP (>0): ", out SonicHP);
            Input("Enter Sonic attack (>0): ", out SonicAttack);
            Input("Enter boss HP (>0): ", out bossHP);
            Input("Enter boss attack (>0): ", out bossAttack);
            Input("Enter lower bound of monster attack (>0): ", out dMonsterAttack);
            InputInBounds($"Enter upper bound of monster attack (>{dMonsterAttack}): ",
                          out uMonsterAttack, dMonsterAttack);
            Input("Enter lower bound of monster HP (>0): ", out dMonsterHP);
            InputInBounds($"Enter upper bound of monster HP (>{dMonsterHP}): ",
                          out uMonsterHP, dMonsterHP);
            game = new Game(finalZonePosition, amountOfMonsters, new Hero(SonicHP, SonicAttack),
                        new Boss(bossHP, bossAttack));
            for (int i = 0; i < amountOfMonsters; i++)
            {
                Monster monster = new Monster(rand.Next(dMonsterHP, uMonsterHP + 1),
                    rand.Next(dMonsterAttack, uMonsterAttack + 1), rand.Next(0, finalZonePosition));
                game.OnAttackHeroOnPosition += monster.AttackHero;
            }
        }
        static void Main(string[] args)
        {
            Game game;
            do
            {
                GenerateGame(out game);
                game.Play();
                Console.WriteLine("Press ESC to stop playing or any other key to continue.\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
