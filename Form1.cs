﻿using System;
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

            lblUserWelcome.Text = "Welcome User, today is " + DateTime.Now.ToLongDateString();
            lblMyDayHead.Text = "My Day - " + DateTime.Now.ToLongDateString();
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
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblUserClock_Click(object sender, EventArgs e)
        {

        }

        private void BtnTaken1_Click(object sender, EventArgs e)
        {
            pnlMedicationStatus1.BackColor = Color.Green;
            lblMyDayMedicationTodayList1.ForeColor = Color.Green;
            btnNotTaken1.Hide();
            btnTaken1.Hide();

        }

        private void BtnTaken2_Click(object sender, EventArgs e)
        {
            pnlMedicationStatus2.BackColor = Color.Green;
            lblMyDayMedicationTodayList2.ForeColor = Color.Green;
            btnNotTaken2.Hide();
            btnTaken2.Hide();
        }

        private void pnlUserMyDay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChatsView_Click(object sender, EventArgs e)
        {
            pnlUserMyDay.Hide();

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
            pnlUserMyDay.Hide();

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
            pnlUserMyDay.Hide();

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
            pnlUserMyDay.Show();

            btnMyDay.ForeColor = Color.White;
            btnMyDay.BackColor = Color.MidnightBlue;

            btnChatsView.ForeColor = Color.Black;
            btnChatsView.BackColor = Color.BlueViolet;

            btnMyDNA.ForeColor = Color.Black;
            btnMyDNA.BackColor = Color.BlueViolet;

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.BlueViolet;
        }
    }
}
