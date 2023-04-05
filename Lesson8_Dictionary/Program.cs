namespace Lesson8_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region 练习二
            //练习二：计算每个字母出现的次数“Welcome to Unity World!”，使用字典存储，
            //最后遍历整个字典，不区分大小写
            string str2 = "Welcome to Unity World!";
            Dictionary<int, char> dictionary2 = new Dictionary<int, char>();
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] != ' ' && str2[i] != '!')
                {
                    dictionary2[i] = str2[i];
                }
            }
            foreach (var item in dictionary2.Keys)
            {
                Console.Write(item);
                Console.WriteLine(dictionary2[item]);
            }
            //int aASCII = Convert.ToInt32('a'); 
            //int zASCII = Convert.ToInt32('z');
            //int AASCII = Convert.ToInt32('A');
            //int ZASCII = Convert.ToInt32('Z');
            Dictionary<int, char> dictionary3 = new Dictionary<int, char>();
            int k = 0;
            int flag1;
            foreach (var item in dictionary2.Keys)
            {
                flag1 = 0;
                if (dictionary2[item] != ' ' && dictionary2[item] != '!')
                {
                    dictionary3.Add(k,dictionary2[item]);
                    for (int j = 0; j < dictionary3.Count - 1 && k != 0; j++)
                    {
                        if (dictionary3[j] == dictionary2[item])
                        {
                            dictionary3.Remove(k);
                            flag1 = 1;
                            break;
                        }
                    }
                    if (flag1 == 0)
                    {
                        k++;
                    }        
                }               
            }
            foreach (var item in dictionary3.Keys)
            {
                Console.Write(item);
                Console.Write(dictionary3[item]);
                int cishu = 0;
                foreach (var item1 in dictionary2.Keys)
                {
                    if (dictionary3[item] == dictionary2[item1])
                    {
                        cishu++;
                    }               
                }
                Console.WriteLine("出现了{0}次", cishu);
            }

            #endregion
            #region 练习一
            //练习一：使用字典存0~9大写汉字，输入三位数，返回大写
            //以下实现有个缺点，可以输入字符
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "零");
            dictionary.Add(1, "壹");
            dictionary.Add(2, "贰");
            dictionary.Add(3, "叁");
            dictionary.Add(4, "肆");
            dictionary.Add(5, "伍");
            dictionary.Add(6, "陆");
            dictionary.Add(7, "柒");
            dictionary.Add(8, "捌");
            dictionary.Add(9, "玖");
            //dictionary.Add(10, "拾");
            string str = Console.ReadLine();
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                //下面这个if里面是错误的，因为一旦输入字符，比如a，int.Parse是无法将其转为整形的，因为Parse要求其输入必须为标准整数才可以转
                //if (int.Parse(str[i].ToString()) >= 0 && int.Parse(str[i].ToString()) <= 9)
                //{

                //}
                //else
                //{
                //    flag = false;
                //    Console.WriteLine("请输入数字");
                //    break;
                //}
                //0的ASCII码是048,9的ASCII码是057,下面是一种用来判断字符是否是数字的方法,Convert.ToInt32(char)可以将char转为对应的ASCII码
                if (Convert.ToInt32(str[i]) < 48 || Convert.ToInt32(str[i]) > 57)
                {
                    flag = false;
                    Console.WriteLine("请输入数字");
                    break;
                }
            }
            if (str.Length > 3 && flag == true)
            {
                Console.WriteLine("请输入不超过三位的数");
            }
            else if (str.Length < 4 && flag == true)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    foreach (int item in dictionary.Keys)
                    {
                        //这里要注意，int.Parse要求要求其输入必须为标准整数才可以转
                        if (int.Parse(str[j].ToString()) == item)
                        {
                            Console.Write(dictionary[item]);
                            break;
                        }
                    }
                }
            }
        }
    }
    #endregion

}