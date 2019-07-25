using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornithary
{
    public class Bird : Animal
    {
        public Bird()
        {
        }
        double speed;
        public double Speed
        {
            get => speed;
            set
            {
                if (value < 0 || value > 150)
                    throw new ArgumentException("Скорость птицы не может быть отрицательной и превышать 150 км/ч");
                speed = value;
            }
        }
        public Bird(double speed) : base("Bird")
        {
            Speed = speed;
        }
        public override string ToString() => $"Kind: {Kind}, Speed : {Speed:f3}";//все поля публичные поэтому можем использовать вид

    }
}
