using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class frmGLAccount : Form
    {
        public frmGLAccount()
        {
            InitializeComponent();
        }
        GLAccount selectedGLAccount;

        // Form load 
        private void frmGLAccount_Load(object sender, EventArgs e)
        {
        }

        //clear
        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtAccountNo.Text = "";
            txtDescription.Text = "";
        }

        //add
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Generater a new form instance
            frmAddModifyGLAccount f;
            f = new frmAddModifyGLAccount();

            // assignment the addGLAccount global boolean to be true
            f.addGLAccount = true;

            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedGLAccount = f.glAccount;
                txtAccountNo.Text = selectedGLAccount.AccountNo.ToString();
                this.DisplayGLAccount();
            }
        }

        //modify
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            // Generater a new form instance
            frmAddModifyGLAccount f;
            f = new frmAddModifyGLAccount();

            f.addGLAccount = false;

            f.glAccount = selectedGLAccount;

            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedGLAccount = f.glAccount;
                this.DisplayGLAccount();
            }
            else if (result == DialogResult.Abort)
            {
                txtAccountNo.Text = "";
                this.ClearControls();
            }
        }


        //get GLAccount
        private void getGlAccount_Click(object sender, EventArgs e)
        {
            try
            {
                selectedGLAccount =
                    (from glAccount in DataContext.payables.GLAccounts
                     where glAccount.AccountNo == Convert.ToInt32(txtAccountNo.Text)
                     select glAccount).Single();
                this.DisplayGLAccount();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No GLAccount found with this No. " +
                    "Please try again.", "this GLAccount Not Found");
                this.ClearControls();
                txtAccountNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }





        //clear screen
        private void ClearControls()
        {
            txtAccountNo.Text = "";
            txtDescription.Text = "";
            //cmdModify.Enabled = false;
            //cmdDelete.Enabled = false;
        }

        //display
        private void DisplayGLAccount()
        {
            txtAccountNo.Text = selectedGLAccount.AccountNo.ToString();
            txtDescription.Text = selectedGLAccount.Description;
            //cmdModify.Enabled = true;
            //cmdDelete.Enabled = true;
        }

       
       


    }
}
