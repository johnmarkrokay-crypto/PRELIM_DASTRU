using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string user = "kons";
            //string pass = "barili";

            //try
            //{
            //    Console.Write("Enter User Name: →\t");
            //     user = Console.ReadLine();

            //    Console.Write("Enter Password: →\t");
            //    pass = Console.ReadLine();

            //    if (user != "kons" && pass != "barili")
            //        throw new Exception("Taka di mana taga barili !!!");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid jd siya kay dili si kons!!");
            //}
            //finally
            //{
            //    if (user == "kons" || pass == "barili")
            //    Console.WriteLine("Kaila jd ka ni kons taga pangpang");
            //}
            int num;
            try
            {
                Console.Write("Enter a number between 1 and 100: ");
                num = int.Parse(Console.ReadLine());


                if (num <0 && num > 100)
                {
                    throw new ArgumentOutOfRangeException(
                        
                        "Number must be between 1 and 100."
                    );
                }

                Console.WriteLine($"You entered: {num}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Input process completed.");
            }

            Console.ReadKey();
        }
    }

}
        //int age = 20;
        //Console.Write("\n" + "" + "Edad ni KONS BARILI PANGPANG: →\t");
        //age =Convert.ToInt32(Console.ReadLine());
        //if(age < 20)
        //{
        //    throw new ArgumentException("Dili na maong edad ni kons BARILI");

        //}
        //try
        //{
        //    age = Convert.ToInt32(Console.ReadLine());
        //}
        //catch (FormatException) 
        //{

        //}

        //Console.ReadKey();
            //int num1 = 3;
            //int num2 = 4;
            //Console.Write("Enter a number\t");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == 0.75 && num2 == 0.75)
            //{
            //    try
            //    {
            //        int result = num1 / num2;
            //    }
            //    catch

            //    {
            //        Console.WriteLine("Error");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Correct kons BARILI");
            //    }
            //}
            //try
            //{
            //   int result = num1 / num2;
            //}
            //catch
            //{
            //    Console.WriteLine("Error");
            //}
            //finally 
            //{
            //    Console.WriteLine("Correct");
            //}                                                 
