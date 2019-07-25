using System;

namespace LibraryOfZoo
{
    public class Insect:Animal
    {
        public Insect()
        {
        }
        int countoflegs;
        public int CountOfLegs
        {
            get => countoflegs;
            set
            {
                if (value < 4 || value > 12)
                    throw new ArgumentException("Это не насекомое");
                countoflegs = value;
            }
        }
        public Insect(int speed) : base("Spider")
        {
            CountOfLegs = speed;
        }
        public override string ToString() => $"Kind: {Kind}, Speed : {CountOfLegs:f3}";//все поля публичные поэтому можем использовать вид
    }
}
