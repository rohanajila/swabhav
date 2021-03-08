using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_violation_app.Model
{
    class XmlLogger
    {
        public void Log(string logError)
        {
            Console.WriteLine("Printed error to XML File");
            Console.WriteLine(logError);
        }
    }
}
