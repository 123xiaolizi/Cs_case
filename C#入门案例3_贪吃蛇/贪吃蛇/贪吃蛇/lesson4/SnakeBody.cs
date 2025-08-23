using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson3;

namespace 贪吃蛇.lesson4
{
    enum E_Snake_Type
    {
        Head,
        Body,
        Tail
    }
    internal class SnakeBody : GameObject
    {

        public Positions pos;
        public E_Snake_Type type;

        public SnakeBody(E_Snake_Type type, int x, int y)
        {
            this.type = type;
            pos = new Positions(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = type == E_Snake_Type.Head ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write(type == E_Snake_Type.Head ? "●" : "◆");
        }
    }
}
