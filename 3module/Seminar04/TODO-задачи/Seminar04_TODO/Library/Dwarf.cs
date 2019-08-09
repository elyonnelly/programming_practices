using System;

namespace Library
{
    public class Dwarf
    {
        public string Name { get; private set; }
        public Dwarf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы!" +
                $" Выдвигаемся в " + e.Message);
        }
    }
}
