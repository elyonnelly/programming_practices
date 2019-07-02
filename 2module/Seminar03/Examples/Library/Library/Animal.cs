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
    public abstract class Animal:IVocal
    {
        public event Sound OnSound;
        protected Animal(string name, bool isTakenCare)
        {
            Name = name;
            IsTakenCare = isTakenCare;
            Id = count;
            count++;
        }

        protected Animal()
        {
        }
        [DataMember]
        public int Id { get; set; }
        static int count = 1;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsTakenCare { get; set; }

        public void DoSound()
        {
            OnSound();
        }

        public override string ToString() => $"Id:{Id}, Name: {Name}, IsTakenCare: {IsTakenCare}";

    }
}
