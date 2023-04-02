using System.Collections;

namespace 测试专用1
{
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
    class Things
    {
        public Thing[] things = new Thing[4];
        public Things()
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
        public Things things = new Things();

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
            Console.WriteLine("您购买了{0}", thing);
            switch (thing)
            {
                case E_Thing.Knife:
                    moneyTotal -= things.things[0].price;
                    break;
                case E_Thing.Gun:
                    moneyTotal -= things.things[1].price;
                    break;
                case E_Thing.Apple:
                    moneyTotal -= things.things[2].price;
                    break;
                case E_Thing.Water:
                    moneyTotal -= things.things[3].price;
                    break;
            }
            Console.WriteLine("您剩余金钱为{0}", moneyTotal);
        }
        //卖出物品
        public void SellThing(E_Thing thing)
        {
            arrayThing.Remove(thing);
            Console.WriteLine("您卖出了{0}", thing);
            switch (thing)
            {
                case E_Thing.Knife:
                    moneyTotal += things.things[0].price;
                    break;
                case E_Thing.Gun:
                    moneyTotal += things.things[1].price;
                    break;
                case E_Thing.Apple:
                    moneyTotal += things.things[2].price;
                    break;
                case E_Thing.Water:
                    moneyTotal += things.things[3].price;
                    break;
            }
            Console.WriteLine("您剩余金钱为{0}", moneyTotal);
        }
        //显示物品
        public void ShowThing()
        {
            int i = 0;
            foreach (object item in arrayThing)
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
            Console.WriteLine("Hello, World!");
        }
    }
}