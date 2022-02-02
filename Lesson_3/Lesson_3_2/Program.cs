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
                { "Alex","130458585848/alex@test.com"},
                { "Alex","130458585848/alex@test.com"},
                { "Alex","+130458585848/alex@test.com"},
                { "Yan","130458585848/alex@test.com"}
            };
            var height = phonebookArray.GetLength(0);
            var weight = phonebookArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($"name: {phonebookArray[i,0]}, phonenumber: {phonebookArray[i, 1]}");
            }
        }
    }
}
