using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.lesson3
{
    abstract class GameObject : IDraw
    {
        public Positions pos;
        public abstract void Draw();
        
    }
}
