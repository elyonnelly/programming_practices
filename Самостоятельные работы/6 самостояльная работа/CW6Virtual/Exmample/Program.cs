using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Exmample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cetartiodactyla whale = new Whale(true,123,(ConsoleColor)3,"Blue");
            Console.WriteLine(whale);
            Cetartiodactyla dolphin = new Hippopotamus(true, 123, (ConsoleColor)3, 123.3);
            Console.WriteLine(dolphin);
            Console.Read();
        }
    }
}
