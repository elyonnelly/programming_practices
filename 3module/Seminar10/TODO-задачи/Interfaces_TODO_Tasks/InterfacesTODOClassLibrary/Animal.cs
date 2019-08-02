using System;
namespace InterfacesTODOClassLibrary
{
    /// <summary>
    /// Класс животного
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Генератор псевдослучайных чисел
        /// </summary>
        public static Random rnd = new Random();
        /// <summary>
        /// Делегат для события OnSound
        /// </summary>
        public delegate void SoundHandler();
        /* TODO: Определить событие издавания звука OnSound.
         * TODO: Определить конструктор с двумя параметрами(имя животного, отметка о наличии опекуна).
         * (ID должен генерироваться автоматически при создании объекта, начиная с 1 – в конструктор это значение передавать не нужно!). */
        /// <summary>
        /// Идентификационный номер животного
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Имя животного
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Взято ли животное под опеку
        /// </summary>
        public bool IsTakenCare { get; set; }
        // TODO: Создать метод DoSound для запуска события OnSound.
        // TODO: Переопределить метод ToString(), возвращающий информацию об объекте (все его свойства).
    }
}
