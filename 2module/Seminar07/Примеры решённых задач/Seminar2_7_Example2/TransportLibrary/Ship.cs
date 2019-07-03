namespace TransportLibrary
{
    /// <summary>
    /// Класс корабля. Доставка груза по воде
    /// </summary>
    public class Ship : Transport
    {
        public Ship(int capacity) : base(capacity)
        {

        }

        /// <summary>
        /// Переопределенный метод доставки товаров по морю
        /// </summary>
        /// <param name="departure">Пункт отправки груза</param>
        /// <param name="destination">Пункт назначения груза</param>
        /// <param name="cargo">Груз</param>
        /// <returns></returns>
        public override string Deliver(City departure, City destination, Cargo cargo)
        {
            if (destination.IsThereAPort && destination.Loads.Count < destination.Capacity)
            {
                destination.Loads.Add(cargo);
                return $"Сargo {cargo} successfully delivered from {departure.Name} to {departure.Name} by sea";
            }

            return $"Cargo {cargo} not delivered";
        }
    }
}