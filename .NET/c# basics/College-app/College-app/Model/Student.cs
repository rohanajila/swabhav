using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_app.Model
{
    class Student
    {
        private College college;
        private string studentName;
        private string studentId;
        private char division;
        public College getcollege
        {
            get { return college; }
        }
        public string StudentName
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public char Division
        {
            get { return division; }
            set { division = value; }
        }
        public Student(College college,string studentName,string studentId,char division)
        {
            this.college = college;
            this.studentName = studentName;
            this.StudentId = studentId;
            this.division = division;
        }
    }
}
