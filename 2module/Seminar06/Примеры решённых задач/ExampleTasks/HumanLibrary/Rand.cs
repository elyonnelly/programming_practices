using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLibrary
{
    public static class Rand
    {
        public static Random rng = new Random();

        public static int Next() => rng.Next();
        public static int Next(int x) => rng.Next(x);
        public static int Next(int left, int right) => rng.Next(left, right);
        public static double NextDouble() => rng.NextDouble();
        public static bool NextBool() => rng.Next(0, 2) == 1 ? true : false;
    }

}
