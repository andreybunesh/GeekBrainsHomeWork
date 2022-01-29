using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            string currentDate = DateTime.Now.ToShortDateString();
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Привет " + name + " сегодня " + currentDate);
        }
    }
}
