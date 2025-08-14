using System;

namespace move_diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("控制台相关练习");
            //修改窗口
            Console.SetWindowSize(50, 20);
            //修改缓冲区
            Console.SetBufferSize(50, 20);
            //改背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //改字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;
            //设置光标隐藏
            Console.CursorVisible = false;
            int x = 0, y = 0;
            while (true)
            {
                //设置光标位置
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                char c = Console.ReadKey(true).KeyChar;
                //把方块擦掉
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                
                switch(c)
                {
                    case 'W':
                    case 'w':
                        if(y == 0)
                        {
                            break;
                        }
                        --y;
                        break;
                    case 'S':
                    case 's':
                        if (y == Console.BufferHeight - 1) break;
                        ++y;
                        break;
                    case 'A':
                    case 'a':
                        if (x == 0)
                        {
                            break;
                        }
                        x -= 1;
                        break;
                    case 'D':
                    case 'd':
                        if (x == Console.BufferWidth - 1) break;
                        x +=1;
                        break;
                }

            }

            
            

        }
    }
}
 