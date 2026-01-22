namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
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





            Book book1 = new Book(1, "book1", "author1");
            Book book2 = new Book(2, "book2", "author2");
            Book book3 = new Book(3, "book3", "author3");
            Book book4 = new Book(4, "book4", "author4");


            l1.AddBook(book1);
            l1.AddBook(book2);
            l1.AddBook(book3);
            l1.AddBook(book4);

            l1.RemoveBook(3);

            l1.ListBooks();

            l1.BorrowBook(2, 2);
            l1.ListBooks();
            l1.ReturnBook(2, 2);
            l1.ListBooks();




        }
    }
}
