using System.Collections;

namespace Lesson1_ArrayList
{
    //class Test
    //{

    //}
    /// <summary>
    /// 物品种类
    /// </summary>
    enum E_Thing
    {
        Knife,
        Gun,
        Apple,
        Water,
    }
    class Thing
    {
        public E_Thing e_thing;
        public long price;
    }
    static class Things
    {
        public static Thing[] things = new Thing[4];
        static Things()
        {
            things[0] = new Thing();
            things[0].e_thing = E_Thing.Knife;
            things[0].price = 1;

            things[1] = new Thing();
            things[1].e_thing = E_Thing.Gun;
            things[1].price = 2;

            things[2] = new Thing();
            things[2].e_thing = E_Thing.Apple;
            things[2].price = 3;

            things[3] = new Thing();
            things[3].e_thing = E_Thing.Water;
            things[3].price = 4;
        }
    }

    class BagManage
    {
        public long moneyTotal = 100;
        public ArrayList arrayThing = new ArrayList();


        //存储物品
        public void StoreThing(E_Thing thing)
        {
            arrayThing.Add(thing);
            Console.WriteLine("您存入了{0}", thing);
        }
        //购买物品
        public void BuyThing(E_Thing thing)
        {
            arrayThing.Add(thing);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("您购买了{0}", thing);
            switch (thing)
            {
                case E_Thing.Knife:
                    moneyTotal -= Things.things[0].price;
                    break;
                case E_Thing.Gun:
                    moneyTotal -= Things.things[1].price;
                    break;
                case E_Thing.Apple:
                    moneyTotal -= Things.things[2].price;
                    break;
                case E_Thing.Water:
                    moneyTotal -= Things.things[3].price;
                    break;
            }
            Console.WriteLine("您剩余金钱为{0}", moneyTotal);
        }
        //卖出物品
        public void SellThing(E_Thing thing)
        {
            arrayThing.Remove(thing);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("您卖出了{0}", thing);
            switch (thing) 
            {
                case E_Thing.Knife:
                    moneyTotal += Things.things[0].price;
                    break;
                case E_Thing.Gun:
                    moneyTotal += Things.things[1].price;
                    break;
                case E_Thing.Apple:
                    moneyTotal += Things.things[2].price;
                    break;
                case E_Thing.Water:
                    moneyTotal += Things.things[3].price;
                    break;
            }
            Console.WriteLine("您剩余金钱为{0}", moneyTotal);
        }
        //显示物品
        public void ShowThing()
        {
            int i = 0;
            foreach (var item in arrayThing)
            {
                Console.WriteLine("{0}号物品:{1}", i, item);
                i++;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //练习一：请简述ArrayList和数组的区别
            //练习二：
            BagManage bagManage = new BagManage();
            bagManage.ShowThing();

            bagManage.StoreThing(E_Thing.Gun);
            //bagManage.ShowThing();
            bagManage.StoreThing(E_Thing.Apple);
            bagManage.StoreThing(E_Thing.Gun);
            bagManage.BuyThing(E_Thing.Knife);
            bagManage.ShowThing();

            bagManage.SellThing(E_Thing.Gun);
            bagManage.ShowThing();

            //Console.WriteLine("Hello, World!");

            //ArrayList array = new ArrayList();
            ////Console.WriteLine(array.Capacity);

            //array.Add(1);
            ////Console.WriteLine(array.Capacity);
            //array.Add(2);
            ////Console.WriteLine(array.Capacity);
            //array.Add(3);
            //array.Add(4);
            //array.Add(5);
            ////Console.WriteLine(array.Capacity);
            //array.Add("123");
            //array.Add(true);
            //array.Add(new object());
            //array.Add(new Test());
            //Console.WriteLine(array.Capacity);
            //Console.WriteLine(array.Count);
            //for (int i = 0; i < array.Count; i++)
            //{
            //    Console.WriteLine("array[{0}]={1}", i, array[i]);
            //}
            ////array.Remove(1);
            ////Console.WriteLine(array.Capacity);
            ////Console.WriteLine(array.Count);
            ////for (int i = 0; i < array.Count; i++)
            ////{
            ////    Console.WriteLine("array[{0}]={1}", i, array[i]);
            ////}
            ////array.RemoveAt(0);
            ////Console.WriteLine(array.Capacity);
            ////Console.WriteLine(array.Count);
            ////for (int i = 0; i < array.Count; i++)
            ////{
            ////    Console.WriteLine("array[{0}]={1}", i, array[i]);
            ////}
            ////array.Clear();
            ////Console.WriteLine(array.Capacity);
            ////Console.WriteLine(array.Count);
            ////for (int i = 0; i < array.Count; i++)
            ////{
            ////    Console.WriteLine("array[{0}]={1}", i, array[i]);
            ////}
            //if (array.Contains("123"))
            //{
            //    Console.WriteLine("存在");
            //}

            //foreach (object item in array)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}