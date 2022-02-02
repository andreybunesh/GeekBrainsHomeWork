using System;
using System.Text;

namespace Lessons2_5
{

    //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = Encoding.GetEncoding(1251);


            Console.WriteLine("Enter Min Temperature per day");
            decimal minTemperature = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Max Temperature per day");
            decimal maxTemperature = Convert.ToDecimal(Console.ReadLine());
            decimal middleTemperature = (minTemperature + maxTemperature) / 2;

            Console.WriteLine("Enter number of month");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());
            if ((middleTemperature > 0)&&(MonthNumber == 12 || MonthNumber == 1 || MonthNumber == 2))
            {
                Console.WriteLine("Rainy Winter");
            } else
            {
                Console.WriteLine("Middle Temperature is " + middleTemperature + " °С");
            }
        }
    }
}
