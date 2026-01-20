using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    internal class Book
    {
        public int Id;
        public string Title;
        public string Author;
        public bool IsAvailable;

        public Book(int _id, string _title,string _author)
        {
            Id = _id;
            Title = _title;
            Author = _author;
            IsAvailable = true;
        }
    }
}
