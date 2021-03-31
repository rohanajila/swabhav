using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreEF_app.DBContext;
using ContactStoreEF_app.Model;

namespace ContactStoreEF_app.Repository
{
    class ContactEFRepository:IContactRepository
    {
        private const int FIRSTNAME = 1;
        private const int LASTNAME = 2;
        private const int PHONENO = 3;

        public ContactDbContext contactDB;

        public ContactEFRepository(ContactDbContext contactDB)
        {
            this.contactDB = contactDB;
        }

        public List<Contact> GetContacts()
        {
            return contactDB.Contacts.ToList();
        }
        public List<Contact> SearchContact(string name)
        {
            List<Contact> contacts = new List<Contact>();
            foreach(Contact c in contactDB.Contacts)
            {
                if(c.FirstName.ToLower().Equals(name.ToLower())||c.LastName.ToLower().Equals(name.ToLower()))
                {
                    contacts.Add(c);
                }
            }
            return contacts;
        }
        public void AddContact(Contact c)
        {
            contactDB.Contacts.Add(c);
            contactDB.SaveChanges();
            
        }
        public void EditContact(int choice, int id, string modification)
        {
            foreach(Contact c in contactDB.Contacts)
            {
                if(c.Id==id)
                {
                    if(choice==FIRSTNAME)
                    {
                        c.FirstName = modification;
                    }
                    else if(choice==LASTNAME)
                    {
                        c.LastName = modification;
                    }
                    else if(choice==PHONENO)
                    {
                        c.PhoneNo = long.Parse(modification);
                    }
                }
            }
        }
        public void DeleteContact(int id)
        {
            foreach(Contact c in contactDB.Contacts)
            {
                if(c.Id==id)
                {
                    contactDB.Contacts.Remove(c);
                }
            }
        }
    }
}
