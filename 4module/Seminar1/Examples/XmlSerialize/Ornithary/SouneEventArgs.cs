using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornithary
{
    public class SouneEventArgs : EventArgs
    {
        string sound;

        public SouneEventArgs(string sound)
        {
            this.sound = sound;
        }
    }
}
