using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Player
    {
        int Force;
        protected int side = 0;

        public Player(int force)
        {
            Force = force;
        }

        public void Push(ref int coord)
        { 
            coord += side*Force;
        }
    }

    class RedPlayer : Player
    {
        public RedPlayer(int force) : base(force)
        {
            side = 1;
        }
    }

    class BluePlayer : Player
    {
        public BluePlayer(int force) : base(force)
        {
            side = -1;
        }
    }
}
