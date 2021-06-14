using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalendarLibrary.Models;

namespace CalendarTrackerUI
{
    public partial class TimeControllForm : Form
    {

        CalendarModel c;
        bool timeTicking = false;

        public TimeControllForm()
        {
            InitializeComponent();

            // TODO - Non-hardcoded Calendar
            MonthModel[] FaerunMonths = {
                new MonthModel("Hammer", 30),
                new MonthModel("Midwinter", 1),
                new MonthModel("Alturiak", 30),
                new MonthModel("Ches", 30),
                new MonthModel("Tarsakh", 30),
                new MonthModel("Greengrass", 1),
                new MonthModel("Mirtul", 30),
                new MonthModel("Kythorn", 30),
                new MonthModel("Flamerule", 30),
                new MonthModel("Midsummer", 1),
                new MonthModel("Eleasias", 30),
                new MonthModel("Eleint", 30),
                new MonthModel("Highharvestide", 1),
                new MonthModel("Marpenoth", 30),
                new MonthModel("Uktar", 30),
                new MonthModel("The Feast of the Moon", 1),
                new MonthModel("Nightal", 30)
            };

            c = new CalendarModel( FaerunMonths );

            // Non-hardcoded Date
            Date date = new Date(
                20,
                c.Months[7],
                1492
                );
            TimeModel time = new TimeModel(
                17,
                30,
                0
                );


            c.SetFullDate(date, time);

            updateClock();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            if (timeTicking)
            {
                c.AddTime(1);
            }

            updateClock();
        }

        /// <summary>
        /// Updates the strings of the current time
        /// </summary>
        private void updateClock()
        {
            // NOTE - These currently create new TimeModel, and Date objects
            // While they should be garbage collected fine it might be better
            // if we didn't create new objects.
            ClockLabel.Text = c.GetTime().To12HourClock();
            DateLabel.Text = c.GetDate().ToString();
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            timeTicking = !timeTicking;
            if (timeTicking)
                PlayPauseButton.Text = "Pause";
            else
                PlayPauseButton.Text = "Play";

        }

        private void add6SecondsButton_Click(object sender, EventArgs e)
        {
            c.AddTime(6);
            updateClock();
        }

        private void add1HourButton_Click(object sender, EventArgs e)
        {
            c.AddTime(60 * 60);
            updateClock();
        }

        private void toDawnButton_Click(object sender, EventArgs e)
        {
            c.ToNext(new TimeModel(5, 0, 0));
            updateClock();
        }

        private void toDuskButton_Click(object sender, EventArgs e)
        {
            c.ToNext(new TimeModel(19, 0, 0));
            updateClock();
        }

        private void toNoonButton_Click(object sender, EventArgs e)
        {
            c.ToNext(new TimeModel(12, 0, 0));
            updateClock();
        }

        private void toMidnightButton_Click(object sender, EventArgs e)
        {
            c.ToNext(new TimeModel(0, 0, 0));
            updateClock();
        }

        private void subtract6Seconds_Click(object sender, EventArgs e)
        {
            c.AddTime(-6);
            updateClock();
        }

        private void subtract1Hour_Click(object sender, EventArgs e)
        {
            c.AddTime(-60 * 60);
            updateClock();
        }

        private void add10Minutes_Click(object sender, EventArgs e)
        {
            c.AddTime(10 * 60);
            updateClock();
        }

        private void subtract10Minutes_Click(object sender, EventArgs e)
        {
            c.AddTime(-10 * 60);
            updateClock();
        }
    }
}
