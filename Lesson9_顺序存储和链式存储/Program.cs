using System.Collections.Generic;

namespace Lesson9_顺序存储和链式存储
{
    /// <summary>
    /// 双向链表单个节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedNode<T>
    {
        public T value;
        //这两个存储上一个元素和下一个元素 相当于钩子
        public LinkedNode<T> lastNode;
        public LinkedNode<T> nextNode;
        public int index;

        public LinkedNode(T value)
        {
            this.value = value;
        }
    }
    /// <summary>
    /// 双向链表类 尾部增加节点、指定位置删除节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList<T>
    {
        //结点总个数
        public int count;
        //定义一个头结点，一个尾结点
        public LinkedNode<T> head;
        public LinkedNode<T> foot;

        public void AddFoot(T value)
        {
            //添加节点 必然是new一个新的节点
            LinkedNode<T> node = new LinkedNode<T>(value);
            if (head == null)
            {
                head = node;
                head.index = 0;
                foot = node;
                foot.index = 0;
            }
            else
            {
                //在这个else里，为什么直接可以用foot.xxx，因为这个链表如果增加过头部foot肯定是存在的了，
                //最少的情况下也是food = head
                foot.nextNode = node;
                node.index = foot.index + 1;
                node.lastNode = foot;
                foot = node;
            }
            count++;
        }
        public void RemoveAt(int index)
        {
            if (head == null)
            {
                return;
            }
            if (head.index.Equals(index))
            {
                head = head.nextNode;
                head.lastNode = null;
                //如果头节点 被移除 发现头节点变空
                //证明只有一个节点 那尾也要清空
                if (head == null)
                {
                    foot = null;
                }
                return;
            }
            LinkedNode<T> node = head;
            //因为里面要做==index的判断，所以要先判断一下node.nextNode是否为空
            while (node.nextNode != null)
            {
                if (node.nextNode.index == index) 
                {
                    //注意判断空的情况是指尾节点刚好是要删除的索引节点的情况
                    if (node.nextNode.nextNode != null)
                    {
                        //让当前找到的这个元素的 上一个节点
                        //指向 自己的下一个节点
                        node.nextNode.nextNode.lastNode = node;
                    }
                    else
                    {
                        foot = node;
                    }
                    node.nextNode = node.nextNode.nextNode;
                    break;
                }
                node = node.nextNode;
            }
            node = head;
            while (node != null)
            {
                if (node.index >index)
                {
                    node.index--;
                }
                node = node.nextNode;
            }          
            count--;
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("顺序存储和链式存储");
            //练习一：常用的数据结构：数组、栈、队列、哈希表？、树、图、堆、散列表
            //练习二：数组的顺序存储和链式存储：增、删、查、改
            //练习三：实现一个双向链表，提供属性：数据的个数、头结点、尾结点，提供方法：增加数据到链表最后、删除指定位置结点
            LinkedList<int> link = new LinkedList<int>();
            link.AddFoot(1);
            link.AddFoot(2);
            link.AddFoot(3);
            link.AddFoot(4);
            link.AddFoot(5);
            LinkedNode<int> node = link.head;
            while (node != null)
            {
                Console.Write("数据{0}",node.value);
                Console.WriteLine("索引{0}", node.index);
                node = node.nextNode;
            }
            Console.WriteLine("数据的个数为{0}", link.count);
            Console.WriteLine("-----------------");

            link.RemoveAt(3);
            node = link.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
            Console.WriteLine("数据的个数为{0}", link.count);

            Console.WriteLine("详细数据如下，索引对照值-----------------");

            node = link.head;
            while (node != null)
            {
                Console.Write("数据{0}", node.value);
                Console.WriteLine("索引{0}", node.index);
                node = node.nextNode;
            }

            Console.WriteLine("反向遍历，详细数据如下，索引对照值-----------------");

            node = link.foot;
            while (node != null)
            {
                Console.Write("数据{0}", node.value);
                Console.WriteLine("索引{0}", node.index);
                node = node.lastNode;
            }
        }
    }
}