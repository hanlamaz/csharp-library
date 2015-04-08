using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CD:ICanbelookup,ICanbeborrow
    {
        string name;

        public string Name
        {
            get { return name; }
        }
        string type;
        string summary;
        DateTime borrowdate;
        bool borrowComplete;

        public bool BorrowComplete
        {
            get { return borrowComplete; }
        }
        public string ToString()
        {
            return "Name" + this.name;
        }
        public CD(string name,string type,string summary)
        {
            this.name = name;
            this.type = type;
            this.summary = summary;

        }
        public string Lookup()
        {
            return summary;
        }

        public void BorrowIt(DateTime date)
        {
            borrowdate = date;
            borrowComplete = true;
        }


        public void ToReturn()
        {
            borrowComplete = false;
        }
    }
}
