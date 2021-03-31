using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework1_app.Model
{
    [Table("Dept")]
    public class Dept
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual List<Emp> DeptEmployees { get; }

        public Dept()
        {
            DeptEmployees = new List<Emp>();
        }


    }
}
