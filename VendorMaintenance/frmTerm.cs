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
    public partial class frmTerm : Form
    {
        public frmTerm()
        {
            InitializeComponent();
        }

        Term selectedTerm;

        //load form
        private void frmTerm_Load(object sender, EventArgs e)
        {
        }

        //clear data
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTermsID.Text = "";
            txtDescription.Text = "";
        }

        //add data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //generate new form
            frmAddModifyTerm f;
            f = new frmAddModifyTerm();

            f.addTerm = true;

            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedTerm = f.term;
                txtTermsID.Text = selectedTerm.TermsID.ToString();
                this.DisplayTerm();
            }
        }

        //modify data
        private void btnModify_Click(object sender, EventArgs e)
        {
            //generate new form
            frmAddModifyTerm f;
            f = new frmAddModifyTerm();

            f.addTerm = false;

            f.term = selectedTerm;

            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedTerm = f.term;
                this.DisplayTerm();
            }
            else
            {
                txtTermsID.Text = "";
                this.ClearControls();
            }
        }

        //get term from database
        private void btnGetTerm_Click(object sender, EventArgs e)
        {
            try
            {
                selectedTerm =
                    (from term in DataContext.payables.Terms
                     where term.TermsID == Convert.ToInt32(txtTermsID.Text)
                     select term).Single();
                this.DisplayTerm();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No term found with this ID " + "Please try again.", "This Term Not Found");
                this.ClearControls();
                txtTermsID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //display term method
        private void DisplayTerm()
        {
            txtTermsID.Text = selectedTerm.TermsID.ToString();
            txtDueDays.Text = selectedTerm.DueDays.ToString();
            txtDescription.Text = selectedTerm.Description;
            btnModify.Enabled = true;
            //btnDelete.Enabled = true
        }

        //clear screen control method
        private void ClearControls()
        {
            txtTermsID.Text = "";
            txtDueDays.Text = "";
            txtDescription.Text = "";
            btnModify.Enabled = false;
            //btnDelete.Enabled = false
        }
    }
}
