using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    internal class Library
    {
        Book[] books;
        private int bookCount;

        Member[] members;
        int index = 0;
        public Library()
        {
            members = new Member[50];
            books = new Book[50];
            bookCount = 0;
        }
        public void addMember(Member member)
        {
            for (int i = 0; i < index; i++)
            {
                if(members[i].ID == member.ID)
                {
                    Console.WriteLine("This ID already exists");
                    return ;
                }

            }
            if (index < members.Length )
            {
                members[index] = member;
                index++;
                Console.WriteLine($"Member '{member.Name}' added successfully.");
            }
            else
            {
                Console.WriteLine($"cannot add more members in the library.");

            }
        }
        public void removeMember(int id)
        {
           
            for (int i = 0; i < index; i++)
            {
                string memberName = members[i].Name;
                if (members[i].ID == id)
                {
                   members[i] = members[index-1];
                   members[index-1] = null;
                   index--;
                   Console.WriteLine($"Member '{memberName}' removed successfully.");
                   return;
                }

            }
            Console.WriteLine($"Member with ID {id} not found.");

        }
        public void listMemebers()
        {
            if(index == 0 )
            {
                Console.WriteLine("No members found.");
            }
            else
            {
                Console.WriteLine("Library Members:");
                for (int i = 0; i < index; i++)
                {
                    if (members[i] != null)
                    {
                        Console.WriteLine($"ID: {members[i].ID} ,Name: {members[i].Name}");
                    }
                }
            }
            
         
        }

        #region Add, Remove and List Book
        // Add Book
        public void AddBook(Book book)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Id == book.Id)
                {
                    Console.WriteLine($"Book with this ID:{book.Id} already exists.");
                    return;
                }
            }

            books[bookCount] = book;
            bookCount++;
            Console.WriteLine($"Book '{book.Title}' added successfully.");
        }


        // Remove Book
        public void RemoveBook(int bookId)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Id == bookId)
                {
                    Console.WriteLine($"Book '{books[i].Title}' removed successfully.");

                    for (int j = i; j < bookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }

                    bookCount--;
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        // List Books
        public void ListBooks()
        {
            Console.WriteLine("Books in Library:");

            if (bookCount == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine(
                    $"ID: {books[i].Id},\nTitle: {books[i].Title},\nAuthor: {books[i].Author},\nAvailable: {books[i].Availabe()}"
                );
            }
        }

        #endregion
    }
}
