/* Определить класс LordOfTheRingsCharacter с полями имя, фамилия, раса и местоположение персонажа. В классе определить методы:
 * 1) Для вывода сведений о персонаже;
 * 2) Метод для изменения местоположения персонажа;
 * 3) Закрытый метод для вывода информации о новом местоположении персонажа, вызываемый при изменении местоположения;
 * В основной программе создайте экземпляр класса LordOfTheRingsCharacter, вывести информацию о нем и изменить местоположение. */
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
            сharacter.GetInformation();
            сharacter.ChangeLocation("Lonely Mountain");
            // TODO: осуществить возможность считывания данных для создания нового экземпляра класса.
            // TODO: вывести информацию о новом экземпляре класса.
            // TODO: считать информацию о новом местоположении и количестве пройденных шагов и вызвать перегруженный метод ChangeLocation();
            Console.ReadKey();
        }
    }
}
