using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class frmAddModifyState : Form
    {
        public frmAddModifyState()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Accept changes/Add record
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Remove state data
        }
    }
}
