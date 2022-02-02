using System;

namespace Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] NewArray = new int[,]
                 {
               {2,45,24,34,45,12,6,8,4},
               {3,34,54,75,56,3,12,37,67},
               {7,9,46,1,2,5,97,34,12},
               {5,4,6,31,45,51,90,1,5},
               {6,30,71,3,8,6,15,78,3},
               {3,94,54,75,56,3,12,37,67},
               {2,45,24,34,45,12,6,8,4},
               {7,9,43,1,2,5,97,34,12},
               {6,30,71,3,8,6,15,78,3}
                 };

            int height = NewArray.GetLength(0);
            int weight = NewArray.GetLength(1);

            Console.WriteLine("Now you can see diagonal  Мой тестовый пример");
              
            for (var i = 0; i< height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    if (i == j)
                    {
                       Console.WriteLine($"{new String(' ', 3*i)}{NewArray[i, j]}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
