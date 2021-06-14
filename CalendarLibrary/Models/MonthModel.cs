using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLibrary.Models
{
    public class MonthModel
    {
        /// <summary>
        /// The name of the created month
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of days in a given month
        /// </summary>
        public int NumberOfDays { get; set; }

        /// <summary>
        /// A Untility Property that returns the number of Seconds in a month
        /// </summary>
        public int NumberOfSeconds { get { return NumberOfDays * 24 * 60 * 60; } }

        public MonthModel(string name, int days)
        {
            Name = name;
            NumberOfDays = days;
        }
    }
}
