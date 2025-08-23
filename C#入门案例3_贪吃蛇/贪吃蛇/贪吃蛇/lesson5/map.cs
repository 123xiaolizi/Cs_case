using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;
using 贪吃蛇.lesson3;
using 贪吃蛇.lesson4;

namespace 贪吃蛇.lesson5
{
    internal class Map : IDraw
    {
        public Wall[] walls;

        public Map()
        {
            walls = new Wall[Game.w - 2 + (Game.h - 3) * 2];
            int index = 0;
            for (int i = 0; i < Game.w - 2; i+=2)
            {
                walls[index++] = new Wall(i, 0);
                walls[index++] = new Wall(i, Game.h - 2);
            }
            for (int i = 1; i < Game.h - 2; i++)
            {
                walls[index++] = new Wall(0, i);
                walls[index++] = new Wall(Game.w - 4, i);
            }
        }
        public void Draw()
        {
            for(int i = 0; i < walls.Length; i++)
            {
                walls[i].Draw();
            }
        }
    }
}
