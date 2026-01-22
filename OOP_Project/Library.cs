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
            members = new Member[4];
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
    }
}
