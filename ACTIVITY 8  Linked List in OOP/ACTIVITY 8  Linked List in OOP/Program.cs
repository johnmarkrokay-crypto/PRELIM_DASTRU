using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_8__Linked_List_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: John Mark R. Okay              Section: IT401P
            //Title: ACTIVITY 8:  Linked List in OOP

            SportsManager sportsList = new SportsManager();
            bool exit = false;

            while (!exit)
            {
                
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Insert Basketball");
                Console.WriteLine("2. Insert Volleyball");
                Console.WriteLine("3. Remove Sport");
                Console.WriteLine("4. Display Sports");
                Console.WriteLine("5. Exit");

                int choice = UserInput.GetIntInput("Choose an option: ");

               
                switch (choice)
                {
                    case 1:
                        string nameB = UserInput.GetStringInput("Enter Basketball Name: ");
                        string placeB = UserInput.GetStringInput("Enter Place Invented: ");
                        string inventorB = UserInput.GetStringInput("Enter Inventor: ");
                        int year = UserInput.GetIntInput("Enter Year Invented: ");

                        Basketball basketball = new Basketball(nameB, placeB, inventorB, year);
                        sportsList.Insert(basketball);
                        break;

                    case 2:
                        string nameV = UserInput.GetStringInput("Enter Volleyball Name: ");
                        string placeV = UserInput.GetStringInput("Enter Place Invented: ");
                        string inventorV = UserInput.GetStringInput("Enter Inventor: ");
                        int players = UserInput.GetIntInput("Enter Number of Players: ");

                        Volleyball volleyball = new Volleyball(nameV, placeV, inventorV, players);
                        sportsList.Insert(volleyball);
                        break;

                    case 3:
                        string nameToRemove = UserInput.GetStringInput("Enter Sport Name to Remove: ");
                        sportsList.Remove(nameToRemove);
                        break;

                    case 4:
                        sportsList.Display();
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
  }

        
          
                
            
        
    

        
    

