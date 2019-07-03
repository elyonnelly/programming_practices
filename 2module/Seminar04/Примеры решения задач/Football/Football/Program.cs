using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    /*
     Написать программу, которая симулирует игру в футбол
     Создать класс Player, с полями int Force - сила удара и int side - сторона
     игрока на поле (первая команда, или вторая) и определенным методом
     void Push(ref int), который изменяет координату мяча от удара(изменение на силу удара)
     с учетом стороны игрока

     Определить класс RedPlayer, который наследуется от Player и имеет side = 1
     Определить класс BluePlayer, который наследуется от Player и имеет side = -1

     Создать статический метод метод void Randomise(ref Player[]),
     который перемешивает все объекты в массиве.
     
     В основной программе создать Player[] players, размером 22, в первых
     11 ячейках записаны объекты типа RedPlayer, в оставшихся BluePlayer
     (сила удара - случайное число в диапазоне [0,50)). После создания массива
     перемешать объекты в нем. Мяч находится в середине поля (начальная координата равна 0)
     Каждый игрок пинает мяч. Когда мяч находится в пределах (-inf;-100]U[100;inf), то
     считается, что гол забит и игра заканчивается. Необходимо вывести "Blue wins", "Red wins"
     или "Draw".
     Организовать повтор решения
         */
    class Program
    {
        static Random rnd = new Random();

        static void Randomise(ref Player[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                Player tmp = players[i];
                int num = rnd.Next(players.Length);
                players[i] = players[num];
                players[num] = tmp;
            }
        }

        static void Main(string[] args)
        {
            do
            {
                int coord = 0;
                bool isWin = false;
                Player[] players = new Player[22];
                for (int i = 0; i < 11; i++)
                {
                    players[i] = new RedPlayer(rnd.Next(50));
                }
                for (int i = 11; i < 22; i++)
                {
                    players[i] = new BluePlayer(rnd.Next(50));
                }

                Randomise(ref players);

                foreach (var item in players)
                {
                    item.Push(ref coord);

                    if (coord >= 100)//Вместо проверки два раза на координату,
                                     //можно проверить на |coord| >= 100, а потом осуществить
                                     //вывод победы с помощмю if(item is RedPlayer) 
                                     //                              Console.WriteLine("Red wins");
                                     //                       else Console.WriteLine("Blue wins");
                    {
                        Console.WriteLine("Red wins");
                        isWin = true;
                        break;
                    }
                    else if (coord <= -100)
                    {
                        Console.WriteLine("Blue wins");
                        isWin = true;
                        break;
                    }
                    else Console.WriteLine($"Place of ball is {coord}");
                }
                if (!isWin)
                    Console.WriteLine("Draw");
                Console.WriteLine("Press ENTER to exit");
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.ReadKey();

        }
    }
}
