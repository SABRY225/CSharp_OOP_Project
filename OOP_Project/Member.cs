using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    internal class Member
    {
       public int ID;
       public string Name;
        Book[] borrowedBooks;
        public Member(int _id,string _name)
        {
            ID = _id;
            Name = _name;
        }
       
    }
}
