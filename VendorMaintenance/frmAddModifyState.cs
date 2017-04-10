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
        public bool addState;
        public State state;

        //Close window
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }

        //Accept changes
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addState)
            {
                state = new State();
                this.PutStateData(state);
                DataContext.payables.States.InsertOnSubmit(state);

                try
                {
                    DataContext.payables.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Account code " + Convert.ToString(state) + " has been added to the state table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                this.PutStateData(state);
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
        

        //Functions
        private void PutStateData(State state)
        {
            state.StateCode = tbStateCode.Text;
            state.StateName = tbStateName.Text;
            state.FirstZipCode = Int32.Parse(tbZipCode.Text);
            state.LastZipCode = Int32.Parse(tbZipCode2.Text);
        }

        private void frmAddModifyState_Load(object sender, EventArgs e)
        {
            if(addState != true)
            {
                this.DisplayStateData();
            }
        }

        private void DisplayStateData()
        {
            tbStateCode.Text = state.StateCode.ToString();
            tbStateName.Text = state.StateName.ToString();
            tbZipCode.Text = state.FirstZipCode.ToString();
            tbZipCode2.Text = state.LastZipCode.ToString();
        }
    }
}
