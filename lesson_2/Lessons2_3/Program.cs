using System;

namespace Lessons2_3
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                System.Console.WriteLine("This number is even");
            }
            else
            {
                System.Console.WriteLine("odd number");
            }
        }
    }
}
