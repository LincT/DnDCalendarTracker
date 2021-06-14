
namespace CalendarTrackerUI
{
    partial class TimeControllForm
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
            this.components = new System.ComponentModel.Container();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.add6SecondsButton = new System.Windows.Forms.Button();
            this.add1HourButton = new System.Windows.Forms.Button();
            this.toDawnButton = new System.Windows.Forms.Button();
            this.toDuskButton = new System.Windows.Forms.Button();
            this.toMidnightButton = new System.Windows.Forms.Button();
            this.toNoonButton = new System.Windows.Forms.Button();
            this.subtract1Hour = new System.Windows.Forms.Button();
            this.subtract6Seconds = new System.Windows.Forms.Button();
            this.add10Minutes = new System.Windows.Forms.Button();
            this.subtract10Minutes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Location = new System.Drawing.Point(21, 21);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(35, 13);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "label1";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(21, 83);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(35, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "label1";
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Location = new System.Drawing.Point(298, 21);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(75, 23);
            this.PlayPauseButton.TabIndex = 2;
            this.PlayPauseButton.Text = "Play";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // add6SecondsButton
            // 
            this.add6SecondsButton.Location = new System.Drawing.Point(298, 83);
            this.add6SecondsButton.Name = "add6SecondsButton";
            this.add6SecondsButton.Size = new System.Drawing.Size(75, 23);
            this.add6SecondsButton.TabIndex = 3;
            this.add6SecondsButton.Text = "+6 Seconds";
            this.add6SecondsButton.UseVisualStyleBackColor = true;
            this.add6SecondsButton.Click += new System.EventHandler(this.add6SecondsButton_Click);
            // 
            // add1HourButton
            // 
            this.add1HourButton.Location = new System.Drawing.Point(379, 83);
            this.add1HourButton.Name = "add1HourButton";
            this.add1HourButton.Size = new System.Drawing.Size(75, 23);
            this.add1HourButton.TabIndex = 4;
            this.add1HourButton.Text = "+1 Hour";
            this.add1HourButton.UseVisualStyleBackColor = true;
            this.add1HourButton.Click += new System.EventHandler(this.add1HourButton_Click);
            // 
            // toDawnButton
            // 
            this.toDawnButton.Location = new System.Drawing.Point(298, 112);
            this.toDawnButton.Name = "toDawnButton";
            this.toDawnButton.Size = new System.Drawing.Size(75, 23);
            this.toDawnButton.TabIndex = 5;
            this.toDawnButton.Text = "To Dawn";
            this.toDawnButton.UseVisualStyleBackColor = true;
            this.toDawnButton.Click += new System.EventHandler(this.toDawnButton_Click);
            // 
            // toDuskButton
            // 
            this.toDuskButton.Location = new System.Drawing.Point(298, 141);
            this.toDuskButton.Name = "toDuskButton";
            this.toDuskButton.Size = new System.Drawing.Size(75, 23);
            this.toDuskButton.TabIndex = 6;
            this.toDuskButton.Text = "To Dusk";
            this.toDuskButton.UseVisualStyleBackColor = true;
            this.toDuskButton.Click += new System.EventHandler(this.toDuskButton_Click);
            // 
            // toMidnightButton
            // 
            this.toMidnightButton.Location = new System.Drawing.Point(379, 141);
            this.toMidnightButton.Name = "toMidnightButton";
            this.toMidnightButton.Size = new System.Drawing.Size(75, 23);
            this.toMidnightButton.TabIndex = 7;
            this.toMidnightButton.Text = "To Midnight";
            this.toMidnightButton.UseVisualStyleBackColor = true;
            this.toMidnightButton.Click += new System.EventHandler(this.toMidnightButton_Click);
            // 
            // toNoonButton
            // 
            this.toNoonButton.Location = new System.Drawing.Point(379, 112);
            this.toNoonButton.Name = "toNoonButton";
            this.toNoonButton.Size = new System.Drawing.Size(75, 23);
            this.toNoonButton.TabIndex = 8;
            this.toNoonButton.Text = "To Noon";
            this.toNoonButton.UseVisualStyleBackColor = true;
            this.toNoonButton.Click += new System.EventHandler(this.toNoonButton_Click);
            // 
            // subtract1Hour
            // 
            this.subtract1Hour.Location = new System.Drawing.Point(379, 170);
            this.subtract1Hour.Name = "subtract1Hour";
            this.subtract1Hour.Size = new System.Drawing.Size(75, 23);
            this.subtract1Hour.TabIndex = 10;
            this.subtract1Hour.Text = "-1 Hour";
            this.subtract1Hour.UseVisualStyleBackColor = true;
            this.subtract1Hour.Click += new System.EventHandler(this.subtract1Hour_Click);
            // 
            // subtract6Seconds
            // 
            this.subtract6Seconds.Location = new System.Drawing.Point(298, 170);
            this.subtract6Seconds.Name = "subtract6Seconds";
            this.subtract6Seconds.Size = new System.Drawing.Size(75, 23);
            this.subtract6Seconds.TabIndex = 9;
            this.subtract6Seconds.Text = "-6 Seconds";
            this.subtract6Seconds.UseVisualStyleBackColor = true;
            this.subtract6Seconds.Click += new System.EventHandler(this.subtract6Seconds_Click);
            // 
            // add10Minutes
            // 
            this.add10Minutes.Location = new System.Drawing.Point(217, 112);
            this.add10Minutes.Name = "add10Minutes";
            this.add10Minutes.Size = new System.Drawing.Size(75, 23);
            this.add10Minutes.TabIndex = 11;
            this.add10Minutes.Text = "+10 Minutes";
            this.add10Minutes.UseVisualStyleBackColor = true;
            this.add10Minutes.Click += new System.EventHandler(this.add10Minutes_Click);
            // 
            // subtract10Minutes
            // 
            this.subtract10Minutes.Location = new System.Drawing.Point(217, 141);
            this.subtract10Minutes.Name = "subtract10Minutes";
            this.subtract10Minutes.Size = new System.Drawing.Size(75, 23);
            this.subtract10Minutes.TabIndex = 12;
            this.subtract10Minutes.Text = "-10 Minutes";
            this.subtract10Minutes.UseVisualStyleBackColor = true;
            this.subtract10Minutes.Click += new System.EventHandler(this.subtract10Minutes_Click);
            // 
            // TimeControllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 215);
            this.Controls.Add(this.subtract10Minutes);
            this.Controls.Add(this.add10Minutes);
            this.Controls.Add(this.subtract1Hour);
            this.Controls.Add(this.subtract6Seconds);
            this.Controls.Add(this.toNoonButton);
            this.Controls.Add(this.toMidnightButton);
            this.Controls.Add(this.toDuskButton);
            this.Controls.Add(this.toDawnButton);
            this.Controls.Add(this.add1HourButton);
            this.Controls.Add(this.add6SecondsButton);
            this.Controls.Add(this.PlayPauseButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ClockLabel);
            this.Name = "TimeControllForm";
            this.Text = "Time Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button add6SecondsButton;
        private System.Windows.Forms.Button add1HourButton;
        private System.Windows.Forms.Button toDawnButton;
        private System.Windows.Forms.Button toDuskButton;
        private System.Windows.Forms.Button toMidnightButton;
        private System.Windows.Forms.Button toNoonButton;
        private System.Windows.Forms.Button subtract1Hour;
        private System.Windows.Forms.Button subtract6Seconds;
        private System.Windows.Forms.Button add10Minutes;
        private System.Windows.Forms.Button subtract10Minutes;
    }
}

