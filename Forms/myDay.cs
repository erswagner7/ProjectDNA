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
    public partial class myDay : Form
    {
        public myDay()
        {
            InitializeComponent();

            lblMyDayHead.Text = "My Day - " + DateTime.Now.ToLongDateString();
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
