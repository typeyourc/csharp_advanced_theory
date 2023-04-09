using System.Runtime.InteropServices;

namespace Lesson13_事件
{
    //练习：有一个热水器，包含一个加热器，一个报警器，一个显示器，我们给热水器通上电，当水温超过95度时
    //1.报警器会开始发出语音，告诉你水温度
    //2.显示器也会改变水温提示，提示水已经烧开了
    class WaterHeater
    {
        public Heater heater = new Heater();
        public Alarm alarm = new Alarm();
        public Display display = new Display();

        public event Action action;

        public WaterHeater()
        {
            action += heater.BoilWater;
            action += alarm.MakeAlert;
            action += display.ShowMsg;
        }

        public void BoilWater()
        {
            Console.WriteLine("烧开水");

            if (action != null)
            {
                action();
            }
        }

    }
    class Heater
    {
        public void BoilWater()
        {
            Console.WriteLine("加热到95度");
        }
    }
    class Alarm
    {
        public void MakeAlert()
        {
            Console.WriteLine("水温已经超过95度");
            Console.WriteLine("水温是多少度11");
        }
    }
    class Display
    {
        public void ShowMsg()
        {
            Console.WriteLine("水已经烧开了");
            Console.WriteLine("水温是多少度22");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("事件");

            WaterHeater wheater = new WaterHeater();
            wheater.BoilWater();
        }
    }
}