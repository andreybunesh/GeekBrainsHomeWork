using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}");
            string userName = Properties.Settings.Default.UserName;
            string age = Properties.Settings.Default.Age;
            string career = Properties.Settings.Default.Career;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UserName) || !string.IsNullOrEmpty(Properties.Settings.Default.Age) || !string.IsNullOrEmpty(Properties.Settings.Default.Career))
            {
                Console.WriteLine($" Имя пользователя: {userName}, Возраст: {age}, Профессия: {career}");
            }
            Console.WriteLine("Введите имя пользователя:");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Console.WriteLine("Возраст:");
            Properties.Settings.Default.Age = Console.ReadLine();
            Console.WriteLine("Профессию");
            Properties.Settings.Default.Career = Console.ReadLine();
            Properties.Settings.Default.Save();
            

        }
    }
}
