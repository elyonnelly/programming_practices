using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Library
{
    [DataContract]
    [Serializable]
    public class Bird:Animal
    {
        [DataMember]
        int speed;

        public Bird()
        {
        }

        public Bird(string name, bool isTakenCare,int sped) : base(name, isTakenCare)
        {
            Speed = sped;
        }

        public int Speed
        {
            get => speed;
            set
            {
                if (value < 1 || value > 100) throw new FormatException("Скорость птицы лежит в промежутке от 1 до 100");
                speed = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Speed: {Speed}";
        }
    }
}
