using System;

namespace Lesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] Sea​Battle = new char[,]
       {
                    {'O','X','O','O','O','O','O','X','X','O'},
                    {'O','O','O','X','O','O','O','O','O','X'},
                    {'O','O','O','O','O','X','X','X','O','X'},
                    {'O','X','O','O','O','O','O','O','O','X'},
                    {'O','O','O','O','O','O','O','O','O','O'},
                    {'X','O','X','X','X','O','O','O','O','O'},
                    {'O','O','O','O','O','O','O','X','O','O'},
                    {'O','O','O','O','O','O','O','X','O','O'},
                    {'O','X','O','O','O','O','O','X','O','O'},
                    {'O','X','O','X','X','O','O','X','O','O'},

       };
            int height = Sea​Battle.GetLength(0);
            int weight = Sea​Battle.GetLength(1);

            for (var i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    Console.Write(Sea​Battle[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
