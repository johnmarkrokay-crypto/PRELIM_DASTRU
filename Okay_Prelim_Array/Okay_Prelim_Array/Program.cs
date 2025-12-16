using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_Prelim_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            string[] SportsName = new string[8];

            //User input
             Console.WriteLine("\n\nEnter atleast 7 sports: \t\n");
            for (int index = 1; index < SportsName.Length; index++)
            {
                Console.Write($"{index}.");
                SportsName[index]=Console.ReadLine();
            } 

            Array.Sort(SportsName);
           

            //Display the array
            Console.Clear();
            Console.WriteLine("\t-----List of all sports-----\t\n");
             foreach(string sports in SportsName)
            {
                
                Console.WriteLine("\t" + sports);

            }
            Console.ReadKey();

         
        }
    }
}
