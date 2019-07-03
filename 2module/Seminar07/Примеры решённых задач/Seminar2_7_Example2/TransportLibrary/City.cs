using System.Collections.Generic;

namespace TransportLibrary
{
    public class City
    {
        public readonly string Name;

        /// <summary>
        /// readonly поле -- наличие в городе порта
        /// </summary>
        public readonly bool IsThereAPort;

        private int capacity;

        /// <summary>
        /// Инкапсулированное свойство -- вместимость города
        /// </summary>
        public int Capacity
        {
            get => capacity;
            set => capacity = value >= 0 ? value : 0;
        }
        /// <summary>
        /// список грузов, которые доставлены в город
        /// </summary>
        public List<Cargo> Loads { get; set; }

        public City(string name, bool isTherePort, int capacity)
        {
            IsThereAPort = isTherePort;
            Capacity = capacity;
            Name = name;
            Loads = new List<Cargo>();
        }

    }
}