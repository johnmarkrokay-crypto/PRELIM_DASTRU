using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_8__Linked_List_in_OOP
{
    internal class SportsManager
    {
        private LinkedList<Sports> sports = new LinkedList<Sports>();

        private class Node
        {
            public Sports Data;
            public Node Next;

            public Node(Sports data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public void Insert(Sports sport)
        {
            Node newNode = new Node(sport);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            Console.WriteLine("Sport inserted successfully!");
        }

        public void Remove(string name)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                head = head.Next;
                Console.WriteLine("Sport removed successfully!");
                return;
            }

            Node current = head;

            while (current.Next != null &&
                   !current.Next.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Sport not found.");
            }
            else
            {
                current.Next = current.Next.Next;
                Console.WriteLine("Sport removed successfully!");
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = head;
            while (current != null)
            {
                current.Data.SportsInfo();
                Console.WriteLine("----------------------");
                current = current.Next;
            }
        }
    }
}      
    

