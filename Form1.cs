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
    }
}
