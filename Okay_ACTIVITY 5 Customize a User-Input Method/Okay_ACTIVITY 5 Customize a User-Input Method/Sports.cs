using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Okay_ACTIVITY_5_Customize_a_User_Input_Method
{
    internal class Sports
    {
        public string Name { get; set; }
        public string PlaceInvented { get; set; }
        public string WhoInvented { get; set; }

        public Sports(string name, string placeInvented, string whoInvented)
        {
            Name = name;
            PlaceInvented = placeInvented;
            WhoInvented = whoInvented;
        }

        public virtual void SportsInfo()
        {
            Console.WriteLine("\n-----Sports Information-----\n");
            Console.WriteLine($"Name of Sports: {Name}");
            Console.WriteLine($"Place Invented:\t {PlaceInvented}");
            Console.WriteLine($"Who Invented:\t {WhoInvented}");
        }
    }

    class BasketBall : Sports
    {
        public int YearInvented { get; set; }

        public BasketBall(string name, string placeInvented, string whoInvented, int yearInvented)
            : base(name, placeInvented, whoInvented)
        {
            YearInvented = yearInvented;
        }

        public override void SportsInfo()
        {
            base.SportsInfo();
            Console.WriteLine($"Year Invented: {YearInvented}");

        }
    }

    class VolleyBall : Sports
    {
        public int NumberOfPlayers { get; set; }

        public VolleyBall(string name, string placeInvented, string whoInvented, int numberOfPlayers)
            : base(name, placeInvented, whoInvented)
        {
            NumberOfPlayers = numberOfPlayers;
        }

        public override void SportsInfo()
        {
            base.SportsInfo();
            Console.WriteLine($"Players per Team: {NumberOfPlayers}");

        }
    }
}

    

