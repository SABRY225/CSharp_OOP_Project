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
        int memberCount = 0;
        public Library()
        {
            members = new Member[50];
            books = new Book[50];
            bookCount = 0;
        }

        #region Add, Remove and List Member
        // Add Member
        public void AddMember(Member member)
        {
            for (int i = 0; i < memberCount; i++)
            {
                if(members[i].ID == member.ID)
                {
                    Console.WriteLine("This ID already exists");
                    return ;
                }

            }
            if (memberCount < members.Length )
            {
                members[memberCount] = member;
                memberCount++;
                Console.WriteLine($"Member '{member.Name}' added successfully.");
            }
            else
            {
                Console.WriteLine($"cannot add more members in the library.");

            }
        }

        // Remove Member
        public void RemoveMember(int id)
        {
           
            for (int i = 0; i < memberCount; i++)
            {
                if (members[i].ID == id)
                {
                    Console.WriteLine($"Member '{members[i].Name}' removed successfully.");
                    for (int j = i; j < memberCount-1; j++)
                    {
                        members[j] = members[j + 1];
                    }
                    memberCount--;
                   return;
                }

            }
            Console.WriteLine($"Member with ID {id} not found.");
        }

        // List Member
        public void ListMembers()
        {
            if(memberCount == 0 )
            {
                Console.WriteLine("No members found.");
            }
            else
            {
                Console.WriteLine("Library Members:");
                for (int i = 0; i < memberCount; i++)
                {
                    if (members[i] != null)
                    {
                        Console.WriteLine($"ID: {members[i].ID} ,Name: {members[i].Name} , Borrowed Books: {members[i].GetBorrowedCount()}");
                    }
                }
            }
            
         
        }
        #endregion

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



        #region Borrow Book

        public void BorrowBook(int bookId, int memberId)
        {
            Console.WriteLine($"Book not found. {bookCount}");

            if (bookCount == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }
            Book? book = Array.Find(books, b => b != null && b.Id == bookId);
            Member? member = Array.Find(members, m => m != null && m.ID == memberId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine($"Book '{book.Title}' is not available for borrowing.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine($"{member.Name} borrowed '{book.Title}'.");
        }

        public void ReturnBook(int bookId, int memberId)
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Book? book = Array.Find(books, b => b != null && b.Id == bookId);
            Member? member = Array.Find(members, m => m != null && m.ID == memberId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }
            if (book.IsAvailable)
            {
                Console.WriteLine($"Book '{book.Title}' is already available in the library.");
                return;
            }
            book.IsAvailable = true;
            Console.WriteLine($"{member.Name} returned '{book.Title}'.");
        }

        #endregion
    }
}
