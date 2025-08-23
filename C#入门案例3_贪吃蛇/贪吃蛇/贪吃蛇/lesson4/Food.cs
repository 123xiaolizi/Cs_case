using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;
using 贪吃蛇.lesson3;
using 贪吃蛇.lesson6;

namespace 贪吃蛇.lesson4
{
    internal class Food : GameObject
    {
        public Positions pos;
        public Food(Snake snake)
        {
            RandomFood(snake);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("☆");
        }

        //随机生成食物
        public void RandomFood(Snake snake)
        {
            //Random random = new Random();
            //int x = random.Next(2, Game.w - 4);
            //int y = random.Next(2, Game.h - 3);
            //pos = new Positions(x, y);
            Random r = new Random();
            int x = r.Next(2, Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.h - 4);
            pos = new Positions(x, y);
            if (snake.isCoincides(pos))//重合就会进入递归
            {
                RandomFood(snake);
            }
            return;
        }
    }
}
