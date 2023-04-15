using System.Reflection;

namespace Lesson20_练习
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //加载一个指定程序集
            Assembly asembly = Assembly.LoadFrom(@"E:\Csharp\source\repos\3Csharp进阶(理论)\ClassLibrary\bin\Debug\ClassLibrary");

            //加载程序集中的一个类
            Type player = asembly.GetType("ClassLibrary.Player");

            //实例化对象
            object playObj = Activator.CreateInstance(player);

            ////得到构造函数并执行
            //ConstructorInfo info = player.GetConstructor(new Type[0]);
            //info.Invoke(null);

            //得到方法
            MethodInfo show = player.GetMethod("ShowInfo");

            //调用方法
            show.Invoke(playObj, null);
        }
    }
}