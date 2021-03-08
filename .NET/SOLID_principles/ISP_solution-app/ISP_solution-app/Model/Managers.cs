using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_solution_app.Model
{
    class Managers:IWork,IEat
    {
        public void StartWork()
        {
            Console.WriteLine("Start Work");
        }
        public  void StopWork()
        {
            Console.WriteLine("Stop Work");
        }
        public void StartEat()
        {
            Console.WriteLine("Start Eat");
        }
        public  void StopEat()
        {
            Console.WriteLine("Stop Eat");
        }
    }
}
