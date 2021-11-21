using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDNA
{
    public partial class frmWelcomeUser : Form
    {
        public frmWelcomeUser()
        {
            InitializeComponent();

            StartTimer();

            Forms.myDay myDay = new Forms.myDay() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(myDay);
            myDay.Show();

            lblUserWelcome.Text = "Welcome User, today is " + DateTime.Now.ToLongDateString();
        }
        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            lblUserClock.Text = DateTime.Now.ToLongTimeString();
        }
      
        private void btnChatsView_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();

            btnMyDay.ForeColor = Color.Black;
            btnMyDay.BackColor = Color.BlueViolet;

            btnChatsView.ForeColor = Color.White;
            btnChatsView.BackColor = Color.MidnightBlue;

            btnMyDNA.ForeColor = Color.Black;
            btnMyDNA.BackColor = Color.BlueViolet;

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.BlueViolet;
        }

        private void btnMyDNA_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();
            Forms.myDNA myDNA = new Forms.myDNA() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(myDNA);
            myDNA.Show();

            btnMyDay.ForeColor = Color.Black;
            btnMyDay.BackColor = Color.BlueViolet;

            btnChatsView.ForeColor = Color.Black;
            btnChatsView.BackColor = Color.BlueViolet;

            btnMyDNA.ForeColor = Color.White;
            btnMyDNA.BackColor = Color.MidnightBlue;

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.BlueViolet;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();
            Forms.userSettings userSettings = new Forms.userSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(userSettings);
            userSettings.Show();

            btnMyDay.ForeColor = Color.Black;
            btnMyDay.BackColor = Color.BlueViolet;

            btnChatsView.ForeColor = Color.Black;
            btnChatsView.BackColor = Color.BlueViolet;

            btnMyDNA.ForeColor = Color.Black;
            btnMyDNA.BackColor = Color.BlueViolet;

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.MidnightBlue;
        }

        private void btnMyDay_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();
            Forms.myDay myDay = new Forms.myDay() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(myDay);
            myDay.Show();

            btnMyDay.ForeColor = Color.White;
            btnMyDay.BackColor = Color.MidnightBlue;

            btnChatsView.ForeColor = Color.Black;
            btnChatsView.BackColor = Color.BlueViolet;

            btnMyDNA.ForeColor = Color.Black;
            btnMyDNA.BackColor = Color.BlueViolet;

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.BlueViolet;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnSettings.ForeColor = dlg.Color;
            }
        }
    }
}
