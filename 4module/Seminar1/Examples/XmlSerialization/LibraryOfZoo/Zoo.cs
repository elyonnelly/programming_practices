using System;
using System.Collections.Generic;

namespace LibraryOfZoo
{
    public class Zoo
    {
        List<Animal> allbirds;

        public Zoo()
        {
        }

        public Zoo(List<Animal> allBirds)
        {
            AllAnimals = allBirds;
        }

        public List<Animal> AllAnimals
        {
            get => allbirds;
            set
            {
                allbirds = value != null ? value : new List<Animal>();
            }
        }
        public override string ToString() => $"All Birds in Ornithary: {GetLineFromListAnimals(AllAnimals)}";

        private object GetLineFromListAnimals(List<Animal> allAnimals)
        {
            string line = "";
            for (int i = 0; i < AllAnimals.Count; i++)
            {
                line += $"{i + 1}: {AllAnimals[i].ToString()}\n";
            }
            return line;
        }

    }
}
