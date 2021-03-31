using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAddressEF_app.Model
{
    [Table("Employee")]
    class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public virtual List<Address> EAddress { get; }
        public Employee()
        {
            EAddress = new List<Address>();
        }
    }
}
