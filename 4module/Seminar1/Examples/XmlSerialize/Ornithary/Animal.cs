using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornithary
{
    public abstract class Animal
    {
        protected Animal(string name)
        {
            Kind = name;
        }

        protected Animal()
        {
        }

        public event EventHandler<SouneEventArgs> GetVoice;//стандартный шаблон событий
        public string Kind { get; set; }

        public void DoSound(string voice)
        {
            GetVoice(this, new SouneEventArgs(voice));
        }
    }
}
