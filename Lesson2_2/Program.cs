using System;

namespace Lesson2_2
{
 public class Program
    {
        public static void Main(string [] arg) 
        {
           Console.WriteLine("Enter number of month");
            int Monthnumber = Convert.ToInt32(Console.ReadLine());
            switch (Monthnumber)
            {
                case 1:
                    {
                        System.Console.WriteLine("This is January");
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("This is February");
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("This is March");
                        break;
                    }
                case 4:
                    {
                        System.Console.WriteLine("This is April");
                        break;
                    }
                case 5:
                    {
                        System.Console.WriteLine("This is May");
                        break;
                    }
                case 6:
                    {
                        System.Console.WriteLine("This is June");
                        break;
                    }
                case 7:
                    {
                        System.Console.WriteLine("This is July");
                        break;
                    }
                case 8:
                    {
                        System.Console.WriteLine("This is August");
                        break;
                    }
                case 9:
                    {
                        System.Console.WriteLine("This is September");
                        break;
                    }
                case 10:
                    {
                        System.Console.WriteLine("This is October");
                        break;
                    }
                case 11:
                    {
                        System.Console.WriteLine("This is November");
                        break;
                    }
                case 12:
                    {
                        System.Console.WriteLine("This is December");
                        break;
                    }
            }
        }
    }
}
