/* Определить класс персонажа из вселенной "Властелина колец" LordOfTheRingsCharacter с полями, содержащими следующую информацию: 
 * 1) Имя персонажа;
 * 2) Фамилия персонажа;
 * 3) Раса персонажа;
 * 4) Текущее местоположение персонажа.
 * Также определить:
 * 1) Метод для получения сведений о персонаже (можно переопределить ToString());
 * 2) Метод для изменения местоположения персонажа на карте мира;
 * 3) Закрытый метод, вызывающийся при изменении местоположения персонажа и выводящий информацию о его новом местоположении.
 * В основной программе создать экземпляр класса LordOfTheRingsCharacter, вывести информацию о нем и изменить местоположение персонажа. */

using System;

namespace TODO_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            LordOfTheRingsCharacter сharacter = new LordOfTheRingsCharacter();
            сharacter.firstName = "Frodo";
            сharacter.lastName = "Baggins";
            сharacter.race = "Hobbit";
            сharacter.location = "Middle-Earth";
            Console.WriteLine(сharacter.GetInformation);
            сharacter.ChangeLocation("Lonely Mountain");
            // TODO: осуществить возможность считывания данных для создания нового экземпляра класса.
            // TODO: вывести информацию о новом экземпляре класса.
            // TODO: считать информацию о новом местоположении и количестве пройденных шагов и вызвать перегруженный метод ChangeLocation();
            Console.ReadKey();
        }
    }
}
