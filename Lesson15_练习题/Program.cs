namespace Lesson15_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lambad表达式 练习题");
            //练习题：有一个函数，会返回一个委托函数，这个委托函数中只有一句打印代码
            //之后执行返回的委托函数时，可以打印出1~10
            //使用lambad表达式实现
            //Test()();

            //补充知识：当用有返回值的委托容器存储多个函数时，调用时如何获取多个返回值
            Func<string> funTest = () =>
            {
                Console.WriteLine("第一个函数");
                return "1";
            };
            funTest += () =>
            {
                Console.WriteLine("第二个函数");
                return "2";
            };
            funTest += () =>
            {
                Console.WriteLine("第三个函数");
                return "3";
            };
            Console.WriteLine(funTest());
            foreach (Func<string> item in funTest.GetInvocationList())
            {
                Console.WriteLine(item());
            }
        }
        static public Action Test()
        {
            Action action = null;
            for (int i = 1; i < 11; i++)
            {
                int index = i;
                action += () =>
                {
                    Console.WriteLine(index);
                };
            }
            return action;

        }
    }
}