using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_9_Stack_in_Procedural_Approach
{
    internal class Program
    {
        static void Main(string[] args)

        //Name: John Mark R. Okay                  Section: IT401P
        //Title Activity:ACTIVITY 9:  Stack in Procedural Approach
        {
            List<string> queue = new List<string>(); // empty queue
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\n1. Add Item (Enqueue)");
                Console.WriteLine("2. Remove Front Item (Dequeue)");
                Console.WriteLine("3. Peek Front Item");
                Console.WriteLine("4. Remove Last Item (Pop)");
                Console.WriteLine("5. Display Queue");
                Console.WriteLine("6. Exit");
                Console.Write("Choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Enter item to add: ");
                        string item = Console.ReadLine();
                        queue.Add(item);
                        Console.WriteLine(item + " added.");
                    }
                    else if (choice == 2)
                    {
                        if (queue.Count == 0)
                            Console.WriteLine("Queue is empty. Cannot dequeue.");
                        else
                        {
                            string removed = queue[0];
                            queue.RemoveAt(0);
                            Console.WriteLine(removed + " removed from front.");
                        }
                    }
                    else if (choice == 3)
                    {
                        if (queue.Count == 0)
                            Console.WriteLine("Queue is empty.");
                        else
                            Console.WriteLine("Front item: " + queue[0]);
                    }
                    else if (choice == 4)
                    {
                        if (queue.Count == 0)
                            Console.WriteLine("Queue is empty. Cannot pop.");
                        else
                        {
                            string popped = queue[queue.Count - 1];
                            queue.RemoveAt(queue.Count - 1);
                            Console.WriteLine(popped + " removed from end (pop).");
                        }
                    }
                    else if (choice == 5)
                    {
                        if (queue.Count == 0)
                            Console.WriteLine("Queue is empty.");
                        else
                        {
                            Console.WriteLine("Queue items:");
                            foreach (var item in queue)
                                Console.WriteLine(item);
                        }
                    }
                    else if (choice == 6)
                    {
                        Console.WriteLine("Exiting...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number only.");
                }
            }
        }
    }
}
    




              

          
    


         

         
