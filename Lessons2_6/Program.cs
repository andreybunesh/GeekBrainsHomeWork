using System;

namespace Lessons2_6
{

    //(*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели,
    //    к примеру, чтобы описать работу какого либо офиса.
    //    Явный пример - офис номер 1 работает со вторника до пятницы,
    //    офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли
    class Program
    {
        [Flags]
        public enum DaysOfWeek
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }

        static void Main(string[] args)
        {
            DaysOfWeek office01 = (DaysOfWeek)0b_0011111;
            DaysOfWeek office02 = (DaysOfWeek)0b_1111111;
            DaysOfWeek office03 = (DaysOfWeek)0b_1111100;
            DaysOfWeek office04 = (DaysOfWeek)0b_1110011;
            DaysOfWeek office05 = (DaysOfWeek)0b_1110111;
            DaysOfWeek office06 = (DaysOfWeek)0b_1101101;
            DaysOfWeek office07 = (DaysOfWeek)0b_0111110;
            Console.WriteLine("Enter number of the office:");
            //Пользователь вводит номер офиса
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine($"Office #{num}. Working on: {office01}.");
                    break;
                case 2:
                    Console.WriteLine($"Office #{num}. Working on: {office02}.");
                    break;
                case 3:
                    Console.WriteLine($"Office #{num}. Working on:  {office03}.");
                    break;
                case 4:
                    Console.WriteLine($"Office #{num}. Working on: {office04}.");
                    break;
                case 5:
                    Console.WriteLine($"Office #{num}. Working on: {office05}.");
                    break;
                case 6:
                    Console.WriteLine($"Office #{num}. Working on: {office06}.");
                    break;
                case 7:
                    Console.WriteLine($"Office #{num}. Working on: {office07}.");
                    break;
                default:
                    Console.WriteLine("We have only 7 offices");
                    break;
            }
        }
    }
}
