using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.lesson1;
using 贪吃蛇.lesson3;
using 贪吃蛇.lesson4;
using 贪吃蛇.lesson5;

namespace 贪吃蛇.lesson6
{
    enum E_MoveDir
    {
        /// <summary>
        /// 左
        /// </summary>
        Left,
        /// <summary>
        /// 右
        /// </summary>
        Right,
        /// <summary>
        /// 上
        /// </summary>
        Up,
        /// <summary>
        /// 下
        /// </summary>
        Down,
    }
    internal class Snake : IDraw
    {
        //用个固定的长度来定义这个数组吧，考虑到这个游戏地图空间不大，定长就够了
        public SnakeBody[] snakebody;
        public int index;

        //当前方向
        public E_MoveDir dir;
        public Snake(int x, int y)
        {
            index = 1;
            snakebody = new SnakeBody[1024];
            snakebody[0] = new SnakeBody(E_Snake_Type.Head, x, y);
            dir = E_MoveDir.Right;
        }
        public void Draw()
        {
            for (int i = 0; i < index; i++)
            {
                snakebody[i].Draw();
            }
        }

        //移动
        public void Move()
        {
            //擦除蛇尾
            SnakeBody lastbody = snakebody[index - 1];
            Console.SetCursorPosition(lastbody.pos.x, lastbody.pos.y);
            Console.Write("  ");

            //调整整体位置
            for(int i = index - 1; i > 0; --i)
            {
                snakebody[i].pos.x = snakebody[i - 1].pos.x;
                snakebody[i].pos.y = snakebody[i - 1].pos.y;
            }

            switch(dir)
            {
                case E_MoveDir.Left:
                    snakebody[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    snakebody[0].pos.x += 2;
                    break;
                case E_MoveDir.Up:
                    snakebody[0].pos.y -= 1;
                    break;
                case E_MoveDir.Down:
                    snakebody[0].pos.y += 1;
                    break;
            }
        }

        //检查方向
        public void CheckDir(E_MoveDir dir)
        {
            if(this.dir == dir) return;
            if(index > 1 &&
                ((this.dir == E_MoveDir.Left && dir == E_MoveDir.Right)||
                (this.dir == E_MoveDir.Right && dir == E_MoveDir.Left)||
                (this.dir == E_MoveDir.Up && dir == E_MoveDir.Down)||
                (this.dir == E_MoveDir.Down && dir == E_MoveDir.Up))
                )
            {
                return;
            }
            this.dir = dir;
        }

        //判断是否撞墙或者撞到自己
        public bool CheckHit(Map map)
        {
            Positions hendpos = snakebody[0].pos;
            if(map == null) return true;
            for(int i = 0; i < map.walls.Length; i++)
            {
                if(hendpos.x == map.walls[i].pos.x &&
                    hendpos.y == map.walls[i].pos.y)
                {
                    Game.ChangeScene(Game.SceneType.End);
                    return true;
                }
            }
            for(int i = 1; i < index; i++)
            {
                if(hendpos == snakebody[i].pos)
                {
                    Game.ChangeScene(Game.SceneType.End);
                    return true;
                }
            }
            return false;
        }

        //吃食物相关
        public void CheckEatFood(Food food)
        {
            if(snakebody[0].pos == food.pos)
            {
                //先吃掉食物
                food.RandomFood(this);
                addboby();
            }
        }


        //用于确定生成的食物是否和蛇重合
        public bool isCoincides(Positions pos)
        {
            for(int i = 0; i < index; ++i)
            {
                if(snakebody[i].pos == pos) return true;
            }

            return false;
        }

        //长身体
        private void addboby()
        {
            SnakeBody frontBody = snakebody[index - 1];
            //先长 
            snakebody[index] = new SnakeBody(E_Snake_Type.Body, frontBody.pos.x, frontBody.pos.y);
            //再加长度
            ++index;
        }
    }
}
