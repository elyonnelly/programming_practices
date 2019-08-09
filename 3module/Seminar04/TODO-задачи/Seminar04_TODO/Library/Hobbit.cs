using System;

namespace Library
{
    public class Hobbit
    {
        public string Name { get; private set; }
        public Hobbit(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    }
}
