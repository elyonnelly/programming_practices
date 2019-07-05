using System;

namespace TODO_Task_01
{
    /// <summary>
    /// Класс персонаж "Властелина колец"
    /// </summary>
    class LordOfTheRingsCharacter
    {
        // TODO: защитить поля класса от прямой перезаписи данных.
        /// <summary>
        /// Имя
        /// </summary>
        public string firstName;
        /// <summary>
        /// Фамилия
        /// </summary>
        public string lastName;
        /// <summary>
        /// Раса
        /// </summary>
        public string race;
        /// <summary>
        /// Местоположение
        /// </summary>
        public string location;
        // TODO: добавить переменную, подсчитывающую количество пройденных персонажем шагов с начала его создания.

        // TODO: переписать методы GetInformation и PrintNewLocation, используя лямбда-выражение.
        /// <summary>
        /// Метод для вывода информации о персонаже.
        /// </summary>
        public void GetInformation()
        {
            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nRace: {race}\nLocation: {location}");
        }

        /* TODO: добавьте перегруженные методы: 
         * 1) для изменения местоположения и количества пройденных шагов к методу ChangeLocation(); 
         * 2) для печати новых сведений о местоположении и количестве шагов к методу PrintNewLocation(). 
         */
        /// <summary>
        /// Метод для печати на консоль нового значения местоположения.
        /// </summary>
        /// <param name="newLocation"></param>
        void PrintNewLocation(string newLocation)
        {
            Console.WriteLine($"New location: {newLocation}");
        }

        /// <summary>
        /// Метод для изменения местоположения персонажа.
        /// </summary>
        /// <param name="newLocation">Новое местоположение персонажа</param>
        public void ChangeLocation(string newLocation)
        {
            location = newLocation;
            PrintNewLocation(location);
        }
    }

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
