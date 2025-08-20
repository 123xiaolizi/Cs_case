using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;

namespace 贪吃蛇.lesson2
{
    internal class GameScene : ISceneUpdate
    {
        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("游戏场景");
        }
    }
}
