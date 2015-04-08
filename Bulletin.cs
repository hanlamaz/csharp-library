using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bulletin:Book
    {
        string type;
        public Bulletin(string writer,string name,string summary,string ISBN,string type):base(writer,name,summary,ISBN)
        {
            this.type = type;
        }
        public override string ToString()
        {
            return base.ToString()+"\nType..:"+this.type;
        }
    }
}
