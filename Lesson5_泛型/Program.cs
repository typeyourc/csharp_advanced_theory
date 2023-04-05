namespace Lesson5_泛型
{
    class TestType
    {
        public void Type<T>()
        {
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine("整形，4字节");
            }
            else if (typeof(T) == typeof(char))
            {
                Console.WriteLine("字符形，2字节");
            }
            else if (typeof(T) == typeof(float))
            {
                Console.WriteLine("单精度浮点形，4字节");
            }
            else if (typeof(T) == typeof(string))
            {
                Console.WriteLine("字符串，不确定字节");
            }
            else
            {
                Console.WriteLine("其它类型");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestType testType = new TestType();
            testType.Type<string>();
            testType.Type<Program>();

        
        }
    }
}