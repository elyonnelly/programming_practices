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
        /// Имя персонажа
        /// </summary>
        public string firstName;
        /// <summary>
        /// Фамилия персонажа
        /// </summary>
        public string lastName;
        /// <summary>
        /// Раса персонажа
        /// </summary>
        public string race;
        /// <summary>
        /// Местоположение персонажа
        /// </summary>
        public string location;

        // TODO: добавить переменную, подсчитывающую количество пройденных персонажем шагов с начала его создания.

        // TODO: переписать методы GetInformation и PrintNewLocation, используя лямбда-выражение.

        /* NOTE: свойство GetInformation и метод ToString возвращают одинаковую информацию. Очевидно, что реализовывать необходимо только
         * какой-то один из этих методов/свойств. В данной ситуации двойная реализация приведена лишь для демонстрации того, что можно и так, и так. 
         * (А вообще обычно переопределяют ToString.)*/
        /// <summary>
        /// Метод для возвращения информации об экземпляре класса
        /// </summary>
        /// <returns></returns>
        public string GetInformation
        {
            get { return ($"First name: {firstName}\nLast name: {lastName}\nRace: {race}\nLocation: {location}"); }
        }

        /// <summary>
        /// Переопределение стандартного вывода информации об экземпляре класса
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ($"First name: {firstName}\nLast name: {lastName}\nRace: {race}\nLocation: {location}");

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
