using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseCSV_app.Model
{
    class Department
    {
        public int DeptNo { get; set; }
        public string DName { get; set; }
        public string Loc { get; set; }
        internal static Department ParseRow(string row)
        {
            var columns = row.Split(',');
            return new Department()
            {
                DeptNo = int.Parse(columns[0]),
                DName = columns[1],
                Loc = columns[2]
                
            };
        }
    }
}
