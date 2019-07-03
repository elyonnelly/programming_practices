namespace TransportLibrary
{
    /// <summary>
    /// Класс грузовика. Доставка по суше
    /// </summary>
    public class Truck : Transport
    {
        public Truck(int capacity) :base(capacity)
        {

        }

        /// <summary>
        /// Переопределенный метод доставки товаров по суше
        /// </summary>
        /// <param name="departure">Пункт отправки груза</param>
        /// <param name="destination">Пункт назначения груза</param>
        /// <param name="cargo">Груз</param>
        /// <returns></returns>
        public override string Deliver(City departure, City destination, Cargo cargo)
        {
            if (destination.Loads.Count < destination.Capacity)
            {
                destination.Loads.Add(cargo);
                return $"Сargo {cargo} successfully delivered from {departure.Name} to {departure.Name} by land";
            }

            return $"Cargo {cargo} not delivered";
        }
    }
}