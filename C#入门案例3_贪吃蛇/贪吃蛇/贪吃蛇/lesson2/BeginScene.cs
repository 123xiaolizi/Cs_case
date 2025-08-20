using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;

namespace 贪吃蛇.lesson2
{
    class BeginScene : BeginOrEnd_BaseScene
    {
        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strtitle_one = "开始游戏";

        }
        public override void EnterToDoSomething()
        {
            if(curselectIndex == 0)
            {
                Game.ChangeScene(Game.SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
