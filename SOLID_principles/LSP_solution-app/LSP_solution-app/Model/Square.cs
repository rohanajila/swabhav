using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_solution_app.Model
{
    class Square:IShape
    {
        private int _side;
        public int Side { get => _side; set => _side = value; }
        public Square(int side)
        {
            _side = side;
        }
        public int CalculateArea()
        {
            int area = Side * Side;
            return area;
        }
    }
}
