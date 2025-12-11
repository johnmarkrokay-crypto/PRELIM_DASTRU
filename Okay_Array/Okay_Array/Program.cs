using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            ////    int[] numbers = { 1, 3, 5, 6, 2 };
            ////    Array.Reverse(numbers);

            ////    foreach (int num in numbers)
            ////    {
            ////        Console.WriteLine(num);
            ////    }



            ////    for (int num = 0; num <= 10; ++num)
            ////    {
            ////        Console.WriteLine(num);
            ////    }
            ////    Console.ReadKey();
            ///



            Console.Clear();
            Console.Write("Select number (1/2) : \t");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("2V2");
                Console.WriteLine("Select Your Fighter Barili Area\t");
                string Fname = Console.ReadLine();

                if (Fname == "Kons")
                {

                }

                string[] name = {"ATILLO FROM BARILI !!","Jayvin Kababat\n"};
                Array.Sort(name);

                foreach (string Name in name)
                {
                    Console.WriteLine(Name);
                }
            }
            else if (num == 2)
            {
                Console.WriteLine("2v2");

                Console.WriteLine("Select Your Fighter Bohol Area\t");
                string Tname = Console.ReadLine();

                 if(Tname == "Carls")
                {

                }
                string[] Sname = { "Carls Taga Bohol","Bedro Kinamot\n"};
                Array.Sort(Sname);
                foreach (string Number in Sname)
                {
                    Console.WriteLine(Number);
                }
            }
            char choice;

            Console.WriteLine("\n\nDo you want to go back? (y/n):\n\n\t");
            choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'y')
            {
                goto Main;
            }
            else if (choice == 'n')
            {
                Console.WriteLine("bYE!!!");
                return;
                //}
                //while (true)
                //{
                //    Console.WriteLine("UserName:\t");
                //    Name = Console.ReadLine();

                //    Console.WriteLine("Password:\t");
                //    Pass = Convert.ToInt32(Console.ReadLine());

                //    if (Name == "atillo")
                //    {
                //        Console.WriteLine("Login Succesfully");
                //        break;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Try Again!");
                //    }

                //    Console.ReadKey();
            }
       }
    }
}
