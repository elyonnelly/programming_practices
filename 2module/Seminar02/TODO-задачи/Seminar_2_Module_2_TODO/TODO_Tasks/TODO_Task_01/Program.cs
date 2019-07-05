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
