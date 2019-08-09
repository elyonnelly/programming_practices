using System;

namespace Library
{
    public class Wizard
    {
        public string Name { get; private set; }
        // 2) событийный делегат
        public delegate void RingIsFoundEventHandler(object sender,
        RingIsFoundEventArgs a);
        // 3) событие "Кольцо найдено"
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string s) { Name = s; }
        public Wizard() { }
        // Когда волшебнику кажется, что кольцо найдено, он вызывает этот метод
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо!" +
                $" Призываю вас в Ривендейл!");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }
}
