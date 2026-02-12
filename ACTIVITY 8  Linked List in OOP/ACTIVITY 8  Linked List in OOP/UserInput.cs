using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_8__Linked_List_in_OOP
{
    internal static class UserInput
    {
        public static int GetIntInput(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public static string GetStringInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty.");
                Console.Write(prompt);
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
    



