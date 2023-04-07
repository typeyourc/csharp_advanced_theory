namespace 测试专用4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetInfo(012));
        }
        static string GetInfo(int num)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "零");
            dic.Add(1, "壹");
            dic.Add(2, "贰");
            dic.Add(3, "叁");
            dic.Add(4, "肆");
            dic.Add(5, "伍");
            dic.Add(6, "陆");
            dic.Add(7, "柒");
            dic.Add(8, "捌");
            dic.Add(9, "玖");

            string str = "";
            //得百位
            int b = num / 100;
            if (b != 0)
            {
                str += dic[b];
            }
            //得十位数
            int s = num % 100 / 10;
            if (s != 0 || str != "")
            {
                str += dic[s];
            }
            //得个位
            int g = num % 10;
            str += dic[g];

            return str;
        }
    }
}