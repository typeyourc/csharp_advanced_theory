#define name
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //申明特性
    class MyCustomAttribute : Attribute
    {
        //特性中的成员 一般根据需求来写
        public string info;

        public MyCustomAttribute(string info)
        {
            this.info = info;
        }

        public void TestFun()
        {
            Console.WriteLine("特性的方法");
        }
    }
    public class Player
    {      
        [MyCustom("这个是我自己写的Player类的成员变量的属性")]
        public string name;
        public int hp;
        public int atk;
        public int def;
        public int x;
        public int y;

        public Player()
        {
            name = "player";
            hp = 100;
            atk = 10;
            def = 10;
            x = 0;
            y = 0;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:{0},HP:{1},ATK:{2},DEF:{3},X:{4},Y:{5}", name, hp, atk, def, x, y);
        }
    }
}
