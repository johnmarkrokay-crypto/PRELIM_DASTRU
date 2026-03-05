using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_10_Queue_in_OOP_Approach
{
    internal class MyQueue
    {
        List<string> queue = new List<string>(); // empty queue

        public void Enqueue(string item)
        {
            queue.Add(item);
            Console.WriteLine("\tAdded: " + item);
        }

        public void Dequeue()
        {
            try
            {
                string item = queue[0];
                queue.RemoveAt(0);
                Console.WriteLine("\tRemoved: " + item);
            }
            catch
            {
                Console.WriteLine("Queue is empty");
            }
        }

        public void Display()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue: ");
                foreach (string item in queue)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

