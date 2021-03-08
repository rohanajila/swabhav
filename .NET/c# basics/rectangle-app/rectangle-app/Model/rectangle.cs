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

       
        public int Height
        {
            set
            {
                height = value;
                if (height < 1)
                    height = 1;
                if (height > 100)
                    height = 100;
            }
            get { return height; }
        }
        public int Width
        {
            set
            {
                width = value;
                if (width < 1)
                    width = 1;
                if (width > 100)
                    width = 100;
            }
            get { return width; }
           
        }
        public string Color
        {
            set
            {
                color = value;
                if (color.Equals("red") || color.Equals("blue") || color.Equals("green"))
                {
                    color = value;
                }
                else
                    color = "black";
            }
            get { return color; }
        }
       
    }
}