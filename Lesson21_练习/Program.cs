using System.Reflection;
using System.Reflection.Metadata;

namespace Lesson21_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //加载一个指定程序集
            Assembly asembly = Assembly.LoadFrom(@"E:\Csharp\source\repos\3Csharp进阶(理论)\ClassLibrary\bin\Debug\ClassLibrary");

            //看看程序集中有哪些公共类
            Type[] types = asembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine(types[i]);
            }

            //加载程序集中的一个类
            Type player = asembly.GetType("ClassLibrary.Player");

            //利用上述加载的类实例化对象
            object playObj = Activator.CreateInstance(player);

            //得到特性类的Type
            Type attri = asembly.GetType("ClassLibrary.MyCustomAttribute");

            //得到这个类的某个成员变量，这里是name，注意是用加载的player类Get，而不是用实例化的对象Get
            FieldInfo fieldInfo = player.GetField("name");

            //测试这个成员的变量的属性是否为空，不为空就证明其有特性
            if (fieldInfo.GetCustomAttribute(attri) != null)
            {
                Console.WriteLine("非法操作");
            }
            else
            {
                //否则，修改其值
                fieldInfo.SetValue(playObj,"888");
            }
            Console.WriteLine(fieldInfo.GetValue(playObj));

        }
    }
}