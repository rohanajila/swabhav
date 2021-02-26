using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_violation_app.Model
{
    class Robots:Workable
    {
        public override void StartWork()
        {
            Console.WriteLine("Start Work");
        }
        public override void StopWork()
        {
            Console.WriteLine("Stop Work");
        }
        public override void StartEat()
        {
           
        }
        public override void StopEat()
        {
          
        }
    }
}
