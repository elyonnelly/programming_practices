using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Player
        //Класс, который определяет игрока. Есть поля сила и сторона игры(по умолчанию она равно 0)
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
        public RedPlayer(int force) : base(force)//Определяем сторону
        {
            side = 1;
        }
    }

    class BluePlayer : Player
    {
        public BluePlayer(int force) : base(force)//Определяем сьорону
        {
            side = -1;
        }
    }
}
