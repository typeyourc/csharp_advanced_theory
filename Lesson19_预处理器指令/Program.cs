#define Unity5
#define Unity2017
#define Unity2020
#undef Unity2017
#undef Unity2020

namespace Lesson19_预处理器指令
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("预处理器指令");
            //练习一：说出四种预处理器执行
            //#define #undef #warning #error #if #elif #else #endif

            //练习二：
            Console.WriteLine(Calc(2, 3));

        }
        static int Calc(int a,int b)
        {
#if Unity5 
            return a + b;
#elif Unity2017
            return a * b;
#elif Unity2020
            return a - b;
#else
            return 0;
#endif
        }
    }
}