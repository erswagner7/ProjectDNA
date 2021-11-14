
namespace PrototypeDNA.Forms
{
    partial class userSettings
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
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pnlMyDayMedications = new System.Windows.Forms.Panel();
            this.pnlMyDayMedicationTodayList1 = new System.Windows.Forms.Panel();
            this.lblMyDayMedicationToday = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            this.pnlMyDayMedications.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.AutoScroll = true;
            this.pnlSettings.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlSettings.Controls.Add(this.pnlMyDayMedications);
            this.pnlSettings.Controls.Add(this.lblSettings);
            this.pnlSettings.Controls.Add(this.btnColor);
            this.pnlSettings.Location = new System.Drawing.Point(-75, -8);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(951, 467);
            this.pnlSettings.TabIndex = 8;
            this.pnlSettings.Visible = false;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(313, 36);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(124, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Change Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(86, 17);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(161, 42);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            // 
            // pnlMyDayMedications
            // 
            this.pnlMyDayMedications.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMyDayMedications.Controls.Add(this.pnlMyDayMedicationTodayList1);
            this.pnlMyDayMedications.Controls.Add(this.lblMyDayMedicationToday);
            this.pnlMyDayMedications.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMyDayMedications.Location = new System.Drawing.Point(92, 64);
            this.pnlMyDayMedications.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMyDayMedications.Name = "pnlMyDayMedications";
            this.pnlMyDayMedications.Size = new System.Drawing.Size(772, 383);
            this.pnlMyDayMedications.TabIndex = 2;
            // 
            // pnlMyDayMedicationTodayList1
            // 
            this.pnlMyDayMedicationTodayList1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMyDayMedicationTodayList1.Location = new System.Drawing.Point(15, 49);
            this.pnlMyDayMedicationTodayList1.Name = "pnlMyDayMedicationTodayList1";
            this.pnlMyDayMedicationTodayList1.Size = new System.Drawing.Size(740, 41);
            this.pnlMyDayMedicationTodayList1.TabIndex = 1;
            // 
            // lblMyDayMedicationToday
            // 
            this.lblMyDayMedicationToday.AutoSize = true;
            this.lblMyDayMedicationToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDayMedicationToday.ForeColor = System.Drawing.Color.White;
            this.lblMyDayMedicationToday.Location = new System.Drawing.Point(15, 13);
            this.lblMyDayMedicationToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDayMedicationToday.Name = "lblMyDayMedicationToday";
            this.lblMyDayMedicationToday.Size = new System.Drawing.Size(159, 29);
            this.lblMyDayMedicationToday.TabIndex = 0;
            this.lblMyDayMedicationToday.Text = "  Today           ";
            // 
            // userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userSettings";
            this.Text = "userSettings";
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlMyDayMedications.ResumeLayout(false);
            this.pnlMyDayMedications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Panel pnlMyDayMedications;
        private System.Windows.Forms.Panel pnlMyDayMedicationTodayList1;
        private System.Windows.Forms.Label lblMyDayMedicationToday;
    }
}