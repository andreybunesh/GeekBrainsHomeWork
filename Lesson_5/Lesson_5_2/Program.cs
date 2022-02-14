using System;
using System.IO;
namespace Lesson_5_2
{

   // Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\AndreyBunesh\\Desktop\\repo-homework\\GeekBrainsHomeWork\\Lesson_5\\Lesson_5_2\\startup.txt";
            File.AppendAllText(fileName, DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        }
    }
}
