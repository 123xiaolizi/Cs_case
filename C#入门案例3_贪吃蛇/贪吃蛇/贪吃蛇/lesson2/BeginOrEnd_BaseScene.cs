using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;

namespace 贪吃蛇.lesson2
{
    abstract class BeginOrEnd_BaseScene : ISceneUpdate
    {
        protected int curselectIndex = 0;
        protected string strTitle;
        protected string strtitle_one;

        public abstract void EnterToDoSomething();
        
        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //标题
            Console.SetCursorPosition(Game.w / 2 - strTitle.Length, 5);
            Console.Write(strTitle);

            //选项
            Console.SetCursorPosition(Game.w / 2 - strtitle_one.Length, 8);
            Console.ForegroundColor = curselectIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strtitle_one);

            Console.SetCursorPosition(Game.w / 2 - 4, 10);
            Console.ForegroundColor = curselectIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");

            switch( Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --curselectIndex;
                    if(curselectIndex < 0) curselectIndex = 0;
                    break;
                    
                case ConsoleKey.S:
                    ++curselectIndex;
                    if (curselectIndex > 1) curselectIndex = 1;
                        break;
                case ConsoleKey.Enter:
                    EnterToDoSomething();
                    break;
            }
        }
    }
}
