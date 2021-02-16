using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_app
{
    [Serializable]
    class Contact
    {
        private string fname;
        private string lname;
        private long phone_no;
        private string email_id;
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public long Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
        public string Email_id
        {
            get { return email_id; }
            set { email_id = value; }
        }
        public Contact(string fname,string lname,long phone_no, string email_id)
        {
            this.fname = fname;
            this.lname = lname;
            this.phone_no = phone_no;
            this.email_id = email_id;
        }
    }
}
