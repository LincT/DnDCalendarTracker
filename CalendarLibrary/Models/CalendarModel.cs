using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLibrary.Models
{
    public class CalendarModel
    {
        /// <summary>
        /// An array with every month of a year
        /// </summary>
        public MonthModel[] Months { get; set; }
        /// <summary>
        /// Int, containing the current year -numbers = BCE equivelent times
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// The current time during the year. The main varaiable to track the time
        /// </summary>
        public int CurrentTimeInSeconds { get; private set; }
        /// <summary>
        /// A property that auto calculates the number of seconds within all of the months
        /// </summary>
        public int TotalSecondsInYear { get {
                int output = 0;
                foreach (MonthModel month in Months)
                {
                    output += month.NumberOfSeconds;
                }
                return output;
            } }

        /// <summary>
        /// Constructs a Calendar with the Gregorian base.
        /// and sets the current date to Midnight on January, 1st 2000
        /// </summary>
        public CalendarModel()
        {
            // if no Calendar is given create Gregoirian
            MonthModel[] m = {
                new MonthModel("January", 31),
                new MonthModel("Febuary", 28),
                new MonthModel("March", 31),
                new MonthModel("April", 30),
                new MonthModel("May", 31),
                new MonthModel("June", 30),
                new MonthModel("July", 31),
                new MonthModel("August", 31),
                new MonthModel("September", 30),
                new MonthModel("Octiober", 31),
                new MonthModel("November", 30),
                new MonthModel("December", 31)
            };

            Months = m;
            Year = 2000;
            CurrentTimeInSeconds = 0;
        }

        /// <summary>
        /// Constructs a Calendar with the given months
        /// and sets the current date to Midnight on the first day of the year in
        /// the year 2000
        /// </summary>
        /// <param name="months"></param>
        public CalendarModel( MonthModel[] months)
        {
            Months = months;
            Year = 2000;
            CurrentTimeInSeconds = 0;
        }

        /// <summary>
        /// Takes a DateStructure and uses it to set the current year and time
        /// This should only be used to set the inital date.
        /// </summary>
        /// <param name="newDate"></param>
        public void SetFullDate (Date newDate, TimeModel newTime)
        {
            Year = newDate.Year;

            CurrentTimeInSeconds = 0;

            foreach (MonthModel month in Months)
            {
                if(month.Name != newDate.Month.Name)
                {
                    CurrentTimeInSeconds += month.NumberOfSeconds;
                }
                else
                {
                    break;
                }
            }

            CurrentTimeInSeconds += newDate.Day * 86400;
            CurrentTimeInSeconds += newTime.TotalSeconds;
        }

        /// <summary>
        /// This is the simplest way to add time to the calendar
        /// it adds the time wanted and updates the year acordingly.
        /// </summary>
        /// <param name="Seconds">Takes in a number of seconds to increase or decreace the time by</param>
        public void AddTime(int Seconds)
        {
            CurrentTimeInSeconds += Seconds;
            if (CurrentTimeInSeconds > TotalSecondsInYear)
            {
                CurrentTimeInSeconds -= TotalSecondsInYear;
                Year++;
            }

            if (CurrentTimeInSeconds < 0)
            {
                CurrentTimeInSeconds = TotalSecondsInYear - Math.Abs(CurrentTimeInSeconds);
                Year--;
            }
        }
        /// <summary>
        /// Takes in a TimeModel 
        /// </summary>
        /// <param name="ClockTime"></param>
        public void ToNext(TimeModel ClockTime)
        {
            TimeModel currentTime = GetTime();
            AddTime(currentTime.TimeUntil(ClockTime));

        }

        /// <summary>
        /// Get a TimeModel of the calendar's CurrentTime
        /// </summary>
        /// <returns></returns>
        public TimeModel GetTime()
        {
            int timeLeft;
            GetTimeLeftInMonth(out timeLeft);

            return new TimeModel(timeLeft % 86400);
        }

        /// <summary>
        /// Get a Date Structure of the calendar's current date
        /// </summary>
        /// <returns></returns>
        public Date GetDate()
        {
            int timeLeft;
            int currentMonth = GetTimeLeftInMonth(out timeLeft);

            return new Date((timeLeft / 86400) + 1, Months[currentMonth], Year);
        }

        /// <summary>
        /// Gets the Time left in the month and what month it is.
        /// </summary>
        /// <param name="timeLeft">an output paramiter of the time left</param>
        /// <returns>the index of the current month</returns>
        public int GetTimeLeftInMonth(out int timeLeft)
        {
            timeLeft = CurrentTimeInSeconds;
            int currentMonth = 0;
            for (int i = 0; i < Months.Length; i++)
            {
                if (timeLeft < Months[i].NumberOfSeconds)
                {
                    currentMonth = i;
                    break;
                }
                else
                {
                    timeLeft -= Months[i].NumberOfSeconds;
                }
            }
            return currentMonth;
        }
    }

    /// <summary>
    /// A structure of the current date
    /// </summary>
    public struct Date
    {
        public int Day { get; set; }

        public MonthModel Month { get; set; }

        public int Year { get; set; }
        
        public Date(int day, MonthModel month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{ Day }/{ Month.Name }/{ Year }";
        }
    }
}
