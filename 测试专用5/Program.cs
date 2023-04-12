using System.Text;
using System.Threading;

namespace 测试专用5
{
    class Item
    {
        public int type;
        public int quality;
        public string name;

        public Item(int type, int quality, string name)
        {
            this.type = type;
            this.quality = quality;
            this.name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List排序练习题二");
            //练习二：
            #region 0创建物品并初始化
            //创建物品列表
            List<Item> itemList = new List<Item>();
            List<Item> itemListTemp = new List<Item>();
            //物品列表赋初始10个物品，类型(1,2,3)、品质(6,7,8)、名称
            for (int i = 0; i < 10; i++)
            {
                itemList.Add(new Item((new Random()).Next(1, 4), (new Random()).Next(6, 9), "item" + GenerateRandomString((new Random()).Next(1, 10))));
            }
            //输出物品信息
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine("类型" + itemList[i].type + "    品质" + itemList[i].quality + "    名称" + itemList[i].name);
            }
            Console.WriteLine("**************");
            #endregion

            #region 1按照类型排序
            //按照类型排序
            itemList.Sort((a, b) => { return a.type > b.type ? 1 : -1; });
            //输出物品信息
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine("类型" + itemList[i].type + "    品质" + itemList[i].quality + "    名称" + itemList[i].name);
            }
            Console.WriteLine("**************");

            #endregion

            #region 2进一步按照品质排序
            //进一步按照品质排序
            int baseline = 0;
            for (int i = 0; i < itemList.Count - 1; i++)
            {
                if (i == baseline)
                {
                    itemListTemp.Add(new Item(itemList[i].type, itemList[i].quality, itemList[i].name));
                }
                if (itemList[i + 1].type == itemList[i].type)
                {
                    itemListTemp.Add(new Item(itemList[i + 1].type, itemList[i + 1].quality, itemList[i + 1].name));
                    //判断是否到达最后一个元素
                    if (i == itemList.Count - 2)
                    {
                        itemListTemp.Sort((a, b) => { return a.quality > b.quality ? 1 : -1; });
                        for (int j = 0; j < itemListTemp.Count; j++)
                        {
                            itemList[baseline + j].type = itemListTemp[j].type;
                            itemList[baseline + j].quality = itemListTemp[j].quality;
                            itemList[baseline + j].name = itemListTemp[j].name;
                        }
                    }
                }
                else
                {
                    itemListTemp.Sort((a, b) => { return a.quality > b.quality ? 1 : -1; });
                    for (int j = 0; j < itemListTemp.Count; j++)
                    {
                        itemList[baseline + j].type = itemListTemp[j].type;
                        itemList[baseline + j].quality = itemListTemp[j].quality;
                        itemList[baseline + j].name = itemListTemp[j].name;
                    }
                    baseline = i + 1;
                    itemListTemp = new List<Item>();
                }
            }
            //输出物品信息
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine("类型" + itemList[i].type + "    品质" + itemList[i].quality + "    名称" + itemList[i].name);
            }
            Console.WriteLine("**************");
            #endregion

            #region 3更进一步按照名称长度排序
            //进一步按照名称长度排序
            baseline = 0;
            itemListTemp = new List<Item>();
            for (int i = 0; i < itemList.Count - 1; i++)
            {
                if (i == baseline)
                {
                    itemListTemp.Add(new Item(itemList[i].type, itemList[i].quality, itemList[i].name));
                }
                if (itemList[i + 1].type == itemList[i].type && itemList[i + 1].quality == itemList[i].quality)
                {
                    itemListTemp.Add(new Item(itemList[i + 1].type, itemList[i + 1].quality, itemList[i + 1].name));
                    //判断是否到达最后一个元素
                    if (i == itemList.Count - 2)
                    {
                        itemListTemp.Sort((a, b) => { return a.name.Length > b.name.Length ? 1 : -1; });
                        for (int j = 0; j < itemListTemp.Count; j++)
                        {
                            itemList[baseline + j].type = itemListTemp[j].type;
                            itemList[baseline + j].quality = itemListTemp[j].quality;
                            itemList[baseline + j].name = itemListTemp[j].name;
                        }
                    }
                }
                else
                {
                    itemListTemp.Sort((a, b) => { return a.name.Length > b.name.Length ? 1 : -1; });
                    for (int j = 0; j < itemListTemp.Count; j++)
                    {
                        itemList[baseline + j].type = itemListTemp[j].type;
                        itemList[baseline + j].quality = itemListTemp[j].quality;
                        itemList[baseline + j].name = itemListTemp[j].name;
                    }
                    baseline = i + 1;
                    itemListTemp = new List<Item>();
                }
            }
            //输出物品信息
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine("类型" + itemList[i].type + "    品质" + itemList[i].quality + "    名称" + itemList[i].name);
            }
            Console.WriteLine("**************");
        }
        #endregion

        //随机生成字符串函数
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                result.Append(chars[index]);
            }

            return result.ToString();
        }
    }
}