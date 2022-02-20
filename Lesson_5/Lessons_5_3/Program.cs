using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lessons_5_3
{
    // Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
    /// <summary>
    /// [Serializable]
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number from 0 to 255");
            int number = Convert.ToInt32(Console.ReadLine());
            var fileName = "Binar.bin";

            var fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            {
                using (var bw = new BinaryWriter(fs))
                {
                    bw.Write(number);
                }
            }
        }

    }
}
