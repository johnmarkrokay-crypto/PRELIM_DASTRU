using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_ACTIVITY_7_Inserting_Nodes_with_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Mark R. Okay                 Section:IT401P
            //Date: 1/22/26
            //Title: ACTIVITY 6: Inserting Nodes to the Linked List                   

            LinkedList<string> list = new LinkedList<string>();
            int numofnodes = 0;

            Console.Clear();
            Console.WriteLine("Enter the number of Names (NODES) 5–10:\n");

            try
            {
                numofnodes = int.Parse(Console.ReadLine());

                if (numofnodes < 5 || numofnodes > 10)
                {
                    Console.WriteLine("ERROR: Number must be between 5 and 10.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Invalid input. Please enter a numeric value.");
                return;
            }
            finally
            {
                Console.WriteLine("\nInput validation completed.\n");
            }

            // User input for linked list (NO initialized values)
            for (int i = 0; i < numofnodes; i++)
            {
                Console.Write("Enter the name of your classmate:\t");
                string name = Console.ReadLine();
                list.AddFirst(name);
            }

            // Convert LinkedList to array for sorting
            string[] namesArray = new string[list.Count];
            list.CopyTo(namesArray, 0);

            // Sort the array
            Array.Sort(namesArray);

            // Reinsert sorted data back to linked list
            list.Clear();
            foreach (string name in namesArray)
            {
                list.AddLast(name);
            }

            // Display sorted linked list
            Console.Clear();
            Console.WriteLine("\n\t\tSORTED LIST OF NAMES\n");

            foreach (string name in list)
            {
                Console.Write(name + " → ");
            }

            Console.ReadLine();
        }
    }
}

    //    LinkedList<string> list = new LinkedList<string>();

//    Console.Clear();
//    //Allow the user to enter number of nodes
//    Console.WriteLine("Enter the number of Names (NODES) 5 ,Maxumum number of (NODES) 10,\n");
//    int numofnodes = int.Parse(Console.ReadLine());

//    //Limits the CAPACITY OF THE LIST
//    if (numofnodes < 5 || numofnodes > 10)
//    {

//        Console.WriteLine("Please enter a NUMBER within the range\t");


//    }

//    for (int i = 0; i < numofnodes; i++)
//    {
//        Console.Write("\nPlease enter the name if you Classmates:\t");
//        string name = Console.ReadLine();
//        list.AddFirst(name);
//    }


//    //Display the list CONTENTS
//    Console.Clear();
//    Console.WriteLine("\n\n\t\t\t\t\tThe List of Name\n\n");
//    foreach (string name in list)
//    {
//        Console.Write("\t" + name + "→→\t");
//    }
//}
