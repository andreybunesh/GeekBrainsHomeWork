using System;
using System.Diagnostics;
namespace Lessons_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var procList = Process.GetProcesses();
            for (int i = 0; i < procList.Length; i++)
            {
                Console.WriteLine($"{procList[i].Id,10} {procList[i].ProcessName,30} {procList[i].BasePriority,20}");
            }

            Console.WriteLine("Enter ID of process which you want to kill");
            var processId = Convert.ToInt32(Console.ReadLine());
            try
            {
                 Process.GetProcessById(processId).Kill();
            }
            catch (Exception)
            {

                Console.WriteLine("Something go wrong");
            }
        }
    }
}
