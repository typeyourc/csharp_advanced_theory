using System.Collections;

namespace Lesson4_Hashtable
{
    class MonsterMgr
    {
        public long id;
        public string name;
        public Hashtable hashtable = new Hashtable();

        //public MonsterMgr(long id, string name)
        //{
        //    this.id = id;
        //    this.name = name;
        //}
        public void CreateMons(long id, string name)
        {
            hashtable.Add(id, name);
        }
        public void DeleteMons(long id)
        {
            hashtable.Remove(id);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //练习二：怪物管理器，创建怪物，移除怪物，怪物有唯一ID
            MonsterMgr monsterMgr = new MonsterMgr();
            monsterMgr.CreateMons(1, "食蚁兽");
            monsterMgr.CreateMons(2, "鲲");
            //foreach (DictionaryEntry item in monsterMgr.hashtable)
            //{
            //    Console.WriteLine("怪兽ID=" + item.Key + ",怪兽名字=" + item.Value);
            //}
            monsterMgr.CreateMons(0, "王大锤");
            monsterMgr.DeleteMons(1);
            foreach (DictionaryEntry item in monsterMgr.hashtable)
            {
                Console.WriteLine("怪兽ID=" + item.Key + ",怪兽名字=" + item.Value);
            }

            //Console.WriteLine("Hello, World!");
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("key1", "value1");
            //hashtable.Add(1,2);

            //Console.WriteLine(hashtable["key1"]);
            //Console.WriteLine(hashtable["3"]);
            //Console.WriteLine(hashtable["key1"]);
        }
    }
}