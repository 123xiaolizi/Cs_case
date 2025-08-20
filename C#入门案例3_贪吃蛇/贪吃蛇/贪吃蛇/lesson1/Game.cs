using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson2;

namespace 贪吃蛇.lesson1
{
    internal class Game
    {
        public const int w = 80;
        public const int h = 20;
        public static ISceneUpdate sceneUpdate;

        public enum SceneType
        {
            Begin,
            Game,
            End
        }

        public Game()
        {
            
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            ChangeScene(SceneType.Begin);
        }

        //开始游戏
        public void  Start()
        {
            while(true)
            {
                if (sceneUpdate != null)
                {
                    sceneUpdate.Update();
                }
            }
        }

       

        //切换场景
        public static void ChangeScene(SceneType type)
        {
            //切换场景之前把之前绘制的东西清除掉
            Console.Clear();
            switch (type)
            {
                case SceneType.Begin:
                    sceneUpdate = new BeginScene();
                    break;
                case SceneType.Game:
                    sceneUpdate = new GameScene();
                    break;
                case SceneType.End:
                    sceneUpdate = new EndScene();
                    break;
            }
        }
    }
}
