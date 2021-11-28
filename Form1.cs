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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 
         * private void BtnTaken1_Click(object sender, EventArgs e)
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

        

        
    }
         */
    }
}
