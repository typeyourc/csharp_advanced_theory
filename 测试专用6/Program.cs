namespace 测试专用6
{
    internal class Program
    {
        class Content
        {
            public int id;
            public string str;
            public Content(int id, string str)
            {
                this.id = id;
                this.str = str;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("list排序练习三");
            //建一个Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //给Dictionary添加元素
            dic.Add(1, "a");
            dic.Add(2, "b");
            dic.Add(3, "c");
            dic.Add(8, "c");
            dic.Add(9, "c");
            dic.Add(66, "c");
            //new一个List<Content>的list，并把字典的键和值加进去
            List<Content> list = new List<Content>();
            foreach(int id in dic.Keys)
            {
                list.Add(new Content(id, dic[id]));
            }
            //输出排序前内容
            Console.WriteLine("*****************");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].id + "-" + list[i].str);
            }
            //排序
            list.Sort((a, b) => { return a.id > b.id ? -1 : 1; });
            //输出排序后内容
            Console.WriteLine("*****************");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].id + "-" + list[i].str);
            }
        }
    }
}