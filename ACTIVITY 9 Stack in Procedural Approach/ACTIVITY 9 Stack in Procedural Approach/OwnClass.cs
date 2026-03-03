using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_9_Stack_in_Procedural_Approach
{
    internal class OwnClass
    {
        private Queue<string> queue = new Queue<string>(); 

        public void Enqueue(string item)
        {
            queue.Enqueue(item);
            Console.WriteLine(item + " added.");
        }

        public void Dequeue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty. Cannot remove.");
                return;
            }
            string item = queue.Dequeue();
            Console.WriteLine(item + " removed.");
        }

        public void Peek()
        {  
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty. Nothing to show.");
                return;
            }
            Console.WriteLine("Front item: " + queue.Peek());
        }

        public void Display()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return; 
            }
            Console.WriteLine("Queue items:");
            foreach (string item in queue)
                Console.WriteLine(item);
        }
    }
}

