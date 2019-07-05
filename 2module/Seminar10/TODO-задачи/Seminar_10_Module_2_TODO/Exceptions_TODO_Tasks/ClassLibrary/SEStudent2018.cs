using System;

namespace ClassLibrary
{
    /// <summary>
    /// Класс – студент 2018 года
    /// </summary>
    public class SEStudent2018
    {
        /// <summary>
        /// Имя и фамилия студента
        /// </summary>
        string firstName, lastName;
        /// <summary>
        /// Номер группы, в которой обучается студент
        /// </summary>
        short groupNumber;

        /// <summary>
        /// Конструктор для создания экземпляра класса
        /// </summary>
        /// <param name="firstName">Имя студента</param>
        /// <param name="lastName">Фамилия студента</param>
        /// <param name="groupNumber">Номер группы студента</param>
        public SEStudent2018(string firstName, string lastName, short groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (groupNumber.ToString().Length != 3) throw new ArgumentException("Номер группы должен быть трехзначным числом.");
            this.groupNumber = groupNumber;
        }

        // TODO: переопределить метод для вывода информации о результатах студента
    }
}

