namespace TransportLibrary
{
    /// <summary>
    /// Абстрактный класс Transport, базовый класс для Truck и Ship, задает "интерфейс" для производных классов
    /// Мы не можем создавать его экземпляры.
    /// </summary>
    public abstract class Transport
    {
        private int capacity;
        public int Capacity
        {
            get => capacity;
            set => capacity = value >= 0 ? value : 0;
        }

        protected Transport(int capacity)
        {
            Capacity = capacity;
        }

        /// <summary>
        /// Абстрактный класс Deliver. Его функционал зависит напрямую от вида транспорта.
        /// </summary>
        /// <param name="departure">Пункт отправки груза</param>
        /// <param name="destination">Пункт назначения груза</param>
        /// <param name="cargo">Груз</param>
        /// <returns></returns>
        public abstract string Deliver(City departure, City destination, Cargo cargo);
    }
}