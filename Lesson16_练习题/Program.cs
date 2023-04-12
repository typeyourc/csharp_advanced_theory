using System.Collections.Generic;

namespace Lesson16_练习题
{
    class Monster
    {
        public int atk;
        public int def;
        public int hp;

        public Monster(int atk, int def, int hp)
        {
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List排序练习题");
            //练习一：
            //创建怪物列表
            List<Monster> monsterList = new List<Monster>();
            List<Monster> monsterListBackup = new List<Monster>();
            //怪物列表赋初始10个怪物，攻击、防御、血量
            for (int i = 0; i < 10; i++)
            {
                monsterList.Add(new Monster((new Random()).Next(70, 100), (new Random()).Next(30, 80), (new Random()).Next(200, 300)));
            }
            for (int i = 0; i < 10; i++)
            {
                //注意元素的赋值用Add()，不能直接如下赋值
                //monsterListBackup[i].atk = monsterList[i].atk;
                //monsterListBackup[i].def = monsterList[i].def;
                //monsterListBackup[i].hp = monsterList[i].hp;
                monsterListBackup.Add(new Monster(monsterList[i].atk, monsterList[i].def, monsterList[i].hp));
            }
            //原始排序打印确认
            for (int i = 0; i < monsterList.Count; i++)
            {
                Console.WriteLine("攻击" + monsterList[i].atk + "防御" + monsterList[i].def + "血量" + monsterList[i].hp);
            }
            Console.WriteLine("请输入排序方式：1、攻击排序,2、防御排序,3、血量排序,4、反转,5、复原");          
            char input;
            bool flag;
            //循环输入
            while (true)
            {
                flag = true;
                input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        //攻击排序
                        monsterList.Sort((a, b) => { return a.atk > b.atk ? 1 : -1; });
                        break;
                    case '2':
                        //防御排序
                        monsterList.Sort((a, b) => { return a.def > b.def ? 1 : -1; });
                        break;
                    case '3':
                        //血量排序
                        monsterList.Sort((a, b) => { return a.hp > b.hp ? 1 : -1; });
                        break;
                    case '4':
                        //反转
                        Reset(monsterList, monsterListBackup);
                        monsterList.Reverse();
                        break;
                    case '5':
                        //复原
                        Reset(monsterList, monsterListBackup);
                        break;
                    default:
                        //输入错误，重新输入
                        Console.WriteLine("    ");
                        Console.WriteLine("输入错误，重新输入");
                        flag = false;
                        break;
                }
                if (flag)
                {
                    Console.WriteLine("    ");
                    for (int i = 0; i < monsterList.Count; i++)
                    {
                        Console.WriteLine("攻击" + monsterList[i].atk + "防御" + monsterList[i].def + "血量" + monsterList[i].hp);
                    }
                    Console.WriteLine("*************************");
                }
            }
        }
        //练习一的函数，复原列表用
        static void Reset(List<Monster> a, List<Monster> b)
        {
            for (int i = 0; i < 10; i++)
            {
                a[i].atk = b[i].atk;
                a[i].def = b[i].def;
                a[i].hp = b[i].hp;
            }
        }
    }
}