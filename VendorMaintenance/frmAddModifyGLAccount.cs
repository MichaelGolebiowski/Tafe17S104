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
    public partial class frmAddModifyGLAccount : Form
    {
        public frmAddModifyGLAccount()
        {
            InitializeComponent();
        }

        public bool addGLAccount;

        public GLAccount glAccount;


        //chrck
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (addGLAccount)
            {
                glAccount = new GLAccount();
                this.PutGLAccountData(glAccount);
                DataContext.payables.GLAccounts.InsertOnSubmit(glAccount);

                try
                {
                    DataContext.payables.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Account code " + Convert.ToString(glAccount.AccountNo) + " has been added to the GLAccount table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
            else
            {
                this.PutGLAccountData(glAccount);
                try
                {
                    DataContext.payables.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        //assign properties
        private void PutGLAccountData(GLAccount glAccount)
        {
            glAccount.AccountNo = Int32.Parse(txtAccountNo.Text);
            glAccount.Description = txtDescription.Text;
        }

//   
        private void frmAddModifyGLAccount_Load(object sender, EventArgs e)
        {
           
            if (addGLAccount != true)
            {
                this.DisplayGLAccountData();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DisplayGLAccountData()
        {
            txtAccountNo.Text = glAccount.AccountNo.ToString();
            txtDescription.Text = glAccount.Description;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }

    }

