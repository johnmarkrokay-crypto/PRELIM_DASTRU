using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_Act4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                  
                
                Sports[,] sportsArray = new Sports[2, 2];

                // Initialize objects
                sportsArray[0, 0] = new BasketBall(
                    "Basketball",
                    "USA",
                    "James Naismith",
                    1891);

                sportsArray[0, 1] = new VolleyBall(
                    "Volleyball",
                    "USA",
                    "William G. Morgan",
                    6);

                sportsArray[1, 0] = new BasketBall(
                    "Street Basketball",
                    "USA",
                    "James Naismith",
                    1891);

                sportsArray[1, 1] = new VolleyBall(
                    "Beach Volleyball",
                    "USA",
                    "William G. Morgan",
                    1891);

                
                for (int row = 0; row < sportsArray.GetLength(0); row++)
                {
                    for (int col = 0; col < sportsArray.GetLength(1); col++)
                    {
                        sportsArray[row, col].SportsInfo();
                    }
                }

                Console.ReadKey();
            }
        }

    }


