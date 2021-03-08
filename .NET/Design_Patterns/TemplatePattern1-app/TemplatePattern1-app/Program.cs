using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern1_app.Model;

namespace TemplatePattern1_app
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new TechnicalCourse();
            university.StartProcess();
            Console.WriteLine();
            university = new NonTechnicalCourse();
            university.StartProcess();
            Console.Read();
        }
    }
}
