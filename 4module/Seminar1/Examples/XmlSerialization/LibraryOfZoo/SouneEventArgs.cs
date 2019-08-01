using System;

namespace LibraryOfZoo
{
    public class SouneEventArgs : EventArgs
    {
        public string sound;

        public SouneEventArgs(string sound)
        {
            this.sound = sound;
        }
    }
}
