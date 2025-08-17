using System;

namespace Interface
{
    #region /*第一题：人、汽车、房子都需要等级，人需要到派出所登记，汽车需要去车管所登记，房子需要去房管局登记使用接口实现登记方法*/
    interface ICheck_in
    {
        void Check_in();
    }
    interface ICar_Check_out : ICheck_in
    { }
    interface Iperson_Check_in : ICheck_in
    { }
    interface Ihouse_Check_out : ICheck_in
    { }
    class Person : Iperson_Check_in
    {
        public void Check_in()
        {
            Console.WriteLine("person check in");
        }
    }
    class Car : ICar_Check_out
    {
        public void Check_in()
        {
            Console.WriteLine("car check in");
        }
    }
    class House : Ihouse_Check_out
    {
        public void Check_in()
        {
            Console.WriteLine("house check in");
        }
    }
    #endregion

    /*麻雀、鸵鸟、企鹅、鹦鹉、直升机、天鹅直升机和部分鸟能飞
     * 鸵鸟和企鹅不能飞 
     * 企鹅和天鹅能游泳 
     * 除直升机，其它都能走
     * 请用面向对象相关知识实现*/
    #region 第二题：
    interface IFly
    {
        void Fly();
    }
    interface IWalk
    {
        void Walk();
    }
    interface ISwim
    {
        void Swim();
    }

    //鸟
    class Bird : IWalk//有一些鸟是不会飞的
    {
        public void Walk()
        {
            Console.WriteLine("鸟会走！");
        }
        
    }
    //麻雀
    class Sparrow : Bird,IFly
    {
        
        public void Fly()
        {
            Console.WriteLine("麻雀会飞！");
        }
    }

    //直升机
    class Helicopter : IFly
    {
        public void Fly()
        {
            Console.WriteLine("直升机会飞！");
        }
    }
    //天鹅
    class Swan : Bird,IFly, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("天鹅会游泳！");
        }
        
        public void Fly()
        {
            Console.WriteLine("天鹅会飞！");
        }
    }
    //不全部写了
    #endregion

    class Program
{
    static void Main(string[] args)
    {
        ICheck_in[] check_in = new ICheck_in[3];
        check_in[0] = new Person();
        check_in[1] = new Car();
        check_in[2] = new House();
        foreach (ICheck_in i in check_in)
        {
            i.Check_in();
        }

        Sparrow sparrow = new Sparrow();
        sparrow.Walk();
        sparrow.Fly();

        Helicopter helicopter = new Helicopter();
        helicopter.Fly();

        Swan swan = new Swan();
        swan.Walk();
        swan.Fly();
        swan.Swim();

        }
}
}
