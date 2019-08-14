using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    public static class Randomize//класс обложка все по стандарту
    {
        public static Random rnd = new Random();
        static int idcounter = 0;//интератор для генерации уникального id
        public static string RandomName()
        {
            string name = "";
            int rand = rnd.Next(4, 15);
            name += (char)rnd.Next('A', 'Z');
            for (int i = 0; i < rand; i++)
            {
                name += (char)rnd.Next('a', 'z');
            }
            return name;
        }

        public static List<Candidate> CreateNewCandidates()
        {
            List<Candidate> candidates = new List<Candidate>();
            int rand = rnd.Next(3, 8);
            for (int i = 0; i < rand; i++)
            {
                candidates.Add(new Candidate(idcounter++,RandomName(),(Party)rnd.Next(0,5)));
            }
            return candidates;
        }
    }
}
