using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;
using 贪吃蛇.lesson4;
using 贪吃蛇.lesson5;
using 贪吃蛇.lesson6;

namespace 贪吃蛇.lesson2
{
    internal class GameScene : ISceneUpdate
    {
        public Map m_map;
        public Snake m_snake;
        public Food m_food;
        private int n;//用来延时的
        public GameScene()
        {
            m_map = new Map();
            m_snake = new Snake(12, 13);
            m_food = new Food(m_snake);
        }
        public void Update()
        {

            
            if (++n % 8000 == 0)
            {
                m_map.Draw();
                m_food.Draw();

                m_snake.Move();
                if (!m_snake.CheckHit(m_map))//没撞自己或者墙就画
                {
                    m_snake.Draw();
                }
                m_snake.CheckEatFood(m_food);
                n = 0;
            }
            
            if(Console.KeyAvailable)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        m_snake.CheckDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.A:
                        m_snake.CheckDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        m_snake.CheckDir(E_MoveDir.Right);
                        break;
                    case ConsoleKey.S:
                        m_snake.CheckDir(E_MoveDir.Down);
                        break;

                }
            }
        }
    }
}
