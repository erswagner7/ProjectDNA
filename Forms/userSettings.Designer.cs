
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
            this.pnlUserSettings = new System.Windows.Forms.Panel();
            this.pnlChangeTheme = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblChangeTheme = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pnlUserSettings.SuspendLayout();
            this.pnlChangeTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserSettings
            // 
            this.pnlUserSettings.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlUserSettings.Controls.Add(this.pnlChangeTheme);
            this.pnlUserSettings.Controls.Add(this.lblChangeTheme);
            this.pnlUserSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlUserSettings.Location = new System.Drawing.Point(17, 57);
            this.pnlUserSettings.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserSettings.Name = "pnlUserSettings";
            this.pnlUserSettings.Size = new System.Drawing.Size(772, 383);
            this.pnlUserSettings.TabIndex = 4;
            // 
            // pnlChangeTheme
            // 
            this.pnlChangeTheme.BackColor = System.Drawing.Color.DarkGray;
            this.pnlChangeTheme.Controls.Add(this.btnColor);
            this.pnlChangeTheme.Location = new System.Drawing.Point(15, 49);
            this.pnlChangeTheme.Name = "pnlChangeTheme";
            this.pnlChangeTheme.Size = new System.Drawing.Size(740, 41);
            this.pnlChangeTheme.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(3, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(124, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Change Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblChangeTheme
            // 
            this.lblChangeTheme.AutoSize = true;
            this.lblChangeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTheme.ForeColor = System.Drawing.Color.White;
            this.lblChangeTheme.Location = new System.Drawing.Point(15, 13);
            this.lblChangeTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeTheme.Name = "lblChangeTheme";
            this.lblChangeTheme.Size = new System.Drawing.Size(180, 29);
            this.lblChangeTheme.TabIndex = 0;
            this.lblChangeTheme.Text = "Change Theme";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(11, 10);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(161, 42);
            this.lblSettings.TabIndex = 3;
            this.lblSettings.Text = "Settings";
            // 
            // userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUserSettings);
            this.Controls.Add(this.lblSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userSettings";
            this.Text = "userSettings";
            this.pnlUserSettings.ResumeLayout(false);
            this.pnlUserSettings.PerformLayout();
            this.pnlChangeTheme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserSettings;
        private System.Windows.Forms.Panel pnlChangeTheme;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblChangeTheme;
        private System.Windows.Forms.Label lblSettings;
    }
}