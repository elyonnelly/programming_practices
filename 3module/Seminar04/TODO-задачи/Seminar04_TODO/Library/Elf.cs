using System;

namespace Library
{
    public class Elf
    {
        public string Name { get; private set; }
        public Elf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно." +
                $" Цветы увядают. Листья предсказывают идти в " + e.Message);
        }
    }
}
