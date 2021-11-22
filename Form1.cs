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

            pnlUserMyDNA.Hide();
            pnlUserCreateNewConnection.Hide();


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


        }

        private void BtnTaken2_Click(object sender, EventArgs e)
        {

        }

        private void pnlUserMyDay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChatsView_Click(object sender, EventArgs e)
        {
            pnlUserMyDay.Hide();
            pnlUserMyDNA.Hide();

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
            pnlUserMyDNA.Show();

            //fix for spacing styling
            pnlUserMyConnections.Hide();
            pnlUserCreateNewConnection.Show();
            pnlUserMyConnections.Show();
            pnlUserCreateNewConnection.Hide();

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
            pnlUserMyDNA.Hide();

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
            pnlUserMyDNA.Hide();

            btnMyDay.ForeColor = Color.White;
            btnMyDay.BackColor = Color.MidnightBlue;

            btnChatsView.ForeColor = Color.Black;
            btnChatsView.BackColor = Color.BlueViolet;

            btnMyDNA.ForeColor = Color.Black;
            btnMyDNA.BackColor = Color.BlueViolet;

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.BlueViolet;
        }

        private void btnUserNewConnection_Click(object sender, EventArgs e)
        {
            pnlUserMyConnections.Hide();
            pnlUserCreateNewConnection.Show();
        }

        private void btnUserCreateNewConnectionAddNewConnection_Click(object sender, EventArgs e)
        {
            pnlUserMyConnections.Show();
            pnlUserCreateNewConnection.Hide();
            String newPatientName = txtUserCreateNewConnectionUsername.Text;
            Patient patient = new Patient(txtUserCreateNewConnectionUsername.Text, txtUserCreateNewConnectionFirstname.Text, txtUserCreateNewConnectionLastname.Text, Convert.ToInt32(txtUserCreateNewConnectionAge.Text), txtUserCreateNewConnectionAddress.Text);

            FlowLayoutPanel pnlUserNewConnections = new FlowLayoutPanel();
            pnlUserNewConnections.Height = 147;
            pnlUserNewConnections.Width = (pnlUserMyConnections.Width - 40);
            pnlUserNewConnections.AutoScroll = true;
            pnlUserNewConnections.FlowDirection = FlowDirection.TopDown;
            pnlUserNewConnections.BackColor = Color.DarkGray;
            pnlUserMyConnections.Controls.Add(pnlUserNewConnections);

            Label lblUserNewConnectionName = new Label();
            lblUserNewConnectionName.Text = "Name: " + txtUserCreateNewConnectionFirstname.Text + " " + txtUserCreateNewConnectionLastname.Text;
            lblUserNewConnectionName.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserNewConnectionName.Margin = new Padding(7);
            lblUserNewConnectionName.ForeColor = Color.White;
            lblUserNewConnectionName.AutoSize = true;
            pnlUserNewConnections.Controls.Add(lblUserNewConnectionName);

            Label lblUserNewConnectionAge = new Label();
            lblUserNewConnectionAge.Text = "Age: " + Convert.ToInt32(txtUserCreateNewConnectionAge.Text);
            lblUserNewConnectionAge.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserNewConnectionAge.Margin = new Padding(7);
            lblUserNewConnectionAge.ForeColor = Color.White;
            lblUserNewConnectionAge.AutoSize = true;
            pnlUserNewConnections.Controls.Add(lblUserNewConnectionAge);
            
            Label lblUserNewConnectionAddress = new Label();
            lblUserNewConnectionAddress.Text = "Address: " + txtUserCreateNewConnectionAddress.Text;
            lblUserNewConnectionAddress.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserNewConnectionAddress.Margin = new Padding(7);
            lblUserNewConnectionAddress.ForeColor = Color.White;
            lblUserNewConnectionAddress.AutoSize = true;
            pnlUserNewConnections.Controls.Add(lblUserNewConnectionAddress);

            cbUserSelectConnection.Items.Add(txtUserCreateNewConnectionFirstname.Text + " " + txtUserCreateNewConnectionLastname.Text);



            txtUserCreateNewConnectionUsername.Text = "";
            txtUserCreateNewConnectionFirstname.Text = "";
            txtUserCreateNewConnectionLastname.Text = "";
            txtUserCreateNewConnectionAge.Text = "";
            txtUserCreateNewConnectionAddress.Text = "";
        }


        private void btnUserCreateNewConnectionCancel_Click(object sender, EventArgs e)
        {
            pnlUserMyConnections.Show();
            pnlUserCreateNewConnection.Hide();

            txtUserCreateNewConnectionUsername.Text = "";
            txtUserCreateNewConnectionFirstname.Text = "";
            txtUserCreateNewConnectionLastname.Text = "";
            txtUserCreateNewConnectionAge.Text = "";
            txtUserCreateNewConnectionAddress.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnUserAddMedication_Click(object sender, EventArgs e)
        {
            Panel pnlUserMyDayNewMedication = new Panel();
            pnlUserMyDayNewMedication.Height = 40;
            pnlUserMyDayNewMedication.Width = (pnlUserMyDayMedications.Width - 40);
            pnlUserMyDayNewMedication.Margin = new Padding(7);
            pnlUserMyDayNewMedication.BackColor = Color.DarkGray;
            pnlUserMyDayMedications.Controls.Add(pnlUserMyDayNewMedication);

            Label lblUserMyDayNewMedicationName = new Label();
            lblUserMyDayNewMedicationName.Text = "Medication: " + txtUserEnterMedicationName.Text;
            lblUserMyDayNewMedicationName.Location = new Point(5, 5);
            lblUserMyDayNewMedicationName.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserMyDayNewMedicationName.Margin = new Padding(7);
            lblUserMyDayNewMedicationName.ForeColor = Color.White;
            lblUserMyDayNewMedicationName.AutoSize = true;
            pnlUserMyDayNewMedication.Controls.Add(lblUserMyDayNewMedicationName);

            Label pnlUserMyDayNewMedicationDate = new Label();
            pnlUserMyDayNewMedicationDate.Text = "Date: Today";
            pnlUserMyDayNewMedicationDate.Location = new Point(pnlUserMyDayNewMedication.Width - 250, 5);
            pnlUserMyDayNewMedicationDate.Font = new Font(FontFamily.GenericSansSerif, 16);
            pnlUserMyDayNewMedicationDate.Margin = new Padding(7);
            pnlUserMyDayNewMedicationDate.ForeColor = Color.White;
            pnlUserMyDayNewMedicationDate.AutoSize = true;
            pnlUserMyDayNewMedication.Controls.Add(pnlUserMyDayNewMedicationDate);

            pnlUserMyDayTakenIndicator.BackColor = Color.Yellow;

            txtUserEnterMedicationName.Text = "";
        }

        private void btnUserMyDayTaken_Click(object sender, EventArgs e)
        {
            pnlUserMyDayTakenIndicator.BackColor = Color.LightGreen;
        }

        private void btnUserMyDayNotTaken_Click(object sender, EventArgs e)
        {
            pnlUserMyDayTakenIndicator.BackColor = Color.Crimson;
        }
    }
}
