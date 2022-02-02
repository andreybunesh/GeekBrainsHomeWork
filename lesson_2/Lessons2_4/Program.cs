using System;
using System.Text;
namespace Lessons2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Organization Name ");
            // string organizationName = Console.ReadLine();
            string organizationName = ("SportMaster");

            Console.WriteLine("Enter Organization Address ");
            //string organizationAdress = Console.ReadLine();
            string organizationAdress = ("Minsk, Lomonosova street, 4");

            Console.WriteLine(" Enter seller's name");
            // string sellerName = Console.ReadLine();
            string sellerName = ("Ivanova G.M.");

            Console.WriteLine("Enter product1");
            // string product1 = Console.ReadLine();
            string product1 = "Ice - cream";
            double prize1 = 100;
            int quantity1 = 9;
            
            Console.WriteLine("Enter product2");
            //string product2 = Console.ReadLine();
            string product2 = "Bread";
            double prize2 = 20.45;
            int quantity2 = 56254;
            
            Console.WriteLine("Enter product3");
            //string product3 = Console.ReadLine();
            string product3 = "Milk";
            double prize3 = 106;
            int quantity3 = 4;

            var sum = prize1 * quantity1+ prize2 * quantity2+ prize3 * quantity3;
            string currentDate = DateTime.Now.ToShortDateString();
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("************************************************");
            Console.WriteLine($"*                {organizationName}                   *");
            Console.WriteLine($"*         {organizationAdress}          *");
            Console.WriteLine("************************************************");
            Console.WriteLine("                 Sales receipt                  ");
            Console.WriteLine("                Payment document                ");
            Console.WriteLine($"#{sellerName}   {currentDate}                      #");
            Console.WriteLine("#----------------------------------------------#");
            DrawPrice(product1, prize1, quantity1);
            DrawPrice(product2, prize2, quantity2);
            DrawPrice(product3, prize3, quantity3);
            
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"TOTAL {"= " + sum.ToString("0.00"),42}");
        }
        private static void DrawPrice(string product, double prize, int quantity)
        {
            Console.WriteLine($"{product,-40}");
            var str1 = $"{prize.ToString("0.00")} * {quantity}";
            var str2 = $"{"=",10} {str1,-20}";
            Console.Write($"{str2}");
            //Console.Write($"");
            Console.WriteLine($"{"= " + (prize* quantity).ToString("0.00"),17}");

        }
    }
}
