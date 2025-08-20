using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;

namespace 贪吃蛇.lesson2
{
    internal class EndScene : BeginOrEnd_BaseScene
    {
        public EndScene()
        {
            strTitle = "贪吃蛇";
            strtitle_one = "返回开始界面";
        }
        public override void EnterToDoSomething()
        {
            if (curselectIndex == 0)
            {
                Game.ChangeScene(Game.SceneType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
