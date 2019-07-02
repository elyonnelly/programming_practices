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
    public class Mammal : Animal
    {
        [DataMember]
        int paws;
        public int Paws
        {
            get => paws;
            set
            {
                if (value > 20 || value < 1) throw new FormatException("Количество лап лежит в промежутке от 1 до 20");
                paws = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Paws: {Paws}";
        }


        public Mammal(string name, bool isTakenCare,int pawss) : base(name, isTakenCare)
        {
            Paws = pawss;
        }

        public Mammal()
        {
        }
    }
}
