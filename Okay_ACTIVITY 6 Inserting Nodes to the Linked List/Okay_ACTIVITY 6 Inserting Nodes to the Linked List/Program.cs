using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_ACTIVITY_6_Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:

            //John Mark R. Okay                 Section:IT401P
            //Date: 1/22/26
            //Title: ACTIVITY 6: Inserting Nodes to the Linked List


            LinkedList<string> list = new LinkedList<string>();
      
            Console.Clear();
            //Allow the user to enter number of nodes
            Console.WriteLine("Enter the number of Names (NODES) 5 ,Maxumum number of (NODES) 10,\n");
            int numofnodes = int.Parse(Console.ReadLine());

            //Limits the CAPACITY OF THE LIST
            if(numofnodes < 5  || numofnodes > 10 )
            {
         
                Console.WriteLine("Please enter a NUMBER within the range\t");
                             
               
            }          
                     
            for (int i = 0; i < numofnodes; i++)
            {
                Console.Write("\nPlease enter the name if you Classmates:\t");
                string name = Console.ReadLine();
                 list.AddFirst(name);
            }


            //Display the list CONTENTS
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t\t\tThe List of Name\n\n");
            foreach (string name in list)
            {             
                Console.Write("\t" + name + "→→\t");
            }

            //Asking the user to go back
            char choice;

            Console.Write("\n\n\n\n\n\t\tDo you want to go back? (y/n)? :\t");
            choice =Convert.ToChar(Console.ReadLine());

            if(choice == 'y')
            {
                goto Main;
            }
            else if (choice == 'n')
            {
                Console.WriteLine("Good Byee!!!");
                return;
            }

                Console.ReadKey();
            


            //Console.WriteLine("Name of your Classmate:\t");
            //string name = Console.ReadLine();

            //Console.WriteLine("Name of your Favorite Teacher:\t");
            //string name = Console.ReadLine();
        }
    }
}
