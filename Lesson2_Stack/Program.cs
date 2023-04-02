using System.Collections;
using System.Transactions;

namespace Lesson2_Stack
{
    internal class Program
    {
        public static void TransToBinary(uint a)
        {
            //除以2之后的商
            uint b;
            //除以2之后的余数
            uint c;
            Stack stack = new Stack();

            do
            {
                b = a / 2;
                c = a % 2;
                stack.Push(c);
                a = b;
            } while (b >= 1);

            foreach (object item in stack)
            {
                Console.Write(item);
            }
            
            //if (a > 1)
            //{
            //    b = a / 2;
            //    c = a % 2;
            //    stack.Push(c);
            //}    
        }
        public static uint TransToBinary2(uint a,Stack stack)
        {
            //除以2之后的商
            uint b;
            //除以2之后的余数
            uint c;

            if (a >= 1)
            {
                b = a / 2;
                c = a % 2;
                stack.Push(c);
                a = b;
                TransToBinary2(a, stack);
            }
            return 0;

        }
        static void Main(string[] args)
        {
            //练习一：栈存储的特点：先进后出 
            //练习二：任意数的二进制计算方法
            //TransToBinary(1024);

            Stack stack = new Stack();
            TransToBinary2(100, stack);
            foreach (object item in stack)
            {
                Console.Write(item);
            }

            //Console.WriteLine("Hello, World!");
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Count);

            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //object[] array = stack.ToArray();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
        }
    }
}