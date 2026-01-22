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
       public Book[] borrowedBooks;
       public int borrowCount = 0;
       
        public Member(int _id,string _name)
        {
            ID = _id;
            Name = _name;
            borrowedBooks = new Book[10];
        }
         public int addBorrowedBooks(Book book)
        {
            if(borrowCount < borrowedBooks.Length)
            {
                borrowedBooks[borrowCount] = book;
                borrowCount++;
                return borrowCount;
            }
            return 0;
        }
        public int GetBorrowedCount()
        {
            return borrowCount;
        }


    }
}
