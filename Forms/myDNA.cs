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
        public myDNA()
        {
            InitializeComponent();
            lblMyDNAHead.Text = "My DNA - " + DateTime.Now.ToLongDateString();


            /*
             
       
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

             * */


        }
    }
}
