using System.Reflection;

namespace Lesson20_反射
{
    class Test
    {
        private int i = 1;
        public int j = 0;
        public string str = "123";
        public Test()
        {

        }

        public Test(int i)
        {
            this.i = i;
        }

        public Test(int i, string str) : this(i)
        {
            this.str = str;

        }

        public void Speak()
        {
            Console.WriteLine(i);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Type t = typeof(Test);

            //ConstructorInfo info2 = t.GetConstructor(new Type[] { typeof(int) });
            //Test obj = info2.Invoke(new object[] { 2 }) as Test;
            //Console.WriteLine(obj.str);

            Type strType = typeof(string);
            MethodInfo[] methods = strType.GetMethods();
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i]);
            }
            MethodInfo subStr = strType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            string str = "Hello,World!";
            object sub = subStr.Invoke(str, new object[] { 2, 3 });
            Console.WriteLine(sub);
        }
    }
}