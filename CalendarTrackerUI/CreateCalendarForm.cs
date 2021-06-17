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
    public partial class CreateCalendarForm : Form
    {

        //TODO - Allow user to add to list view
        //TODO - Allow user to remove from list view
        //TODO - Allow user to reorder list view

        //TODO - Allow user to edit current Date

        bool updatingValues = false;

        public CreateCalendarForm()
        {
            InitializeComponent();
        }

        private void CreateCalendarForm_Load(object sender, EventArgs e)
        {
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
                new MonthModel("October", 31),
                new MonthModel("November", 30),
                new MonthModel("December", 31)
            };

            foreach (MonthModel month in m)
            {
                var row = new string[] {month.Name, month.NumberOfDays.ToString()};
                var lvi = new ListViewItem(row);

                lvi.Tag = month;
                listViewMonths.Items.Add(lvi);
            }
        }

        private void listViewMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewMonths.SelectedItems.Count == 1)
            {
                MonthModel m = (MonthModel)listViewMonths.SelectedItems[0].Tag;

                updatingValues = true;
                textBoxSelectedItemName.Text = m.Name;
                numericUpDownSelectedItemDays.Value = Convert.ToDecimal(m.NumberOfDays);
                updatingValues = false;                
            }
            //else
            //{
            //    textBoxSelectedItemName.Text = "";
            //    numericUpDownSelectedItemDays.Value = 1;
            //}
        }

        private void selectedValuesChanged(object sender, EventArgs e)
        {
            if (updatingValues) return;

            if(listViewMonths.SelectedItems.Count == 1)
            {
                MonthModel m = (MonthModel)listViewMonths.SelectedItems[0].Tag;

                string newName = textBoxSelectedItemName.Text;
                int newDays = Convert.ToInt32(numericUpDownSelectedItemDays.Value);

                listViewMonths.SelectedItems[0].SubItems[0].Text = newName;
                listViewMonths.SelectedItems[0].SubItems[1].Text = newDays.ToString();

                m.Name = newName;
                m.NumberOfDays = newDays;
                listViewMonths.SelectedItems[0].Tag = m;
            }
        }
    }
}
