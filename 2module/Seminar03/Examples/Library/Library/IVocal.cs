using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Library
{
    public delegate void Sound();
    interface IVocal
    {
        void DoSound();
    }
}
