using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLibrary.Models
{
    /// <summary>
    /// The Time Model is a easy access model for the time of day.
    /// </summary>
    public class TimeModel
    {
        /// <summary>
        /// Hours into the day it is, between 0 - 23
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// Minutes on the hour, between 0 - 59
        /// </summary>
        public int Minutes { get; set; }
        /// <summary>
        /// Seconds on the minute, between 0 - 59
        /// </summary>
        public int Seconds { get; set; }

        /// <summary>
        /// A property that allows you to get the total seconds passed for the current time.
        /// </summary>
        public int TotalSeconds { get { return ((Hours * 60) + Minutes) * 60 + Seconds; } }

        /// <summary>
        /// Creates a TimeModel that is sets to a number of seconds that has past.
        /// </summary>
        /// <param name="seconds"> number of seconds passed in the day</param>
        public TimeModel(int seconds)
        {
            if (seconds > 86400)
            {
                throw new System.ArgumentOutOfRangeException("seconds", "When creating a TimeModel, Seconds input must be less than 1 day");
            }
            else if (seconds < 0)
            {
                throw new System.ArgumentOutOfRangeException("seconds", "When creating a TimeModel, Seconds input must be greater than 0");
            }

            Seconds = seconds % 60;

            Minutes = (seconds - Seconds) / 60;

            Hours = Minutes / 60;

            Minutes = Minutes % 60;
        }

        /// <summary>
        /// Creates a TimeModel object given more readable time amounts.
        /// </summary>
        /// <param name="hours">Number of hours passed</param>
        /// <param name="minutes">Number of minutes passed</param>
        /// <param name="seconds">Number of seconds passed</param>
        public TimeModel(int hours, int minutes, int seconds) : this(((hours * 60) + minutes) * 60 + seconds)
        {

        }

        // TODO - Time to and From Strings
        // Using both "13:40" and "1:40pm" Formats

        // operator overides for mathing with TimeModels
        public static bool operator >(TimeModel a, TimeModel b) => a.TotalSeconds > b.TotalSeconds;
        public static bool operator <(TimeModel a, TimeModel b) => a.TotalSeconds < b.TotalSeconds;
        public static TimeModel operator -(TimeModel a, TimeModel b)
            => new TimeModel(a.TotalSeconds - b.TotalSeconds);
        public static TimeModel operator +(TimeModel a, TimeModel b)
            => new TimeModel(a.TotalSeconds + b.TotalSeconds);

        /// <summary>
        /// Calulate how much time it is until a given time
        /// </summary>
        /// <param name="time_2">the given time to check</param>
        /// <returns></returns>
        public int TimeUntil(TimeModel time_2)
        {
            if (time_2 > this)
            {
                return (time_2 - this).TotalSeconds;
            }
            else
            {
                int timeUntil = 86400 - this.TotalSeconds;
                timeUntil += time_2.TotalSeconds;
                return timeUntil;
            }
        }

        /// <summary>
        /// Gives a readable string of the time in military time
        /// </summary>
        public override string ToString()
        {
                return $"{ Hours }:{ Minutes.ToString("D2") }:{ Seconds.ToString("D2") }";
        }
        /// <summary>
        /// Gives a readable string of the time in military time
        /// </summary>
        public string To12HourClock()
        {
            int hours = Hours;
            string timePeriod = hours < 12 ? "AM" : "PM";

            if (hours == 0)
            { 
                hours = 12;
            }else if (hours > 12)
            {
                hours -= 12;
            }



            return $"{ hours }:{ Minutes.ToString("D2") }:{ Seconds.ToString("D2") } { timePeriod }";
        }
    }
}
