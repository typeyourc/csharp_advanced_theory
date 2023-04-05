namespace Lesson6_泛型约束
{
    //练习一：用泛型实现一个单例模式基类
    class BaseClass<T>
    {
        private static BaseClass<T> instance = new BaseClass<T>();
        public T t;
        private BaseClass()
        {

        }
        public static BaseClass<T> Instance
        {
            get
            {
                return instance;
            }
        }
    }
    class BaseClass1<T, U> where T : BaseClass<U>
    {
        private static BaseClass1<T,U> instance = new BaseClass1<T,U>();
        public T t;
        private BaseClass1() { }
        public static BaseClass1<T, U> Instance
        {
            get { return instance; }
        }
    }
    //class MyClass
    //{
    //    private MyClass()
    //    {

    //    }
    //}
    //class BaseClass2<T> where T : MyClass , new()
    //{
    //    private static T instance = new T();
    //    //private BaseClass2() { }
    //    public static T Instance
    //    {
    //        get { return instance; }
    //    }
    //}   

    public class SingleBase<T> where T : new()
    {
        private static T instance = new T();

        public static T Instance
        {
            get
            {
                return instance;
            }
        }
    }
    public class GameMgr : SingleBase<GameMgr>
    {

    }
    //练习二：用泛型，仿造ArrayList实现不确定数组类型的增删查改的
    class ArrayListMgr<T>
    {
        //public T[] t;

        //增
        public T[] Add(T[] t, T item)
        {
            T[] a = new T[t.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    a[i] = item;
                }
                else
                {
                    a[i] = t[i];
                }
            }
            return a;
        }

        //删
        public T[] Delete(T[] t, int index)
        {
            if (index < t.Length)
            {
                for (int i = index; i < t.Length - 1; i++)
                {
                    t[i] = t[i + 1];
                }
                T[] tmp = new T[t.Length - 1];
                for (int i = 0; i < tmp.Length; i++)
                {
                    tmp[i] = t[i];
                }
                t = tmp;
                return t;
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("错误的索引，删除失败");
                return t;
            }
        }
        //查
        public void Show(T[] t, int index)
        {
            if (index < t.Length)
            {
                Console.WriteLine(t[index]);
            }
            else
            {
                Console.WriteLine("错误的索引");
            }
        }
        //改
        public void Change(T[] t, int index, T value)
        {
            if (index < t.Length)
            {
                t[index] = value;
            }
            else
            {
                Console.WriteLine("错误的索引");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习一
            //BaseClass2<BaseClass> base = new BaseClass2<BaseClass>();
            
            //练习二
            ArrayListMgr<int> a = new ArrayListMgr<int>();
            int[] t = new int[3] { 1, 2, 3 };
            ArrayListMgr<string> b = new ArrayListMgr<string>();
            string[] arr = new string[3] { "a","b","c"};
            //查
            //a.Show(t, 2);
            //b.Show(arr, 2);
            //改
            //a.Change(t, 2, 9);
            //a.Show(t, 2);
            //删
            //a.Show(a.Delete(t, 2), 1);
            //增
            a.Add(t, 4);
            a.Show(t, 3);
            a.Show(a.Add(t, 4), 3);
            
            //练习一
            //BaseClass<int> a = BaseClass<int>.Instance;
            //a.t = 1;

            //BaseClass1<BaseClass<int>, int> a1 = BaseClass1<BaseClass<int>, int>.Instance;
        }

    }
}