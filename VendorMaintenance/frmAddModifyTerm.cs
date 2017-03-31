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
    public partial class frmAddModifyTerm : Form
    {
        public frmAddModifyTerm()
        {
            InitializeComponent();
        }
        public bool addTerm;
        public Term term;

        //check whether user wants to add or modify
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addTerm)
            {
                term = new Term();
                this.PutTerm(term);
                DataContext.payables.Terms.InsertOnSubmit(term);

                try
                {
                    DataContext.payables.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Terms ID " + Convert.ToString(term.TermsID) + " has been added to the Term table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                //TODO add else
            }
        }

        private void PutTerm(Term term)
        {
            term.TermsID = Int32.Parse(txtTermsID.Text);
            term.DueDays = short.Parse(txtDueDays.Text);
            term.Description = txtDescription.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
