using System.Collections.Generic;

namespace Lesson7_List
{
    class Monster
    {
        public static List<Monster> monsList = new List<Monster>();
        public Monster()
        {
            //monsList = new List<Monster>();
        }
    }
    class Boss : Monster
    {
        //public Boss boss = new Boss();
        public Boss()
        {
            monsList.Add(this);
            monsList.Add(this);
            monsList.Add(this);
            //Console.WriteLine("Boss攻击");
        }
        public void Attack()
        {
            Console.WriteLine("Boss攻击");
        }   
    }
    class Gablin : Monster
    {
        //public Gablin gablin = new Gablin();
        public Gablin()
        {        
            monsList.Add(this);
            monsList.Add(this);
            //Console.WriteLine("Gablin攻击");
        }
        public void Attack()
        {
            Console.WriteLine("Gablin攻击");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //练习三：一个Monster基类，Boss和Gablin类继承它。
            //在怪物类的构造函数中，将其存储到一个怪物List中
            //遍历列表，可以让Boss和Gablin对象产生不同攻击
            //Monster monster = new Monster();
            Boss boss = new Boss(); 
            Gablin gablin = new Gablin();
            for (int i = 0; i < Monster.monsList.Count; i++)
            {
                if (Monster.monsList[i].Equals(boss))
                {
                    boss.Attack();
                }
                else
                {
                    gablin.Attack();
                }
            }

            //练习一：描述List和ArrayList的区别，指定类型、不指定类型(object)
            //练习二：建立一个整形List，为它添加10~1，删除List中第五个元素，遍历剩余元素并打印
            //List<int> list = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(10 - i);
            //    //list[i] = i + 1;
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //list.RemoveAt(4);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
        }
    }
}