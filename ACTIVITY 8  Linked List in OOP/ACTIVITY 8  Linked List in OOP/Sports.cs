using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_8__Linked_List_in_OOP
{
    public class Sports
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
            Console.WriteLine($"\nSport Name: {Name}");
            Console.WriteLine($"Place Invented: {PlaceInvented}");
            Console.WriteLine($"Inventor: {WhoInvented}");
        }
    }
     class Basketball : Sports
    {
        public int YearInvented { get; set; }

        public Basketball(string name, string placeInvented, string whoInvented, int yearInvented)
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
    public class Volleyball : Sports
    {
        public int NumberOfPlayers { get; set; }

        public Volleyball(string name, string placeInvented, string whoInvented, int numberOfPlayers)
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


