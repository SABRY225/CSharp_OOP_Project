namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Member m1 = new Member(1, "sh");
            //Member m2 = new Member(2, "mm");
            //Member m3 = new Member(3, "aa");
            //Member m4 = new Member(4, "may");
            //Member m5 = new Member(5, "bb");
            //Member m6 = new Member(6, "th");
            //Library l1 = new Library();
            //Member[] members = new Member[6];
            //l1.AddMember(m1);
            //l1.AddMember(m2);
            //l1.AddMember(m3);
            //l1.AddMember(m5);
            //l1.AddMember(m4);
            //l1.AddMember(m6);
            ////l1.RemoveMember(1);
            //l1.RemoveMember(3);
            ////l1.RemoveMember(3);
            //l1.ListMembers();

            string ReadRequiredString(string message)
            {
                string input;
                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                        Console.WriteLine("Input cannot be empty.");

                } while (string.IsNullOrWhiteSpace(input));

                return input;
            }

            int ReadRequiredInt(string message)
            {
                int value;
                string input;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty.");
                        continue;
                    }

                    if (!int.TryParse(input, out value))
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }

                    return value;

                } while (true);
            }



            Library library = new Library();
            int choice;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
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

                choice = ReadRequiredInt("Select an option: ");

                switch (choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        int bId = ReadRequiredInt("Book ID: ");
                        string title = ReadRequiredString("Title: ");
                        string author = ReadRequiredString("Author: ");
                        library.AddBook(new Book(bId, title, author));
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        int removeBookId = ReadRequiredInt("Book ID to remove: ");
                        library.RemoveBook(removeBookId);
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        int mId = ReadRequiredInt("Member ID: ");
                        string name = ReadRequiredString("Name: ");
                        library.AddMember(new Member(mId, name));
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        int removeMemberId = ReadRequiredInt("Member ID to remove: ");
                        library.RemoveMember(removeMemberId);
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int memId = ReadRequiredInt("Member ID: ");
                        int bookId = ReadRequiredInt("Book ID: ");
                        library.BorrowBook(bookId, memId );
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        int memIdR = ReadRequiredInt("Member ID: ");
                        int bookIdR = ReadRequiredInt("Book ID: ");
                        library.ReturnBook(bookIdR,memIdR);
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        library.ListBooks();
                        break;

                    case 8:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        library.ListMembers();
                        break;

                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
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
