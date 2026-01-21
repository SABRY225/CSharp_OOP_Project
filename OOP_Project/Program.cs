namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Member m1 = new Member(1, "sh");
            Member m2 = new Member(1, "mm");
            Member m3 = new Member(3, "aa");
            Library l1 = new Library();
            Member[] members = new Member[3];
            l1.addMember(m1);
            l1.addMember(m2);
            l1.addMember(m3);
            l1.removeMember(1);
            l1.removeMember(2);
            l1.removeMember(3);
            l1.listMemebers();



        }
    }
}
