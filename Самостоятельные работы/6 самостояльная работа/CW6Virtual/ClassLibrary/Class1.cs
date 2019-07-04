using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary
{
    public abstract class Cetartiodactyla
    {

        public abstract string GetVoice();
        bool HasTail { get; set; }

        protected Cetartiodactyla(bool isTail, double size, ConsoleColor skinColor)
        {
            HasTail = isTail;
            Size = size;
            SkinColor = skinColor;
        }

        double Size { get; set; }
        string Tail
        {
            get
            {
                if (HasTail)
                    return "has tail";
                else
                    return "has not tail";
            }
        }
        ConsoleColor SkinColor { get; }
        public override string ToString() => $"Hoofed\t{GetVoice()}\nColor: {SkinColor}\t{Tail}\tSize: {Size:f3}";
    }
    public class Whale : Cetartiodactyla
    {
        public Whale(bool isTail, double size, ConsoleColor skinColor,string type) : base(isTail, size, skinColor)
        {
            Type = type;
        }

        string Type { get; }
        public override string GetVoice()
        {
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(415, 300);
            return $"Whale Song";
        }
        public override string ToString()
        {
            return $"Whale\tType: {Type}\n{base.ToString()}";
        }
    }
    public class Hippopotamus : Cetartiodactyla
    {
        public Hippopotamus(bool isTail, double size, ConsoleColor skinColor,double speed) : base(isTail, size, skinColor)
        {
            Power = speed;
        }

        double Power { get; set; }
        public override string GetVoice()
        {
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            return $" Hippopotamus Song";

        }
        public override string ToString()
        {
            return $"Dolphin\tSpeed: {Power:f3}\n{base.ToString()}";
        }
    }
}
