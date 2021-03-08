using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_solution_app.Model
{
    class Rectangle : IShape
    {
        private int _length;
        private int _breadth;
        public int Length { get => _length; set => _length = value; }
        public int Breadth { get => _breadth; set => _breadth = value; }
        public Rectangle(int length, int breadth)
        {
            _length = length;
            _breadth = breadth;
        }
        public int CalculateArea()
        {
            int area = Length * Breadth;
            return area;
        }
           
    }
}
