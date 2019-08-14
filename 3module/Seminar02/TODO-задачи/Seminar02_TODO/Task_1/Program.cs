/*
Реализовать класс Robot, содержащий функционал для управления перемещениями робота.
Закрытые поля int x, y – хранят текущее положение;
Методы Right(), Left(), Forward() и Backward() изменяют соответствующую координату
в направлении движения (right увеличивает x на единицу, backward уменьшает y на единицу),
метод Position() возвращает строку с текущим положением робота.
В основной программе получать программу для робота в виде строки S.
Каждая команда кодируется заглавной латинской буквой: R (Right), L (Left), F (Forward), B (Backward).
В многоадресный делегат сохранять методы, в порядке, определённом программой S.
Запускать программу и выводить исходные и конечные координаты.

*/
using System;
using MyLib;

namespace Task_1
{
    delegate void Steps(); // делегат-тип
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot(); // конкретный робот
            /* Steps[] trace = { new Steps(rob.Backward), new Steps(rob.Backward), new Steps(rob.Left) };
            // сообщить координаты
            Console.WriteLine("Test: start position" + rob.Position());
            for (int i = 0; i < trace.Length; i++)
            {
                Console.WriteLine("Method = {0}, Target = {1}",
                trace[i].Method, trace[i].Target);
                trace[i]();
            }
            Console.WriteLine(rob.Position()); // сообщить координаты
            Console.WriteLine("-------------------------------"); */
            Steps delR = new Steps(rob.Right); // направо
            Steps delL = new Steps(rob.Left); // налево
            Steps delF = new Steps(rob.Forward); // вперед
            Steps delB = new Steps(rob.Backward); // назад

            // шаги по диагоналям (многоадресные делегаты):
            Steps delRF = delR + delF;
            Steps delRB = delR + delB;
            Steps delLF = delL + delF;
            Steps delLB = delL + delB;
            char[] vs;
            do
            {
                Console.WriteLine("Введите строку");
                string temp = Console.ReadLine();
                // форматируем входную строку (удаляем пробелы, делаем все символы заглавными)
                vs = temp.Replace(" ", "").ToUpper().ToCharArray();
                for (int i = 0; i < vs.Length; i++)
                {
                    if (vs[i] != 'R' && vs[i] != 'L' && vs[i] != 'B' && vs[i] != 'F')
                    {
                        Console.WriteLine("Неправильная строка");
                        vs = null;
                        break;
                    }
                }
            } while (vs == null);
            Steps steps = null;
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] == 'R')
                {
                    steps += delR;
                }
                if (vs[i] == 'L')
                {
                    steps += delL;
                }
                if (vs[i] == 'B')
                {
                    steps += delB;
                }
                if (vs[i] == 'F')
                {
                    steps += delF;
                }
            }
            steps?.Invoke(); // выполняем команды (проверяем steps != null)
            Console.WriteLine(rob.Position());
            Console.ReadLine();
            /*
            ToDO: Разработайте для робота консольный интерфейс. Клетки – позиции текстового курсора на экране.
            • Ограничения координат на поле получать от пользователя перед запуском робота.
            • Программу в виде строки S получать от пользователя (см. предыдущий слайд).
            • Робот отображается символом ‘*’ красного цвета.
            • Позиции, в которых побывал робот отмечаются символом ‘+’ серого цвета.
            • Если программа робота выводит его за пределы поля – останавливать выполнение программы и сообщать об этом.
            */

            // ToDO: добавьте повтор решения
        }
    }
}
