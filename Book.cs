using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Book:ICanbeborrow,ICanbelookup
    {
        DateTime givenDate;
        string writer;
        string name;

        public string Name
        {
            get { return name; }
        }
        bool borrowComplete;
        public bool BorrowComplete
        {
            get { return borrowComplete; }
        }
        string summary;
        string ISBN;
        public Book(string writer,string name,string summary,string ISBN)
        {
            this.writer = writer;
            this.name = name;
            this.summary = summary;
            this.ISBN = ISBN;
        }
        public virtual string ToString()
        {
            return "Name..:" +this.name+ "\nWriter..:" + this.writer;
        }

        public void BorrowIt(DateTime date)
        {
            givenDate = date;
            borrowComplete = true;
        }

        public string Lookup()
        {
            return summary;
        }


        public void ToReturn()
        {
            borrowComplete = false;
        }
    }
}
