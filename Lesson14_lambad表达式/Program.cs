namespace Lesson15_lambad表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lambad表达式");
            ////1.无参无返回
            //Action action;
            //action = () => 
            //{ 
            //    Console.WriteLine("无参无返回-lambad表达式"); 
            //};
            //action();
            ////2.有参
            //Action<int> action2 = (int value) => { Console.WriteLine(value); };
            //action2(4);
            ////3.甚至参数类型都可以省略 参数类型和委托或事件容器一致
            //Action<int> action3 = (value) => { Console.WriteLine(value); };
            //action3(5);
            ////4.有返回值
            //Func<int, int, int> func = (x, y) => { return x + y; };
            //Console.WriteLine(func(1, 2));

            Test test = new Test();
            test.DoSomeThing();
        }
    }
    class Test
    {
        public event Action action;

        public Test()
        {
            int value = 10;

            action = () =>
            {
                Console.WriteLine(value);
            };

            for (int i = 0; i < 12; i++)
            {
                //int index = i;
                action += () =>
                {
                    int index = i;
                    Console.WriteLine(index);
                };
            }
        }

        public void DoSomeThing()
        {
            action();
        }
    }
}