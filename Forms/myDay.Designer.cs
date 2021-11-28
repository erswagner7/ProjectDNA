
namespace PrototypeDNA.Forms
{
    partial class myDay
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
            this.btnUserMyDayTaken = new System.Windows.Forms.Button();
            this.btnUserMyDayNotTaken = new System.Windows.Forms.Button();
            this.pnlUserMyDayMedications = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMyDayReminders = new System.Windows.Forms.Label();
            this.pnlMyDayReminders = new System.Windows.Forms.Panel();
            this.pnlMyDayRemindersUpcomingList1 = new System.Windows.Forms.Panel();
            this.lblMyDayRemindersUpcomingListDate1 = new System.Windows.Forms.Label();
            this.lblMyDayRemindersUpcomingList1 = new System.Windows.Forms.Label();
            this.lblMyDayRemindersUpcoming = new System.Windows.Forms.Label();
            this.lblMyDayRemindersToday = new System.Windows.Forms.Label();
            this.lblMyDayMedication = new System.Windows.Forms.Label();
            this.lblMyDayHead = new System.Windows.Forms.Label();
            this.pnlUserMyDayTakenIndicator = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlMyDayReminders.SuspendLayout();
            this.pnlMyDayRemindersUpcomingList1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserMyDayTaken
            // 
            this.btnUserMyDayTaken.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUserMyDayTaken.ForeColor = System.Drawing.Color.White;
            this.btnUserMyDayTaken.Location = new System.Drawing.Point(763, 68);
            this.btnUserMyDayTaken.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserMyDayTaken.Name = "btnUserMyDayTaken";
            this.btnUserMyDayTaken.Size = new System.Drawing.Size(152, 41);
            this.btnUserMyDayTaken.TabIndex = 19;
            this.btnUserMyDayTaken.Text = "Report Taken";
            this.btnUserMyDayTaken.UseVisualStyleBackColor = false;
            this.btnUserMyDayTaken.Click += new System.EventHandler(this.btnUserMyDayTaken_Click);
            // 
            // btnUserMyDayNotTaken
            // 
            this.btnUserMyDayNotTaken.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUserMyDayNotTaken.ForeColor = System.Drawing.Color.White;
            this.btnUserMyDayNotTaken.Location = new System.Drawing.Point(583, 68);
            this.btnUserMyDayNotTaken.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserMyDayNotTaken.Name = "btnUserMyDayNotTaken";
            this.btnUserMyDayNotTaken.Size = new System.Drawing.Size(152, 41);
            this.btnUserMyDayNotTaken.TabIndex = 18;
            this.btnUserMyDayNotTaken.Text = "Report Not Taken";
            this.btnUserMyDayNotTaken.UseVisualStyleBackColor = false;
            this.btnUserMyDayNotTaken.Click += new System.EventHandler(this.btnUserMyDayNotTaken_Click);
            // 
            // pnlUserMyDayMedications
            // 
            this.pnlUserMyDayMedications.AutoScroll = true;
            this.pnlUserMyDayMedications.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlUserMyDayMedications.ForeColor = System.Drawing.Color.Black;
            this.pnlUserMyDayMedications.Location = new System.Drawing.Point(24, 122);
            this.pnlUserMyDayMedications.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserMyDayMedications.Name = "pnlUserMyDayMedications";
            this.pnlUserMyDayMedications.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlUserMyDayMedications.Size = new System.Drawing.Size(887, 313);
            this.pnlUserMyDayMedications.TabIndex = 17;
            // 
            // lblMyDayReminders
            // 
            this.lblMyDayReminders.AutoSize = true;
            this.lblMyDayReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayReminders.ForeColor = System.Drawing.Color.White;
            this.lblMyDayReminders.Location = new System.Drawing.Point(18, 444);
            this.lblMyDayReminders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDayReminders.Name = "lblMyDayReminders";
            this.lblMyDayReminders.Size = new System.Drawing.Size(175, 33);
            this.lblMyDayReminders.TabIndex = 16;
            this.lblMyDayReminders.Text = "Reminders:";
            // 
            // pnlMyDayReminders
            // 
            this.pnlMyDayReminders.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMyDayReminders.Controls.Add(this.pnlMyDayRemindersUpcomingList1);
            this.pnlMyDayReminders.Controls.Add(this.lblMyDayRemindersUpcoming);
            this.pnlMyDayReminders.Controls.Add(this.lblMyDayRemindersToday);
            this.pnlMyDayReminders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMyDayReminders.Location = new System.Drawing.Point(18, 481);
            this.pnlMyDayReminders.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMyDayReminders.Name = "pnlMyDayReminders";
            this.pnlMyDayReminders.Size = new System.Drawing.Size(892, 162);
            this.pnlMyDayReminders.TabIndex = 15;
            // 
            // pnlMyDayRemindersUpcomingList1
            // 
            this.pnlMyDayRemindersUpcomingList1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMyDayRemindersUpcomingList1.Controls.Add(this.lblMyDayRemindersUpcomingListDate1);
            this.pnlMyDayRemindersUpcomingList1.Controls.Add(this.lblMyDayRemindersUpcomingList1);
            this.pnlMyDayRemindersUpcomingList1.Location = new System.Drawing.Point(15, 100);
            this.pnlMyDayRemindersUpcomingList1.Name = "pnlMyDayRemindersUpcomingList1";
            this.pnlMyDayRemindersUpcomingList1.Size = new System.Drawing.Size(841, 40);
            this.pnlMyDayRemindersUpcomingList1.TabIndex = 2;
            // 
            // lblMyDayRemindersUpcomingListDate1
            // 
            this.lblMyDayRemindersUpcomingListDate1.AutoSize = true;
            this.lblMyDayRemindersUpcomingListDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayRemindersUpcomingListDate1.ForeColor = System.Drawing.Color.White;
            this.lblMyDayRemindersUpcomingListDate1.Location = new System.Drawing.Point(762, 6);
            this.lblMyDayRemindersUpcomingListDate1.Name = "lblMyDayRemindersUpcomingListDate1";
            this.lblMyDayRemindersUpcomingListDate1.Size = new System.Drawing.Size(72, 29);
            this.lblMyDayRemindersUpcomingListDate1.TabIndex = 2;
            this.lblMyDayRemindersUpcomingListDate1.Text = "11/24";
            // 
            // lblMyDayRemindersUpcomingList1
            // 
            this.lblMyDayRemindersUpcomingList1.AutoSize = true;
            this.lblMyDayRemindersUpcomingList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayRemindersUpcomingList1.ForeColor = System.Drawing.Color.White;
            this.lblMyDayRemindersUpcomingList1.Location = new System.Drawing.Point(7, 6);
            this.lblMyDayRemindersUpcomingList1.Name = "lblMyDayRemindersUpcomingList1";
            this.lblMyDayRemindersUpcomingList1.Size = new System.Drawing.Size(243, 29);
            this.lblMyDayRemindersUpcomingList1.TabIndex = 1;
            this.lblMyDayRemindersUpcomingList1.Text = "Doctors Appointment:";
            // 
            // lblMyDayRemindersUpcoming
            // 
            this.lblMyDayRemindersUpcoming.AutoSize = true;
            this.lblMyDayRemindersUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayRemindersUpcoming.ForeColor = System.Drawing.Color.White;
            this.lblMyDayRemindersUpcoming.Location = new System.Drawing.Point(11, 58);
            this.lblMyDayRemindersUpcoming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDayRemindersUpcoming.Name = "lblMyDayRemindersUpcoming";
            this.lblMyDayRemindersUpcoming.Size = new System.Drawing.Size(171, 29);
            this.lblMyDayRemindersUpcoming.TabIndex = 3;
            this.lblMyDayRemindersUpcoming.Text = "  Upcoming      ";
            // 
            // lblMyDayRemindersToday
            // 
            this.lblMyDayRemindersToday.AutoSize = true;
            this.lblMyDayRemindersToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayRemindersToday.ForeColor = System.Drawing.Color.White;
            this.lblMyDayRemindersToday.Location = new System.Drawing.Point(11, 13);
            this.lblMyDayRemindersToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDayRemindersToday.Name = "lblMyDayRemindersToday";
            this.lblMyDayRemindersToday.Size = new System.Drawing.Size(159, 29);
            this.lblMyDayRemindersToday.TabIndex = 0;
            this.lblMyDayRemindersToday.Text = "  Today           ";
            // 
            // lblMyDayMedication
            // 
            this.lblMyDayMedication.AutoSize = true;
            this.lblMyDayMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayMedication.ForeColor = System.Drawing.Color.White;
            this.lblMyDayMedication.Location = new System.Drawing.Point(12, 68);
            this.lblMyDayMedication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDayMedication.Name = "lblMyDayMedication";
            this.lblMyDayMedication.Size = new System.Drawing.Size(329, 37);
            this.lblMyDayMedication.TabIndex = 14;
            this.lblMyDayMedication.Text = "Todays Medications:";
            // 
            // lblMyDayHead
            // 
            this.lblMyDayHead.AutoSize = true;
            this.lblMyDayHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayHead.ForeColor = System.Drawing.Color.White;
            this.lblMyDayHead.Location = new System.Drawing.Point(11, 9);
            this.lblMyDayHead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDayHead.Name = "lblMyDayHead";
            this.lblMyDayHead.Size = new System.Drawing.Size(638, 42);
            this.lblMyDayHead.TabIndex = 13;
            this.lblMyDayHead.Text = "My Day - Saturday October 9, 2021";
            // 
            // pnlUserMyDayTakenIndicator
            // 
            this.pnlUserMyDayTakenIndicator.BackColor = System.Drawing.Color.DarkGray;
            this.pnlUserMyDayTakenIndicator.Location = new System.Drawing.Point(18, 115);
            this.pnlUserMyDayTakenIndicator.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserMyDayTakenIndicator.Name = "pnlUserMyDayTakenIndicator";
            this.pnlUserMyDayTakenIndicator.Size = new System.Drawing.Size(899, 327);
            this.pnlUserMyDayTakenIndicator.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(-4, 580);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1066, 81);
            this.panel5.TabIndex = 21;
            // 
            // myDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(946, 651);
            this.Controls.Add(this.btnUserMyDayTaken);
            this.Controls.Add(this.btnUserMyDayNotTaken);
            this.Controls.Add(this.pnlUserMyDayMedications);
            this.Controls.Add(this.lblMyDayReminders);
            this.Controls.Add(this.pnlMyDayReminders);
            this.Controls.Add(this.lblMyDayMedication);
            this.Controls.Add(this.lblMyDayHead);
            this.Controls.Add(this.pnlUserMyDayTakenIndicator);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myDay";
            this.Text = "myDay";
            this.pnlMyDayReminders.ResumeLayout(false);
            this.pnlMyDayReminders.PerformLayout();
            this.pnlMyDayRemindersUpcomingList1.ResumeLayout(false);
            this.pnlMyDayRemindersUpcomingList1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserMyDayTaken;
        private System.Windows.Forms.Button btnUserMyDayNotTaken;
        private System.Windows.Forms.Label lblMyDayReminders;
        private System.Windows.Forms.Panel pnlMyDayReminders;
        private System.Windows.Forms.Panel pnlMyDayRemindersUpcomingList1;
        private System.Windows.Forms.Label lblMyDayRemindersUpcomingListDate1;
        private System.Windows.Forms.Label lblMyDayRemindersUpcomingList1;
        private System.Windows.Forms.Label lblMyDayRemindersUpcoming;
        private System.Windows.Forms.Label lblMyDayRemindersToday;
        private System.Windows.Forms.Label lblMyDayMedication;
        private System.Windows.Forms.Label lblMyDayHead;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.FlowLayoutPanel pnlUserMyDayMedications;
        public System.Windows.Forms.Panel pnlUserMyDayTakenIndicator;
    }
}