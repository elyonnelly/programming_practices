using System;

namespace Library
{
    public class Human
    {
        public string Name { get; private set; }
        public Human(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name}" +
                $" позвал. Моя цель { e.Message}");
        }
    }
}
