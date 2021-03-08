using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_app
{
    abstract class Employee
    {
        protected float salary;
        protected string name;
        protected DateTime date;
        protected string designation;
        public float Salary
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public  DateTime Date
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public abstract float ComputeTotalSalary();
    }
}
