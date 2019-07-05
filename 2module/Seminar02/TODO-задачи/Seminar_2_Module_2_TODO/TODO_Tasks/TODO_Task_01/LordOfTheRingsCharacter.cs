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
        /// Имя, фамилия, раса, местоположение
        /// </summary>
        public string firstName, lastName, race, location;

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
}
