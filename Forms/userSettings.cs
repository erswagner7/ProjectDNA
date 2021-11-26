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
    public partial class userSettings : Form
    {
        public frmWelcomeUser main1 { get; set; }

        public userSettings()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
                main1.ActiveControl.Controls["pContainer"].BackColor = dlg.Color;
            }
        }
    }
}
