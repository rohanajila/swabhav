using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_app
{
    class Circle
    {
        private float radius;
        private string color;
        private int maxRadius;
        private int maxArea;
        public Circle()
        {
            maxArea = 0;
            maxRadius = 0;
        }
        public float Radius
        {
            set { radius = value; }
            get { return radius; }
        }
        public int MaxRadius
        {
            set { maxRadius = value; }
            get { return maxRadius; }
        }
        public int MaxArea
        {
            set { maxArea = value; }
            get { return maxArea; }
        }
        public string Color
        {
            set
            {
                color = value;
                if(color.Equals("red")|| color.Equals("green")|| color.Equals("blue"))
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
