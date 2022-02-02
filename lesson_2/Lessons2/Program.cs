using System;
using System.Text;

namespace Lessons2_1
{
    static class Program
    {
        static void Main(string[] args)
        {

            //Lesson2_2.Program.Main(new[] {"5"});
            //var p = new ClassLibrary1.Class1();
            //p.DrawCheck();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
           // System.Console.InputEncoding = Encoding.GetEncoding(1251);

            Console.WriteLine("ФтвкаааEnter Min Temperature per day");
            decimal minTempreture = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Max Temperature per day");
            decimal maxTempreture = Convert.ToDecimal(Console.ReadLine());
            decimal middleTepreture = (minTempreture + maxTempreture) / 2;
            Console.WriteLine($"average daily temperature is equal {middleTepreture}");
        }
    }
}