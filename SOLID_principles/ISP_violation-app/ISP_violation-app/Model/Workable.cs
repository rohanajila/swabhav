using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_violation_app.Model
{
    abstract class Workable
    {
        public virtual void StartWork()
        {
            Console.WriteLine("Start Work");
        }
        public virtual void StopWork()
        {
            Console.WriteLine("Stop Work");
        }
        public virtual void StartEat()
        {
            Console.WriteLine("Start Eat");
        }
        public virtual void StopEat()
        {
            Console.WriteLine("Stop Eat");
        }
    }
}
