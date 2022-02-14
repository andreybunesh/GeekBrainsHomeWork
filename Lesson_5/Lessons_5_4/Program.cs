using System;
using System.IO;
namespace Lessons_5_4
{
    //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
    class Program
    {
        static void Main(string[] args)
        {

            var path = "C:\\Users\\AndreyBunesh\\Desktop\\repo-homework\\GeekBrainsHomeWork\\Lesson_5\\Lesson_5_1\\textFile.txt";
            var generalPass = "C:\\Users\\AndreyBunesh\\Desktop\\repo-homework\\GeekBrainsHomeWork\\Lesson_5\\";
            File.WriteAllText(path, string.Empty);
            GetInfoPath(generalPass, path);

        }
        private static void GetInfoPath(string path, string filePath)
        {
            Console.WriteLine("Dirrectory : " + path);
            File.AppendAllText(filePath, "Dirrectory: " + path);
            File.AppendAllText(filePath, Environment.NewLine);
            GetFiles(path, filePath);
            var dirs = Directory.GetDirectories(path);

            for (int j = 0; j < dirs.Length; j++)
            {

                GetInfoPath(dirs[j], filePath);
            }
        }
        private static void GetFiles(string path, string filePath)
        {
            var files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine("File : " + files[i]);
                File.AppendAllText(filePath, "File : " + files[i]);
                File.AppendAllText(filePath, Environment.NewLine);

            }
        }
    }
}
