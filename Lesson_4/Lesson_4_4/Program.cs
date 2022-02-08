using System;

//(*) Написать программу, вычисляющую число Фибоначчи 
//    для заданного значения рекурсивным способом. 

namespace Lesson_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enter the number N of the element to be determined");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number of Fibonachy: {GetFibbonachy(f)}");
        }
        public static int GetFibbonachy(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return GetFibbonachy(n - 1) + GetFibbonachy(n - 2);
        }
    }
}
