using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_violation_app.Model
{
    class TxtLogger
    {
        public void Log(string error)
        {
            Console.WriteLine("Printed error to TXT file");
            Console.WriteLine(error);
        }
    }
}
