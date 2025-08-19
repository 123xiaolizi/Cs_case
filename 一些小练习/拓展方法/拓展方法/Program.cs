using System;

namespace 拓展方法练习
{
    //为整形拓展一个求平方的方法
    static class tools
    {
        public static int square(this int num)
        {
            return num * num;
        }
    }
    //写一个玩家类，包含：姓名、血量、攻击力、防御力等方法，攻击，移动，受伤等方法
    //为玩家拓展一个自杀的方法
    class Player
    {
        private string Name;
        //private int hp; //拓展方法是不可以访问private的字段的，毕竟是static方法
        public int hp;
        private int atk;
        private int defense;

        public Player(string name, int hp, int atk, int defense)
        {
            this.Name = name;
            this.hp = hp;
            this.atk = atk;
            this.defense = defense;
        }

        //攻击
        public void Attack(Player target)
        {
            target.hp -= this.atk;
        }

        //移动
        public void Move()
        {
            Console.WriteLine("移动");
        }

        //受伤
        public void Hurt(int damage)
        {
            this.hp -= damage;
        }

    }

    //为玩家类拓展一个自杀方法
    static class PlayerExtension
    {
        public static void Suicide(this Player player)
        {
            player.hp = 0;
            Console.WriteLine("自杀成功");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            int res = num.square();
            Console.WriteLine(res);
            Player player = new Player("张三", 100, 10, 5);
            player.Suicide();
        }
    }

}