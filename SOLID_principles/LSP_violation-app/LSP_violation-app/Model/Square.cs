using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_violation_app.Model
{
    class Square:Rectangle
    {
        private int side;

        public Square(int side) : base(side, side)
        {
            this.side = side;
        }


        public override int Length { get => this.side; set => this.side=base.Length ; }

        public override int Breadth { get => this.side; set => this.side=base.Breadth; }
    }
}
