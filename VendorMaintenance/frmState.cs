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
    public partial class frmState : Form
    {
        public frmState()
        {
            InitializeComponent();
        }
        State selectedState;

        // Close
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add state
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyState frm = new frmAddModifyState();
            frm.Show();

            frm.addState = true;

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedState = frm.state;
                tbCode.Text = selectedState.StateCode.ToString();
                this.DisplayState();
            }
        }

        // Modify State
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyState frm = new frmAddModifyState();
            frm.Show();

            frm.addState = false;
            frm.state = selectedState;

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedState = frm.state;
                this.DisplayState();
            }
            else if (result == DialogResult.Abort)
            {
                tbCode.Text = "";
                this.ClearControls();
            }
        }

        // Display method
        private void DisplayState()
        {
            tbCode.Text = selectedState.StateCode.ToString();
            tbName.Text = selectedState.StateName.ToString();
            tbZip1.Text = selectedState.FirstZipCode.ToString();
            tbZip2.Text = selectedState.LastZipCode.ToString();
        }


        // Clear fields
        private void ClearControls()
        {
            tbCode.Text = "";
            tbName.Text = "";
            tbZip1.Text = "";
            tbZip2.Text = "";
        }

        // Fetch data from DB
        private void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                selectedState =
                    (from state in DataContext.payables.States
                     where state.StateCode == tbCode.Text
                     select state).Single();
                this.DisplayState();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No state found with this Code: " +
                    "Please try again.", "this. State Not Found");
                this.ClearControls();
                tbCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
