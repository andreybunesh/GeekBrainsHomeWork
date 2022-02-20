using System;

namespace Lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string firstName = Console.ReadLine();
            ////string lastName = Console.ReadLine();
            //string patronymic = Console.ReadLine();
            string firstName1 = "Andrey";
            string lastName1 = "Bunesh";
            string patronymic1 = "Igorevich";
            string firstName2 = "Vlad";
            string lastName2 = "Drozd";
            string patronymic2 = "Valerevich";
            string firstName3 = "Alex";
            string lastName3 = "Kozlov";
            string patronymic3 = "Vladimirovich";
            string firstName4 = "Dmitry";
            string lastName4 = "Voronich";
            string patronymic4 = "Valerevich";

            GetFullName(firstName1, lastName1, patronymic1);
            GetFullName(firstName2, lastName2, patronymic2);
            GetFullName(firstName3, lastName3, patronymic3);
            GetFullName(firstName4, lastName4, patronymic4);

        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
            return string.Empty;
        }
    }
}
