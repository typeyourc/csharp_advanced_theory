using System.Collections;
using System.Runtime.InteropServices;

namespace Lesson22_迭代器
{
    class CustomList : IEnumerable, IEnumerator
    {
        private int[] list;
        //从-1开始的光标 用于表示 数据得到了哪个位置
        private int position = -1;

        public CustomList(params int[] array)
        {
            list = array;
        }

        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }
        #endregion

        public object Current
        {
            get
            {
                return list[position];
            }
        }
        public bool MoveNext()
        {
            //移动光标
            ++position;
            //是否溢出 溢出就不合法
            return position < list.Length;
        }

        //reset是重置光标位置 一般写在获取 IEnumerator对象这个函数中
        //用于第一次重置光标位置
        public void Reset()
        {
            position = -1;
        }
    }
    class CustomList2 : IEnumerable
    {
        private int[] list;

        public CustomList2(params int[] array)
        {
            list = array;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("迭代器");
            #region 方式一:标准迭代器
            CustomList list = new CustomList(1, 2, 3, 4);
            foreach (int i in list) 
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 方式二:yeild return语法
            CustomList2 list2 = new CustomList2(7,8,9,10);
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}