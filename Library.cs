using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Library
    {
        ArrayList inventory = new ArrayList();
        //public void AddBook(Book b)
        //{
        //    inventory.Add(b);
        //}
        //public void AddCD(CD cd)
        //{
        //    inventory.Add(cd);
        //}
        //public void Add(Object o)
        //{
        //    inventory.Add(o);
        //}
        public void Add(ICanbelookup object1)
        {
            inventory.Add(object1);
        }
        public object Search(string name)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if(inventory[i] is Book)
                {
                    if (((Book)inventory[i]).Name==name)
                    {
                        return inventory[i];
                    }
                }
                else if (((CD)inventory[i]).Name == name)
                    return inventory[i];
            }
            return null;
        }
        public void BorrowIt(string name)
        {
            ICanbeborrow object1 = (ICanbeborrow)Search(name);
            if(object1!=null)
            
            object1.BorrowIt(DateTime.Now);
            else
            {
                Console.WriteLine("There is no CD or any type of book has found");
            }
            //Object o = Search(name);

        }
        public void BorrowBack(string name)
        {
            ICanbeborrow object1 = (ICanbeborrow)Search(name);
            if (object1 != null)

                object1.ToReturn();
          
        }
        public void LookupInventory()
        {
            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine(((ICanbelookup)inventory[i]).Lookup());
            //}
            foreach(ICanbelookup item in inventory)
            {
                Console.WriteLine(item.Lookup());
            }
        }
    }
}
