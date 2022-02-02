using System;

namespace Lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebookArray = new string[5, 2]

            {
                // Name, phone number/ e-mail
                { "Alex","+130458585848/alex@test.com"},
                { "Victor","+435458585848/victor@test.com"},
                { "Tim","+879985848/Tim@test.com"},
                { "Bob","+877858585848/Bobex@test.com"},
                { "Yan","90436448585848/Yan@test.com"}
            };
            var height = phonebookArray.GetLength(0);
            var weight = phonebookArray.GetLength(1);

            Console.WriteLine("Now you can see phonebook list: ");

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($"name: {phonebookArray[i,0]}, phonenumber: {phonebookArray[i, 1]}");
            }
        }
    }
}
