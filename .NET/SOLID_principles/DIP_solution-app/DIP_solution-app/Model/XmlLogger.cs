using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_solution_app.Model
{
    class XmlLogger:ILogger
    {
        public void Log(string logError)
        {
            Console.WriteLine("Printed error to XML File");
            Console.WriteLine(logError);
        }
    }
}
