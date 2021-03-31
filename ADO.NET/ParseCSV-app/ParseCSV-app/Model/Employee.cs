using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseCSV_app.Model
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public double MgrId { get; set; }
        public string DOB { get; set; }
        public double Salary { get; set; }
        public double Comm { get; set; }
        public int DeptNo { get; set; }

        internal static Employee ParseRow(string row)
        {
            var columns = row.Split(',');
            return new Employee()
            {
                EmpNo = int.Parse(columns[0]),
                EName = columns[1],
                Job = columns[2],
                MgrId = double.Parse(columns[3]),
                DOB = columns[4],
                Salary = double.Parse(columns[5]),
                Comm = double.Parse(columns[6]),
                DeptNo = int.Parse(columns[7])
            };
        }
    }
}
