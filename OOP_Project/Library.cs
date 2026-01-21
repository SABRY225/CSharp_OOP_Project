using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    internal class Library
    {

        Member[] members;
        int index = 0;
        public Library()
        {
            members = new Member[3];
        }
        public void addMember(Member member)
        {
            if (index < members.Length)
            {
                members[index] = member;
                index++;
                Console.WriteLine($"Member '{member.Name}' added successfully.");
            }

        }
        public void removeMember(int id)
        {
            for (int i = 0; i < index; i++)
            {
                if (members[i].ID == id)
                {
                    members[index-1] = null;
                    index--;
                    Console.WriteLine($"Member '{members[i].Name}' removed successfully.");
                }
            }
           
        }
        public void listMemebers()
        {
            if(index == 0)
            {
                Console.WriteLine("No members found.");
            }
            Console.WriteLine("Library Members:");
            foreach (Member member in members)
            {
                Console.WriteLine($"ID: {member.ID} ,Name: {member.Name}");
            }
        }
    }
}
