using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithObjects
{
    class Employee
    {
        private int _id;
        private string _name;
        private long _salary;
        private string _designation;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public long Salary { get => _salary; set => _salary = value; }
        public string Designation { get => _designation; set => _designation = value; }

        public Employee(int id,string name,long salary,string designation)
        {
            _id = id;
            _name = name;
            _salary = salary;
            _designation = designation;
        }
    }
}
