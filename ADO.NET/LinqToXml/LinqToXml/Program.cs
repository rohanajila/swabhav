using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string> names = from employees in
                         XDocument.Load(@"C:\swabhav\ADO.NET\employeesDetails.xml")
                                   .Descendants("Employee")
                                        select employees.Element("Name").Value, orderby ;


            foreach (string strName in names)
            {
                Console.WriteLine(strName);
            }

            Console.ReadLine();
        }
    }
}
