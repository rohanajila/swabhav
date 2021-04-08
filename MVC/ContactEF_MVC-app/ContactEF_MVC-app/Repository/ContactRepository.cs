using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactEF_MVC_app.Service;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.Repository
{
    public class ContactRepository
    {
        public ContactDbContext db;

        public ContactRepository(ContactDbContext db)
        {
            this.db = db;
        }

        public void AddContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public void DeleteContact(int id)
        {
            db.Contacts.Remove(db.Contacts.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditContact(Contact c)
        {
            Contact contact = db.Contacts.Where(x => x.ID == c.ID).SingleOrDefault();
            contact.FirstName = c.FirstName;
            contact.LastName = c.LastName;
            contact.PhoneNo = c.PhoneNo;
            contact.Address = c.Address;
            db.SaveChanges();
        }

        public Contact GetContactByID(int id)
        {
            return db.Contacts.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Contact> GetContacts()
        {
            return db.Contacts.ToList();
        }

        public List<Contact> SearchContact(string name)
        {
            List<Contact> serachContacts = new List<Contact>();
            foreach (var contact in db.Contacts)
            {
                if (contact.FirstName.ToLower().Equals(name.ToLower()) || contact.FirstName.ToLower().Equals(name.ToLower()))
                {
                    serachContacts.Add(contact);
                }
            }
            return serachContacts;
        }
    }
}