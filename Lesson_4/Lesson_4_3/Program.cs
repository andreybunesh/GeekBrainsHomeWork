using System;
    //Написать метод по определению времени года. 
    //На вход подаётся число – порядковый номер месяца. 
    //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
    //Написать метод, принимающий на вход значение 
    //из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
    //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
    //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

namespace Lesson_4_3
{
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of month");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber>12 || monthNumber<1)
            {
                System.Console.WriteLine("Error: Please enter a number between 1 and 12");
                return;
            }
            var season = FindingTheSeason(monthNumber);
            var seasonString = GetMonth(season);
            Console.WriteLine(seasonString);
         } 

        static string  GetMonth(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    {
                        return "Весна";
                    }
                case Season.Summer:
                    {
                        return "Лето";
                    }
                case Season.Autumn:
                    {
                        return "Осень";
                    }
                default:
                    {
                        return "Зима";
                    }                                       
            }
        }

        static Season FindingTheSeason(int monthNumber)
        {       
            switch (monthNumber)
            {
                case 3:
                case 4:
                case 5:
                    {
                        return Season.Spring;
                       
                    }
                case 6:
                case 7:
                case 8:
                    {
                        return Season.Summer;
                      
                    }
                case 9:
                case 10:
                case 11:
                    {
                        return Season.Autumn;
                       
                    }
                default:
                    {
                        return Season.Winter;
                    }
            }
          
        }

    }
}
