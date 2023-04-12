namespace Lesson16_List排序
{
    class Item : IComparable<Item>
    {
        public int money;

        public Item(int money)
        {
            this.money = money;
        }

        public int CompareTo(Item other)
        {
            if (this.money > other.money)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            List<Item> itemList = new List<Item>();
            itemList.Add(new Item(45));
            itemList.Add(new Item(10));
            itemList.Add(new Item(99));
            itemList.Add(new Item(24));
            itemList.Add(new Item(100));
            itemList.Add(new Item(12));
            //排序方法
            itemList.Sort();
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine(itemList[i].money);
            }
        }
    }
}