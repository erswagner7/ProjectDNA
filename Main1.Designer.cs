namespace PrototypeDNA
{
    partial class frmWelcomeUser
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
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMyDay = new System.Windows.Forms.Button();
            this.btnChatsView = new System.Windows.Forms.Button();
            this.btnMyDNA = new System.Windows.Forms.Button();
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.lblUserClock = new System.Windows.Forms.Label();
            this.pnlUserWelcome = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            this.pnlUserWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNavigation.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlNavigation.Controls.Add(this.btnSettings);
            this.pnlNavigation.Controls.Add(this.btnMyDay);
            this.pnlNavigation.Controls.Add(this.btnChatsView);
            this.pnlNavigation.Controls.Add(this.btnMyDNA);
            this.pnlNavigation.Location = new System.Drawing.Point(0, 142);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 467);
            this.pnlNavigation.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(0, 292);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 98);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMyDay
            // 
            this.btnMyDay.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMyDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDay.ForeColor = System.Drawing.Color.White;
            this.btnMyDay.Location = new System.Drawing.Point(0, 0);
            this.btnMyDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyDay.Name = "btnMyDay";
            this.btnMyDay.Size = new System.Drawing.Size(200, 98);
            this.btnMyDay.TabIndex = 0;
            this.btnMyDay.Text = "My Day";
            this.btnMyDay.UseVisualStyleBackColor = false;
            this.btnMyDay.Click += new System.EventHandler(this.btnMyDay_Click);
            // 
            // btnChatsView
            // 
            this.btnChatsView.BackColor = System.Drawing.Color.BlueViolet;
            this.btnChatsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatsView.Location = new System.Drawing.Point(0, 98);
            this.btnChatsView.Margin = new System.Windows.Forms.Padding(2);
            this.btnChatsView.Name = "btnChatsView";
            this.btnChatsView.Size = new System.Drawing.Size(200, 98);
            this.btnChatsView.TabIndex = 3;
            this.btnChatsView.Text = "Chats View";
            this.btnChatsView.UseVisualStyleBackColor = false;
            this.btnChatsView.Click += new System.EventHandler(this.btnChatsView_Click);
            // 
            // btnMyDNA
            // 
            this.btnMyDNA.BackColor = System.Drawing.Color.BlueViolet;
            this.btnMyDNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDNA.Location = new System.Drawing.Point(0, 195);
            this.btnMyDNA.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyDNA.Name = "btnMyDNA";
            this.btnMyDNA.Size = new System.Drawing.Size(200, 98);
            this.btnMyDNA.TabIndex = 2;
            this.btnMyDNA.Text = "My DNA";
            this.btnMyDNA.UseVisualStyleBackColor = false;
            this.btnMyDNA.Click += new System.EventHandler(this.btnMyDNA_Click);
            // 
            // lblUserWelcome
            // 
            this.lblUserWelcome.AutoSize = true;
            this.lblUserWelcome.BackColor = System.Drawing.Color.BlueViolet;
            this.lblUserWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWelcome.ForeColor = System.Drawing.Color.White;
            this.lblUserWelcome.Location = new System.Drawing.Point(12, 8);
            this.lblUserWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(1094, 55);
            this.lblUserWelcome.TabIndex = 2;
            this.lblUserWelcome.Text = "Welcome User, today is Saturday October 9, 2021";
            // 
            // lblUserClock
            // 
            this.lblUserClock.AutoSize = true;
            this.lblUserClock.BackColor = System.Drawing.Color.BlueViolet;
            this.lblUserClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserClock.ForeColor = System.Drawing.Color.White;
            this.lblUserClock.Location = new System.Drawing.Point(529, 89);
            this.lblUserClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserClock.Name = "lblUserClock";
            this.lblUserClock.Size = new System.Drawing.Size(126, 31);
            this.lblUserClock.TabIndex = 3;
            this.lblUserClock.Text = "00:00 am";
            // 
            // pnlUserWelcome
            // 
            this.pnlUserWelcome.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlUserWelcome.Controls.Add(this.lblUserWelcome);
            this.pnlUserWelcome.Controls.Add(this.lblUserClock);
            this.pnlUserWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlUserWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserWelcome.Name = "pnlUserWelcome";
            this.pnlUserWelcome.Size = new System.Drawing.Size(1186, 138);
            this.pnlUserWelcome.TabIndex = 4;
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContainer.Location = new System.Drawing.Point(205, 143);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(981, 466);
            this.pContainer.TabIndex = 5;
            // 
            // frmWelcomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 612);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pnlUserWelcome);
            this.Controls.Add(this.pnlNavigation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWelcomeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNA User Portal";
            this.pnlNavigation.ResumeLayout(false);
            this.pnlUserWelcome.ResumeLayout(false);
            this.pnlUserWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnMyDay;
        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.Label lblUserClock;
        private System.Windows.Forms.Panel pnlUserWelcome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnChatsView;
        private System.Windows.Forms.Button btnMyDNA;
        private System.Windows.Forms.Panel pContainer;
    }
}

