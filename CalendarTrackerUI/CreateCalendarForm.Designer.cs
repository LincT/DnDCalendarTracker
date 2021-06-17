
namespace CalendarTrackerUI
{
    partial class CreateCalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewMonths = new System.Windows.Forms.ListView();
            this.monthName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.textBoxSelectedItemName = new System.Windows.Forms.TextBox();
            this.buttonMoveItemUp = new System.Windows.Forms.Button();
            this.buttonMoveItemDown = new System.Windows.Forms.Button();
            this.comboBoxCurrentMonth = new System.Windows.Forms.ComboBox();
            this.labelMonthsListView = new System.Windows.Forms.Label();
            this.labelCurrentDate_Month = new System.Windows.Forms.Label();
            this.labelCurrentDate_Day = new System.Windows.Forms.Label();
            this.labelCurrentDate_Year = new System.Windows.Forms.Label();
            this.groupBoxCurrentDate = new System.Windows.Forms.GroupBox();
            this.labelSelectedItemName = new System.Windows.Forms.Label();
            this.labelSelectedItemDays = new System.Windows.Forms.Label();
            this.numericUpDownSelectedItemDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCurrentYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCurrentDay = new System.Windows.Forms.NumericUpDown();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxCurrentDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedItemDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentDay)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMonths
            // 
            this.listViewMonths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.monthName,
            this.monthDays});
            this.listViewMonths.FullRowSelect = true;
            this.listViewMonths.GridLines = true;
            this.listViewMonths.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMonths.HideSelection = false;
            this.listViewMonths.Location = new System.Drawing.Point(12, 43);
            this.listViewMonths.Name = "listViewMonths";
            this.listViewMonths.Size = new System.Drawing.Size(274, 198);
            this.listViewMonths.TabIndex = 0;
            this.listViewMonths.UseCompatibleStateImageBehavior = false;
            this.listViewMonths.View = System.Windows.Forms.View.Details;
            this.listViewMonths.SelectedIndexChanged += new System.EventHandler(this.listViewMonths_SelectedIndexChanged);
            // 
            // monthName
            // 
            this.monthName.Text = "Name";
            this.monthName.Width = 120;
            // 
            // monthDays
            // 
            this.monthDays.Text = "Days";
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.Location = new System.Drawing.Point(385, 168);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNewItem.TabIndex = 1;
            this.buttonNewItem.Text = "New";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(304, 168);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 2;
            this.buttonDeleteItem.Text = "Delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            // 
            // textBoxSelectedItemName
            // 
            this.textBoxSelectedItemName.Location = new System.Drawing.Point(304, 213);
            this.textBoxSelectedItemName.Name = "textBoxSelectedItemName";
            this.textBoxSelectedItemName.Size = new System.Drawing.Size(115, 20);
            this.textBoxSelectedItemName.TabIndex = 3;
            this.textBoxSelectedItemName.TextChanged += new System.EventHandler(this.selectedValuesChanged);
            // 
            // buttonMoveItemUp
            // 
            this.buttonMoveItemUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveItemUp.Location = new System.Drawing.Point(292, 43);
            this.buttonMoveItemUp.Name = "buttonMoveItemUp";
            this.buttonMoveItemUp.Size = new System.Drawing.Size(25, 40);
            this.buttonMoveItemUp.TabIndex = 5;
            this.buttonMoveItemUp.Text = "↑";
            this.buttonMoveItemUp.UseVisualStyleBackColor = true;
            // 
            // buttonMoveItemDown
            // 
            this.buttonMoveItemDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveItemDown.Location = new System.Drawing.Point(292, 89);
            this.buttonMoveItemDown.Name = "buttonMoveItemDown";
            this.buttonMoveItemDown.Size = new System.Drawing.Size(25, 40);
            this.buttonMoveItemDown.TabIndex = 6;
            this.buttonMoveItemDown.Text = "↓";
            this.buttonMoveItemDown.UseVisualStyleBackColor = true;
            // 
            // comboBoxCurrentMonth
            // 
            this.comboBoxCurrentMonth.FormattingEnabled = true;
            this.comboBoxCurrentMonth.Location = new System.Drawing.Point(21, 46);
            this.comboBoxCurrentMonth.Name = "comboBoxCurrentMonth";
            this.comboBoxCurrentMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurrentMonth.TabIndex = 7;
            // 
            // labelMonthsListView
            // 
            this.labelMonthsListView.AutoSize = true;
            this.labelMonthsListView.Location = new System.Drawing.Point(12, 27);
            this.labelMonthsListView.Name = "labelMonthsListView";
            this.labelMonthsListView.Size = new System.Drawing.Size(96, 13);
            this.labelMonthsListView.TabIndex = 10;
            this.labelMonthsListView.Text = "Months in the Year";
            // 
            // labelCurrentDate_Month
            // 
            this.labelCurrentDate_Month.AutoSize = true;
            this.labelCurrentDate_Month.Location = new System.Drawing.Point(18, 27);
            this.labelCurrentDate_Month.Name = "labelCurrentDate_Month";
            this.labelCurrentDate_Month.Size = new System.Drawing.Size(37, 13);
            this.labelCurrentDate_Month.TabIndex = 12;
            this.labelCurrentDate_Month.Text = "Month";
            // 
            // labelCurrentDate_Day
            // 
            this.labelCurrentDate_Day.AutoSize = true;
            this.labelCurrentDate_Day.Location = new System.Drawing.Point(145, 27);
            this.labelCurrentDate_Day.Name = "labelCurrentDate_Day";
            this.labelCurrentDate_Day.Size = new System.Drawing.Size(26, 13);
            this.labelCurrentDate_Day.TabIndex = 13;
            this.labelCurrentDate_Day.Text = "Day";
            // 
            // labelCurrentDate_Year
            // 
            this.labelCurrentDate_Year.AutoSize = true;
            this.labelCurrentDate_Year.Location = new System.Drawing.Point(194, 27);
            this.labelCurrentDate_Year.Name = "labelCurrentDate_Year";
            this.labelCurrentDate_Year.Size = new System.Drawing.Size(29, 13);
            this.labelCurrentDate_Year.TabIndex = 14;
            this.labelCurrentDate_Year.Text = "Year";
            // 
            // groupBoxCurrentDate
            // 
            this.groupBoxCurrentDate.Controls.Add(this.numericUpDownCurrentYear);
            this.groupBoxCurrentDate.Controls.Add(this.numericUpDownCurrentDay);
            this.groupBoxCurrentDate.Controls.Add(this.labelCurrentDate_Year);
            this.groupBoxCurrentDate.Controls.Add(this.comboBoxCurrentMonth);
            this.groupBoxCurrentDate.Controls.Add(this.labelCurrentDate_Day);
            this.groupBoxCurrentDate.Controls.Add(this.labelCurrentDate_Month);
            this.groupBoxCurrentDate.Location = new System.Drawing.Point(15, 280);
            this.groupBoxCurrentDate.Name = "groupBoxCurrentDate";
            this.groupBoxCurrentDate.Size = new System.Drawing.Size(283, 101);
            this.groupBoxCurrentDate.TabIndex = 15;
            this.groupBoxCurrentDate.TabStop = false;
            this.groupBoxCurrentDate.Text = "Current Date";
            // 
            // labelSelectedItemName
            // 
            this.labelSelectedItemName.AutoSize = true;
            this.labelSelectedItemName.Location = new System.Drawing.Point(304, 198);
            this.labelSelectedItemName.Name = "labelSelectedItemName";
            this.labelSelectedItemName.Size = new System.Drawing.Size(35, 13);
            this.labelSelectedItemName.TabIndex = 16;
            this.labelSelectedItemName.Text = "Name";
            // 
            // labelSelectedItemDays
            // 
            this.labelSelectedItemDays.AutoSize = true;
            this.labelSelectedItemDays.Location = new System.Drawing.Point(425, 198);
            this.labelSelectedItemDays.Name = "labelSelectedItemDays";
            this.labelSelectedItemDays.Size = new System.Drawing.Size(31, 13);
            this.labelSelectedItemDays.TabIndex = 17;
            this.labelSelectedItemDays.Text = "Days";
            // 
            // numericUpDownSelectedItemDays
            // 
            this.numericUpDownSelectedItemDays.Location = new System.Drawing.Point(425, 213);
            this.numericUpDownSelectedItemDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedItemDays.Name = "numericUpDownSelectedItemDays";
            this.numericUpDownSelectedItemDays.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownSelectedItemDays.TabIndex = 18;
            this.numericUpDownSelectedItemDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedItemDays.ValueChanged += new System.EventHandler(this.selectedValuesChanged);
            // 
            // numericUpDownCurrentYear
            // 
            this.numericUpDownCurrentYear.Location = new System.Drawing.Point(197, 46);
            this.numericUpDownCurrentYear.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownCurrentYear.Name = "numericUpDownCurrentYear";
            this.numericUpDownCurrentYear.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownCurrentYear.TabIndex = 19;
            // 
            // numericUpDownCurrentDay
            // 
            this.numericUpDownCurrentDay.Location = new System.Drawing.Point(148, 47);
            this.numericUpDownCurrentDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCurrentDay.Name = "numericUpDownCurrentDay";
            this.numericUpDownCurrentDay.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownCurrentDay.TabIndex = 20;
            this.numericUpDownCurrentDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(307, 317);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(144, 37);
            this.buttonSubmit.TabIndex = 19;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // CreateCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 411);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.numericUpDownSelectedItemDays);
            this.Controls.Add(this.labelSelectedItemDays);
            this.Controls.Add(this.labelSelectedItemName);
            this.Controls.Add(this.groupBoxCurrentDate);
            this.Controls.Add(this.labelMonthsListView);
            this.Controls.Add(this.buttonMoveItemDown);
            this.Controls.Add(this.buttonMoveItemUp);
            this.Controls.Add(this.textBoxSelectedItemName);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonNewItem);
            this.Controls.Add(this.listViewMonths);
            this.Name = "CreateCalendarForm";
            this.Text = "CreateCalendarForm";
            this.Load += new System.EventHandler(this.CreateCalendarForm_Load);
            this.groupBoxCurrentDate.ResumeLayout(false);
            this.groupBoxCurrentDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedItemDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMonths;
        private System.Windows.Forms.ColumnHeader monthName;
        private System.Windows.Forms.ColumnHeader monthDays;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.TextBox textBoxSelectedItemName;
        private System.Windows.Forms.Button buttonMoveItemUp;
        private System.Windows.Forms.Button buttonMoveItemDown;
        private System.Windows.Forms.ComboBox comboBoxCurrentMonth;
        private System.Windows.Forms.Label labelMonthsListView;
        private System.Windows.Forms.Label labelCurrentDate_Month;
        private System.Windows.Forms.Label labelCurrentDate_Day;
        private System.Windows.Forms.Label labelCurrentDate_Year;
        private System.Windows.Forms.GroupBox groupBoxCurrentDate;
        private System.Windows.Forms.Label labelSelectedItemName;
        private System.Windows.Forms.Label labelSelectedItemDays;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedItemDays;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrentYear;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrentDay;
        private System.Windows.Forms.Button buttonSubmit;
    }
}