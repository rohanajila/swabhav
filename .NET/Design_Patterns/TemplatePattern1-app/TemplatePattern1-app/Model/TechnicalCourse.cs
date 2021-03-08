using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern1_app.Model
{
    class TechnicalCourse:University
    {
        public override void FillForm()
        {
            Console.WriteLine("Form Fill for Technical stream in progress");
        }
        public override void GetList()
        {
            Console.WriteLine("List of Students selected for Technical stream generated.");
        }
        public override void FeePayment()
        {
            Console.WriteLine("Fee Payment in Technical Institutes started!");
        }
    }
}
