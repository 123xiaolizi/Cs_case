using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson3;

namespace 贪吃蛇.lesson4
{
    internal class Wall : GameObject
    {
        public Positions pos;

        public Wall(int x, int y)
        {
            pos = new Positions(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
        }
    }
}
