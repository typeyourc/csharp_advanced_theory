using System.Xml.Linq;

namespace Lesson12_委托
{
    #region 练习一的类
    class Mom
    {
        public string name = "妈妈";
        public Action<string> action;
    }
    class Dad
    {
        public string name = "爸爸";
        public Action<string> action;
    }
    class Son
    {
        public string name = "儿子";
        public Action<string> action;
    }
    #endregion
    #region 练习二的类
    class Monster
    {
        public Action action = null;
    }
    class Player
    {
        public int money;
        public int killCount;
        public UI ui;
        public Achieve achieve;
        public Func<int, int> func = null;
        
        public Player()
        {
            money = 0;
            killCount = 0;
            ui = new UI();
            achieve = new Achieve();
        }
    }
    class UI
    {
        public Action action = null;
    }
    class Achieve
    {
        public Action action = null;
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //练习一：妈妈做饭，爸爸妈妈孩子吃饭，用委托模拟做饭、开饭、吃饭的过程
            Mom mom = new Mom();
            Dad dad = new Dad();
            Son son = new Son();
            mom.action = DoCook;
            mom.action(mom.name);
            mom.action = DoOpen;
            mom.action(mom.name);
            mom.action = DoEat;
            mom.action(mom.name);
            dad.action = DoEat;
            dad.action(dad.name);
            son.action = DoEat;
            son.action(son.name);

            Console.WriteLine("***************************");
            //练习二：怪物死亡后，玩家加10块钱，界面要更新数据，成就要累加怪物击杀数
            Monster monster = new Monster();
            Player player = new Player();
            //怪物死亡
            monster.action = DoDie;
            monster.action();
            //玩家加10块钱
            player.func = DoGetMoney;
            player.func(10);
            //界面更新数据
            player.ui.action = DoUpdateUI;
            player.ui.action();
            //成就累加
            player.func = DoUpdateAchieve;
            player.func(10);


        }
        #region 练习一的函数
        public static void DoCook(string name)
        {
            Console.WriteLine("{0}做了饭", name);
        }
        public static void DoOpen(string name)
        {
            Console.WriteLine("{0}开饭", name);
        }
        public static void DoEat(string name)
        {
            Console.WriteLine("{0}吃饭", name);
        }
        #endregion
        #region 练习二的函数
        public static void DoDie()
        {
            Console.WriteLine("死亡");
        }
        public static int DoGetMoney(int num)
        {
            Console.WriteLine("得到10块钱");
            return num + 10;
        }
        public static void DoUpdateUI()
        {
            Console.WriteLine("更新UI");
        }
        public static int DoUpdateAchieve(int num)
        {
            Console.WriteLine("击杀更新成就");
            num++;
            return num;
        }
        #endregion

    }
}