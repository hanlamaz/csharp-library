using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StudentBook:Book
    {
        string area;
        public StudentBook(string writer,string name,string summary,string ISBN,string area):base(writer,name,summary,ISBN)
        {
            this.area = area;
        }
        public override string ToString()
        {
            return base.ToString()+"\nArea..:"+this.area;
        }
    }
}
