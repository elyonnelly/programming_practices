using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Randomize
    {
        public static Random rnd = new Random();
        public static string RandomLine()
        {
            string line = "";
            int count = rnd.Next(7, 15);
            for (int i = 0; i < count; i++)
            {
                line += (char)rnd.Next('a', 'z');
            }
            return line;
        }

        public static string RandomName()
        {
            string line = "";
            int count = rnd.Next(7, 15);
            line += (char)rnd.Next('A', 'Z');
            for (int i = 0; i < count; i++)
            {
                line += (char)rnd.Next('a', 'z');
            }
            return line;
        }
    }
}
