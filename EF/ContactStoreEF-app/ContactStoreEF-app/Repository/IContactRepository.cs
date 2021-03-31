using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreEF_app.Model;

namespace ContactStoreEF_app.Repository
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();
        List<Contact> SearchContact(string name);
        void AddContact(Contact c);
        void EditContact(int choice, int id, string modification);
        void DeleteContact(int id);
    }
}
