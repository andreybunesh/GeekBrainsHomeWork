using System;
using System.IO;
namespace Lesson_5_1
{
   // Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please, enter any values");
            string textExample = Console.ReadLine();
            var path = "C:\\Users\\AndreyBunesh\\Desktop\\repo-homework\\GeekBrainsHomeWork\\Lesson_5\\Lesson_5_1\\textFile.txt";
             File.WriteAllText(path, textExample);
        } 
    }
}
