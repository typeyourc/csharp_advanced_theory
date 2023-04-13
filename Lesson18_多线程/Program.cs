using System.ComponentModel;

namespace Lesson18_多线程
{
    class Window
    {
        public int width;
        public int height;
        public Window(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void InitWindow()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(this.width, this.height);
            Console.SetBufferSize(this.width, this.height);
        }
    }
    struct Vector
    {
        public int x;
        public int y;
    }

    class Snake
    {
        public Vector v;
        public static char direction;

        public Snake()
        {
            v = new Vector();
            direction = 'd';
        }
        //绘制函数，type为1绘制方块，type为0绘制空(擦除)
        public void Draw(int x, int y, int type)
        {
            Console.SetCursorPosition(x, y);
            if (type == 1)
            {
                Console.Write("■");
            }
            else
            {
                Console.Write("  ");
            }
        }
        public void Move()
        {
            //清除原先位置
            Draw(v.x, v.y, 2);
            //移动
            switch (direction)
            {
                case 'a':
                    v.x -= 2;
                    break;
                case 'd':
                    v.x += 2;
                    break;
                case 'w':
                    v.y -= 1;
                    break;
                case 's':
                    v.y += 1;
                    break;
                //default:
                //    break;
            }
            Draw(v.x, v.y, 1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多线程练习题");
            //练习：控制台中有一个■，它会如贪食蛇一样自由移动，用多线程检测输入控制转向
            //绘制窗口
            Window w = new Window(80, 25);
            w.InitWindow();
            //绘制方块
            Snake s = new Snake();
            s.v.x = 10;
            s.v.y = 20;
            s.Draw(s.v.x, s.v.y, 1);

            //检测输入和移动方块
            //Thread t = new Thread(Input);
            while (true)
            {
                Thread t = new Thread(Input);
                t.Start();
                s.Move();
                Thread.Sleep(200);
                t = null;
            }
        }
        static void Input()
        {
            Snake.direction = Console.ReadKey(true).KeyChar;
        }
    }
}