using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_violation_app.Model
{
    class Rectangle
    {
        public int _length;
        public int _breadth;
        public virtual int  Length { get => _length; set => _length = value; }
        public virtual int  Breadth { get => _breadth; set => _breadth = value; }
        public Rectangle(int length,int breadth)
        {
            _length = length;
            _breadth = breadth;
        }
        public int CalculateArea()
        {
            int area = 0;
            area = Length * Breadth;
            return area;
        }
    }
}
