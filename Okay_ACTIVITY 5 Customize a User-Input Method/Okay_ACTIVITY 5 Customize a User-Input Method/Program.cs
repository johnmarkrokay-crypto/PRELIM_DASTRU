using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_ACTIVITY_5_Customize_a_User_Input_Method
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Name: John Mark R. Okay                  Section: IT401P
            //Title:ACTIVITY 5: Customize a User-Input Method

            Sports[,] sportsArray = new Sports[2, 2];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine($"\nEnter details for sport");

                    Console.Write("\nChoose Sport (1 for Basketball, 2 for Volleyball):\t");
                    int choice = int.Parse(Console.ReadLine());


                    if (choice == 1)
                    {

                        Console.Write("\t\nName of the BasketBall Player:\t");
                        string name = Console.ReadLine();

                        Console.Write("\t\nPlace Invented of the BasketBall Sports:\t");
                        string place = Console.ReadLine();

                        Console.Write("\t\nWho Invented the BasketBall Sports:\t");
                        string inventor = Console.ReadLine();

                        Console.Write("\t\nYear Invented of the BasketBall Sports:\t");
                        int year = int.Parse(Console.ReadLine());

                        sportsArray[row, col] = new BasketBall(name, place, inventor, year);

                        for (int i = 0; row < 2; row++)
                        {
                            for (int s = 0; col < 2; col++)
                            {
                                sportsArray[row, col].SportsInfo();
                            }
                        }
                        Console.ReadKey();

                    }
                    else if (choice == 2)
                    {
                        
                        Console.Write("\t\nName of the VolleyBall Player:\t");
                        string name = Console.ReadLine();

                        Console.Write("\t\nPlace Invented of the VolleyBall Sports:\t");
                        string place = Console.ReadLine();

                        Console.Write("\t\nWho Invented the VolleyBall Sports:\t");
                        string inventor = Console.ReadLine();

                        Console.Write("\t\nYear Invented the VolleyBall Sports:\t");
                        int players = int.Parse(Console.ReadLine());

                        sportsArray[row, col] = new VolleyBall(name, place, inventor, players);
             
               

                        for (int i = 0; row < 2; row++)
                        {
                            for (int s = 0; col < 2; col++)
                            {
                                sportsArray[row, col].SportsInfo();
                            }

                            Console.ReadKey();
                        }
                    }
                }
            }

            //Console.WriteLine("\n--- SPORTS INFORMATION ---");

            //for (int row = 0; row < 2; row++)
            //{
            //    for (int col = 0; col < 2; col++)
            //    {
            //        sportsArray[row, col].SportsInfo();
            //    }
            //}

        }
    }
}


            //        Sports[,] sportsArray = new Sports[2, 2];

            //        for (int row = 0; row < sportsArray.GetLength(0); row++)
            //        {
            //            for (int col = 0; col < sportsArray.GetLength(1); col++)
            //            {
            //                Console.WriteLine($"\nEnter details for Sport");

            //                Console.Write("Sport Type (1 = Basketball, 2 = Volleyball): ");
            //                int choice = int.Parse(Console.ReadLine());

            //                Console.Write("Name: ");
            //                string name = Console.ReadLine();

            //                Console.Write("Place Invented: ");
            //                string place = Console.ReadLine();

            //                Console.Write("Who Invented: ");
            //                string inventor = Console.ReadLine();

            //                if (choice == 1)
            //                {
            //                    Console.Write("Year Invented: ");
            //                    int year = int.Parse(Console.ReadLine());

            //                    sportsArray[row, col] = new BasketBall(
            //                        name, place, inventor, year);
            //                }
            //                else if (choice == 2)
            //                {
            //                    Console.Write("Number of Players per Team: ");
            //                    int players = int.Parse(Console.ReadLine());

            //                    sportsArray[row, col] = new VolleyBall(
            //                        name, place, inventor, players);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid choice. Try again.");
            //                    col--; // repeat this cell
            //                }
            //            }
            //        }

            //        Console.WriteLine("\n===== SPORTS INFORMATION =====");

            //        for (int row = 0; row < sportsArray.GetLength(0); row++)
            //        {
            //            for (int col = 0; col < sportsArray.GetLength(1); col++)
            //            {
            //                sportsArray[row, col].SportsInfo();
            //            }
            //        }

            //        Console.ReadKey();
            //    }
            //}
       // }




//            Console.Write("Please Enter: \t");


//            Sports[,] sportsArray = new Sports[2, 2];

//            // Initialize objects
//            sportsArray[0, 0] = new BasketBall(
//                "Basketball",
//                "USA",
//                "James Naismith",
//                1891);

//            sportsArray[0, 1] = new VolleyBall(
//                "Volleyball",
//                "USA",
//                "William G. Morgan",
//                6);

//            sportsArray[1, 0] = new BasketBall(
//                "Street Basketball",
//                "USA",
//                "James Naismith",
//                1891);

//            sportsArray[1, 1] = new VolleyBall(
//                "Beach Volleyball",
//                "USA",
//                "William G. Morgan",
//                1891);


//            for (int row = 0; row < sportsArray.GetLength(0); row++)
//            {
//                for (int col = 0; col < sportsArray.GetLength(1); col++)
//                {
//                    sportsArray[row, col].SportsInfo();
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}
