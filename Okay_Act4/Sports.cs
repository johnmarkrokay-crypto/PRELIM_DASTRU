using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_Act4
{
    class Sports
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

    //{
    //    public string Name { get; set; }
    //    public string PlaceInvented { get; set; }
    //    public string WhoInvented { get; set; }

    //    public Sports(string name,string placeinvented,string whoinvented)
    //    { 
    //        Name = name;
    //        PlaceInvented = placeinvented;
    //        WhoInvented = whoinvented;
    //    }

    //    public virtual void SportsInfo()
    //    {
    //        Console.WriteLine("\n------Here are the Sports Information-----\n");
    //        Console.WriteLine($"Name: \t {Name}");
    //        Console.WriteLine($"Place Invented: \t {PlaceInvented}");
    //        Console.WriteLine($"Who Invented: \t {WhoInvented}");

    //    }
    //}
    //class BasketBall : Sports
    //{
    //    public int YearInvented { get; set; }

    //    public BasketBall(string name, string placeinvented, int yearinvented) : base(name, placeinvented, whoinvented)

    //    {
    //        YearInvented = yearinvented;
    //    }
    //    public override void SportsInfo()
    //    {
    //        Console.WriteLine("\n-----BasketBall Information-----\n");
    //        Console.WriteLine($"Year Invented: \t {YearInvented}");
    //        base.SportsInfo();
    //    }
    //}

    //class VolleyBall: Sports
    //{
    //    public string Player { get; set; }

    //    public VolleyBall(string name,string placeinvented, int yearinvented) : base (name, placeinvented,whoinvented)
    //    {
    //        Player = placeinvented;
    //    }

    //    public override void SportsInfo()
    //    {
    //        Console.WriteLine("\n-----VolleyBall Information-----\n");
    //        Console.WriteLine($"Name of the Player: \t {Player}");
    //        base.SportsInfo();

    

