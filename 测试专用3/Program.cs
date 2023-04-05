namespace 测试专用3
{
    class Monster
    {
        public List<Monster> monsList = new List<Monster>();
        public Monster()
        {
        }
    }
    class Boss : Monster
    {
        public Boss()
        {
            monsList.Add(this);
            Console.WriteLine("Boss攻击");
        }
    }
    class Gablin : Monster
    {
        public Gablin()
        {
            monsList.Add(this);
            Console.WriteLine("Gablin攻击");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Boss boss = new Boss();
            Gablin gablin = new Gablin();
            for (int i = 0; i < boss.monsList.Count; i++)
            {
                Console.WriteLine(boss.monsList[i]);
            }

        }
    }
}