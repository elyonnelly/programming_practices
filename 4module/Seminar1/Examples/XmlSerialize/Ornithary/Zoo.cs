using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornithary
{
    public class Ornitharym
    {
        List<Animal> allbirds;

        public Ornitharym()
        {
        }

        public Ornitharym(List<Animal> allBirds)
        {
            AllBirds = allBirds;
        }

        public List<Animal> AllBirds
        {
            get => allbirds;
            set
            {
                allbirds = value != null ? value : new List<Animal>();
            }
        }
        public override string ToString() => $"All Birds in Ornithary: {GetLineFromListBirds(AllBirds)}";

        private object GetLineFromListBirds(List<Animal> allBirds)
        {
            string line = "";
            for (int i = 0; i < AllBirds.Count; i++)
            {
                line += $"{i+1}: {AllBirds[i].ToString()}\n";
            }
            return line;
        }
    }
}
