namespace Lesson10_Linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linkedlist");
            //练习题：使用Linkedlist，向其中加入10个随机整形变量
            //正向遍历一次打印输出信息
            //反向遍历一次打印输出信息
            LinkedList<int> list = new LinkedList<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(r.Next(0,100));
            }
            Console.WriteLine("正向输出");
            LinkedListNode<int> node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine("反向输出");
            node = list.Last;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;
            }
        }
    }
}