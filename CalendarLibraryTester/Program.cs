using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalendarLibrary.Models;

namespace CalendarLibraryTester
{
    class Program
    {
        // This  is just a test console application to test that the Calendar is working correctly.
        static void Main(string[] args)
        {
            Console.WriteLine("Making Test Calendar...");
            CalendarModel c = new CalendarModel(); // This Should Create a Gregorian Calendar

            string output = "Months: ";
            foreach (MonthModel month in c.Months)
            {
                output += $"{ month.Name }:{ month.NumberOfDays }, ";
            }

            output = output.Substring(0, output.Length - 2);
            Console.SetWindowSize(output.Length + 4, Console.WindowHeight);
            Console.WriteLine(output);

            Console.WriteLine("");
            Console.WriteLine($"Current Date: { c.GetDate().ToString() }");
            Console.WriteLine($"Current Time: { c.GetTime().ToString() }");
            Console.WriteLine("");

            Console.WriteLine("Adding 12 Hours");
            c.AddTime(43200);
            Console.WriteLine($"Current Date: { c.GetDate().ToString() }");
            Console.WriteLine($"Current Time: { c.GetTime().ToString() }");
            Console.WriteLine("");

            Console.WriteLine("Skipping to Tomorrow at 9am");
            c.ToNext(new TimeModel(9, 0, 0));
            Console.WriteLine($"Current Date: { c.GetDate().ToString() }");
            Console.WriteLine($"Current Time: { c.GetTime().ToString() }");
            Console.WriteLine("");

            Console.WriteLine("Skipping to 9pm, 2100 Hours");
            c.ToNext(new TimeModel(21, 0, 0));
            Console.WriteLine($"Current Date: { c.GetDate().ToString() }");
            Console.WriteLine($"Current Time: { c.GetTime().ToString() }");
            Console.WriteLine("");

            Console.WriteLine("Skipping 60 days");
            c.AddTime(86400 * 60);
            Console.WriteLine($"Current Date: { c.GetDate().ToString() }");
            Console.WriteLine($"Current Time: { c.GetTime().ToString() }");
            Console.WriteLine("");

            Console.WriteLine("Skipping 365 days");
            c.AddTime(86400 * 365);
            Console.WriteLine($"Current Date: { c.GetDate().ToString() }");
            Console.WriteLine($"Current Time: { c.GetTime().ToString() }");
            Console.WriteLine("");

            Console.WriteLine("Press Enter to begin checking mass time passing");
            Console.ReadLine();

            int secondsToPass = 31540000;
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < secondsToPass; i++)
            {
                c.AddTime(1);
                c.GetDate().ToString();
                c.GetTime().ToString();
            }
            DateTime endTime = DateTime.Now;

            Console.WriteLine($"Calculated {secondsToPass} seconds, it took {endTime.Subtract(startTime).TotalMilliseconds} Milliseconds");
            Console.WriteLine($"That totals {secondsToPass/ endTime.Subtract(startTime).TotalSeconds} adds/reads per second");

            EndProgram();
        }

        public static void EndProgram()
        {
            Console.WriteLine("\nPress Enter To Continue");
            Console.ReadLine();
        }
    }
}
