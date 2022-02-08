using System;
using System.Text;
//Написать программу, принимающую на вход строку — набор чисел,
//разделенных пробелом, и возвращающую число — сумму всех чисел в строке.
//Ввести данные с клавиатуры и вывести результат на экран.

namespace Lesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any numbers separate space");
            string allNumbers = Console.ReadLine();
            int sum = 0;
            string newLine = string.Empty;

            for (int i = 0; i < allNumbers.Length; i++)
            {

                char currentNumber = allNumbers[i];
                if (i == allNumbers.Length - 1)
                {
                    newLine += currentNumber;
                    sum += Convert.ToInt32(newLine.ToString());
                }
                else if (currentNumber != ' ')
                {
                    newLine += currentNumber;
                }
                else
                {
                    sum += Convert.ToInt32(newLine.ToString());
                    newLine = string.Empty;
                }
                                      
            }
            Console.WriteLine(sum);
            
        }
    }
}
