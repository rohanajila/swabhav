using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rectangle_app
{
    public class Rectangle
    {
        private int height;
        private int width;
        private string color;

       
        public void setheight()
        {
            Console.WriteLine("Enter the height of the rectangle: ");
            height = int.Parse(Console.ReadLine());
            if (height < 1)
                height = 1;
            if (height > 100)
                height = 100;
        }
        public void setwidth()
        {
            Console.WriteLine("Enter the width of the rectangle: ");
            width = int.Parse(Console.ReadLine());
            if (width < 1)
                width = 1;
            if (width > 100)
                width = 100;
        }
        public void setcolor()
        {
            Console.WriteLine("Enter the color of the rectangle: ");
            color = Console.ReadLine();
            if(!color.Equals("red")|| !color.Equals("blue")|| !color.Equals("green"))
            {
                color = "black";
            }
        }
        public int getheight()
        {
            return height;
        }
        public int getwidth()
        {
            return width;
        }
        public string getcolor()
        {
            return color;
        }
    }
}