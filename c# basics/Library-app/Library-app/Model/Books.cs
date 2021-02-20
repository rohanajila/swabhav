using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_app.Model
{
    class Books
    {
        private Library library;
        private string bookName;
        private string bookId;
        private DateTime issueDate;
        public Library getlibrary
        {
            get { return library; }
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }
        public Books(Library library,string bookName,string bookId,DateTime issueDate)
        {
            this.library = library;
            this.bookName = bookName;
            this.bookId = bookId;
            this.issueDate = issueDate;
        }

    }
}
