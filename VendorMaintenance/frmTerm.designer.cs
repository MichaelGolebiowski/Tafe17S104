namespace VendorMaintenance
{
    partial class frmTerm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModify = new System.Windows.Forms.Button();
            this.btnGetTerm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTermsID = new System.Windows.Forms.Label();
            this.txtTermsID = new System.Windows.Forms.TextBox();
            this.txtDueDays = new System.Windows.Forms.TextBox();
            this.lblDueDays = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(195, 260);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(115, 38);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnGetTerm
            // 
            this.btnGetTerm.Location = new System.Drawing.Point(341, 74);
            this.btnGetTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetTerm.Name = "btnGetTerm";
            this.btnGetTerm.Size = new System.Drawing.Size(121, 37);
            this.btnGetTerm.TabIndex = 9;
            this.btnGetTerm.Text = "Get Term";
            this.btnGetTerm.UseVisualStyleBackColor = true;
            this.btnGetTerm.Click += new System.EventHandler(this.btnGetTerm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(451, 260);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 260);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 196);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(261, 22);
            this.txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(55, 199);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblTermsID
            // 
            this.lblTermsID.AutoSize = true;
            this.lblTermsID.Location = new System.Drawing.Point(55, 85);
            this.lblTermsID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermsID.Name = "lblTermsID";
            this.lblTermsID.Size = new System.Drawing.Size(61, 17);
            this.lblTermsID.TabIndex = 1;
            this.lblTermsID.Text = "TermsID";
            // 
            // txtTermsID
            // 
            this.txtTermsID.Location = new System.Drawing.Point(143, 81);
            this.txtTermsID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTermsID.Name = "txtTermsID";
            this.txtTermsID.Size = new System.Drawing.Size(132, 22);
            this.txtTermsID.TabIndex = 8;
            // 
            // txtDueDays
            // 
            this.txtDueDays.Location = new System.Drawing.Point(143, 142);
            this.txtDueDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDueDays.Name = "txtDueDays";
            this.txtDueDays.Size = new System.Drawing.Size(132, 22);
            this.txtDueDays.TabIndex = 10;
            // 
            // lblDueDays
            // 
            this.lblDueDays.AutoSize = true;
            this.lblDueDays.Location = new System.Drawing.Point(55, 145);
            this.lblDueDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDays.Name = "lblDueDays";
            this.lblDueDays.Size = new System.Drawing.Size(70, 17);
            this.lblDueDays.TabIndex = 2;
            this.lblDueDays.Text = "Due Days";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(451, 331);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 38);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDueDays);
            this.Controls.Add(this.lblDueDays);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnGetTerm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTermsID);
            this.Controls.Add(this.txtTermsID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTerm";
            this.Text = "frmTerm";
            this.Load += new System.EventHandler(this.frmTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnGetTerm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTermsID;
        private System.Windows.Forms.TextBox txtTermsID;
        private System.Windows.Forms.TextBox txtDueDays;
        private System.Windows.Forms.Label lblDueDays;
        private System.Windows.Forms.Button btnExit;
    }
}