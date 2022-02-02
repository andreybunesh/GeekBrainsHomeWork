using System;

namespace Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Good Morning";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }   
           
    }
}
