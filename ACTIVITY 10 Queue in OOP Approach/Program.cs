using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ACTIVITY_10_Queue_in_OOP_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();

            //Name: John Mark R. Okay                 Section: IT401P
            //ACTIVITY 10: Queue in OOP Approach

            while (true)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Here's are the choices!");
                Console.WriteLine("1. Enque:\t");
                Console.WriteLine("2. Deque:\t");
                Console.WriteLine("3.Display:\t");
                Console.WriteLine("4.Exit:\t");
                Console.WriteLine(Environment.NewLine);

                try
                {
                    Console.Write("\tEnter a choices:\t");
                    int choice = Convert.ToInt32(Console.ReadLine());


                    if (choice == 1)
                    {
                        Console.Write("\nEnter a Item to Enque:\t");
                        string items = Console.ReadLine();
                        myQueue.Enqueue(items);
                    }
                    else if (choice == 2)
                    {
                        myQueue.Dequeue();

                    }
                    else if (choice == 3)
                    {
                        myQueue.Display();
                    }

                    else if (choice == 4)
                    {
                        Console.WriteLine("\tBye!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                catch
                {
                     Console.WriteLine("Enter Number Only for Choices");
                }
            }
        }
    }
}

  

        
    

