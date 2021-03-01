using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_solution_app.Model
{
    class TxtLogger:ILogger
    {
        public void Log(string error)
        {
            Console.WriteLine("Printed error to TXT file");
            Console.WriteLine(error);
        }
    }
}
