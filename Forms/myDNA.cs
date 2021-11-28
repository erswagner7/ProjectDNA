using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDNA.Forms
{
    public partial class myDNA : Form
    {
        readonly myDay mD;
        public myDNA(myDay mDay)
        {
            InitializeComponent();
            mD = mDay;
            //lblMyDNAHead.Text = "My DNA - " + DateTime.Now.ToLongDateString
        }

        public myDNA()
        {
            InitializeComponent();
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

            FlowLayoutPanel newPanel = new FlowLayoutPanel();
            newPanel.Height = 147;
            newPanel.Width = (pnlUserMyConnections.Width - 40);
            newPanel.AutoScroll = true;
            newPanel.FlowDirection = FlowDirection.TopDown;
            newPanel.BackColor = Color.DarkGray;
            pnlUserMyConnections.Controls.Add(newPanel);

            Label lblUserNewConnectionName = new Label();
            lblUserNewConnectionName.Text = "Name: " + txtUserCreateNewConnectionFirstname.Text + " " + txtUserCreateNewConnectionLastname.Text;
            lblUserNewConnectionName.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserNewConnectionName.Margin = new Padding(7);
            lblUserNewConnectionName.ForeColor = Color.White;
            lblUserNewConnectionName.AutoSize = true;
            newPanel.Controls.Add(lblUserNewConnectionName);

            Label lblUserNewConnectionAge = new Label();
            lblUserNewConnectionAge.Text = "Age: " + Convert.ToInt32(txtUserCreateNewConnectionAge.Text);
            lblUserNewConnectionAge.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserNewConnectionAge.Margin = new Padding(7);
            lblUserNewConnectionAge.ForeColor = Color.White;
            lblUserNewConnectionAge.AutoSize = true;
            newPanel.Controls.Add(lblUserNewConnectionAge);

            Label lblUserNewConnectionAddress = new Label();
            lblUserNewConnectionAddress.Text = "Address: " + txtUserCreateNewConnectionAddress.Text;
            lblUserNewConnectionAddress.Font = new Font(FontFamily.GenericSansSerif, 16);
            lblUserNewConnectionAddress.Margin = new Padding(7);
            lblUserNewConnectionAddress.ForeColor = Color.White;
            lblUserNewConnectionAddress.AutoSize = true;
            newPanel.Controls.Add(lblUserNewConnectionAddress);

            cmbSelectConnection.Items.Add(txtUserCreateNewConnectionFirstname.Text + " " + txtUserCreateNewConnectionLastname.Text);

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

        private void btnUserAddMedication_Click(object sender, EventArgs e)
        {
            Panel pnlUserMyDayNewMedication = new Panel();
            pnlUserMyDayNewMedication.Height = 40;
            pnlUserMyDayNewMedication.Width = (mD.pnlUserMyDayMedications.Width - 40);
            pnlUserMyDayNewMedication.Margin = new Padding(7);
            pnlUserMyDayNewMedication.BackColor = Color.DarkGray;
            mD.pnlUserMyDayMedications.Controls.Add(pnlUserMyDayNewMedication);

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

            mD.pnlUserMyDayTakenIndicator.BackColor = Color.Yellow;

            txtUserEnterMedicationName.Text = "";
        }
    }
}
