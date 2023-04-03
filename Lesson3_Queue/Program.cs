using System.Collections;

namespace Lesson3_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Queue queue = new Queue();
            Queue queue1 = new Queue();
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            queue1.Enqueue(4);
            queue1.Enqueue(5);
            queue1.Enqueue(6);
            queue1.Enqueue(7);
            queue1.Enqueue(8);
            queue1.Enqueue(9);
            queue1.Enqueue(10);
            Console.WriteLine(queue1.Count);
            int a = queue1.Count;
            long i = 0;
            long j = 0;
            while (j < a) 
            {
                if (i % 10000000 == 0)
                {
                    Console.WriteLine(queue1.Dequeue());
                    j++;
                }          
                i++;
            }

        }
    }
}