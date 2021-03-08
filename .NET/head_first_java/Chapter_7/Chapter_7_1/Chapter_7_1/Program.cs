using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            b1.move();
            b3.move();
            b2.move();
            Console.ReadKey();
        }
    }
    public class Boat
    {
        private int length;
        public void setLength(int len)
        {
            length = len;
        }
        public int getLength()
        {
            return length;
        }
        public void move()
        {
            Console.Write("drift ");
        }
    }
    public class Rowboat : Boat
    {
        public void rowTheboat()
        {
            Console.Write("stroke natasha");
        }
    }
    public class Sailboat : Boat
    {
        public void move()
        {
            Console.Write("hoist sail ");
        }
    }
}

