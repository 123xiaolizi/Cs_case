using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.lesson3
{
    internal class Positions
    {
        public int x;
        public int y;

        public Positions(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Positions pos1, Positions pos2)
        {
            if (pos1.x == pos2.x && pos1.y == pos2.y) return true;
            return false;
        }

        public static bool operator !=(Positions pos1, Positions pos2)
        {
            if(pos1.x == pos2.x && pos1.y == pos2.y) return false;
            return true;
        }

    }
}
