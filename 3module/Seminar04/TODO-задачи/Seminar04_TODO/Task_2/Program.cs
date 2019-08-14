using Library;
using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");
            Hobbit[] hobbits = new Hobbit[4];
            // TODO создать объекты хоббитов из Шира
            // TODO подписать хоббитов на событие волшебника
            Human[] humans = { new Human("Боромир"), new Human("Арагорн") };
            Dwarf dwarf = new Dwarf("Гимли");
            Elf elf = new Elf("Леголас");
            // подписывает гномов, людей и эльфов на событие
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;
            foreach (Human h in humans)
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;
            // волшебник оповещает всех
            wizard.SomeThisIsChangedInTheAir();
            Console.ReadLine();
        }
    }
}
