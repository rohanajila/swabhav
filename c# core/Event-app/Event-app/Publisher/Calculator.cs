using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_app.Publisher
{
    public delegate void DCalcOperationAlert(int x, int y, int answer);
    
    public class Calculator
    {
        public event DCalcOperationAlert AdditionCompleted = null;
        public void Add(int x,int y)
        {
            if(AdditionCompleted!=null)
            AdditionCompleted(x, y, (x + y));
        }
    }
}
