namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
           
            Member m1 = new Member(1, "sh");
            Member m2 = new Member(2, "mm");
            Member m3 = new Member(3, "aa");
            Member m4 = new Member(4, "may");
            Member m5 = new Member(5, "bb");
            Member m6 = new Member(6, "th");
            Library l1 = new Library();
            Member[] members = new Member[6];
            l1.addMember(m1);
            l1.addMember(m2);
            l1.addMember(m3);
            l1.addMember(m5);
            l1.addMember(m4);
            l1.addMember(m6);
            //l1.removeMember(1);
            l1.removeMember(3);
            //l1.removeMember(3);
            l1.listMemebers();
            
            
=======
            Library library = new Library();
            int choice;

            do
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Add Member");
                Console.WriteLine("4. Remove Member");
                Console.WriteLine("5. Borrow Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. List Books");
                Console.WriteLine("8. List Members");
                Console.WriteLine("9. Exit");
                Console.Write("Select an option: ");

                choice = int.Parse(Console.ReadLine());
>>>>>>> 8c4dc81a615e88a3c2bf1a180bba936ddc64c118

                switch (choice)
                {
                    case 1:
                        Console.Write("Book ID: ");
                        int bId = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        library.AddBook(new Book(bId, title, author));
                        break;

                    case 2:
                        Console.Write("Book ID to remove: ");
                        library.RemoveBook(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Member ID: ");
                        int mId = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        library.AddMember(new Member(mId, name));
                        break;

                    case 4:
                        Console.Write("Member ID to remove: ");
                        library.RemoveMember(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Member ID: ");
                        int memId = int.Parse(Console.ReadLine());
                        Console.Write("Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        library.BorrowBook(memId, bookId);
                        break;

                    case 6:
                        Console.Write("Member ID: ");
                        int memIdR = int.Parse(Console.ReadLine());
                        Console.Write("Book ID: ");
                        int bookIdR = int.Parse(Console.ReadLine());
                        library.ReturnBook(memIdR, bookIdR);
                        break;

<<<<<<< HEAD
            l1.ListBooks();
            l1.BorrowBook(1, 1);
            l1.BorrowBook(2, 2);
            l1.ListBooks();
            l1.ReturnBook(2, 2);
            l1.ListBooks();
=======
                    case 7:
                        library.ListBooks();
                        break;
>>>>>>> 8c4dc81a615e88a3c2bf1a180bba936ddc64c118

                    case 8:
                        library.ListMembers();
                        break;

                    case 9:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 9);
        }
    }
}
