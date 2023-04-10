namespace Lesson14_匿名函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("匿名函数");
            Test t = new Test();
            //相当于返回匿名函数再直接执行匿名函数
            t.GetFun()();
        }
    }
    class Test
    {
        //作为返回值
        public Action GetFun()
        {
            return delegate () {
                Console.WriteLine("函数内部返回的一个匿名函数逻辑");
            };
        }
    }
}