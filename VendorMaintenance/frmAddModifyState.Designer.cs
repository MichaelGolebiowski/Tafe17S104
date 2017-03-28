namespace VendorMaintenance
{
    partial class frmAddModifyState
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
            this.lblStateCode = new System.Windows.Forms.Label();
            this.lblStateName = new System.Windows.Forms.Label();
            this.lblStateZip1 = new System.Windows.Forms.Label();
            this.lblStateZip2 = new System.Windows.Forms.Label();
            this.tbStateName = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbZipCode2 = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbStateCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStateCode
            // 
            this.lblStateCode.AutoSize = true;
            this.lblStateCode.Location = new System.Drawing.Point(11, 23);
            this.lblStateCode.Name = "lblStateCode";
            this.lblStateCode.Size = new System.Drawing.Size(60, 13);
            this.lblStateCode.TabIndex = 0;
            this.lblStateCode.Text = "State Code";
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Location = new System.Drawing.Point(11, 49);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(63, 13);
            this.lblStateName.TabIndex = 1;
            this.lblStateName.Text = "State Name";
            // 
            // lblStateZip1
            // 
            this.lblStateZip1.AutoSize = true;
            this.lblStateZip1.Location = new System.Drawing.Point(11, 75);
            this.lblStateZip1.Name = "lblStateZip1";
            this.lblStateZip1.Size = new System.Drawing.Size(50, 13);
            this.lblStateZip1.TabIndex = 2;
            this.lblStateZip1.Text = "Zip Code";
            // 
            // lblStateZip2
            // 
            this.lblStateZip2.AutoSize = true;
            this.lblStateZip2.Location = new System.Drawing.Point(11, 101);
            this.lblStateZip2.Name = "lblStateZip2";
            this.lblStateZip2.Size = new System.Drawing.Size(59, 13);
            this.lblStateZip2.TabIndex = 3;
            this.lblStateZip2.Text = "Zip Code 2";
            // 
            // tbStateName
            // 
            this.tbStateName.Location = new System.Drawing.Point(83, 42);
            this.tbStateName.Name = "tbStateName";
            this.tbStateName.Size = new System.Drawing.Size(100, 20);
            this.tbStateName.TabIndex = 4;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(83, 68);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(100, 20);
            this.tbZipCode.TabIndex = 5;
            // 
            // tbZipCode2
            // 
            this.tbZipCode2.Location = new System.Drawing.Point(83, 94);
            this.tbZipCode2.Name = "tbZipCode2";
            this.tbZipCode2.Size = new System.Drawing.Size(100, 20);
            this.tbZipCode2.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(14, 144);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbStateCode
            // 
            this.tbStateCode.Location = new System.Drawing.Point(83, 16);
            this.tbStateCode.Name = "tbStateCode";
            this.tbStateCode.Size = new System.Drawing.Size(100, 20);
            this.tbStateCode.TabIndex = 11;
            // 
            // frmAddModifyState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 203);
            this.Controls.Add(this.tbStateCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbZipCode2);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.tbStateName);
            this.Controls.Add(this.lblStateZip2);
            this.Controls.Add(this.lblStateZip1);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.lblStateCode);
            this.Name = "frmAddModifyState";
            this.Text = "Add/Modify State";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStateCode;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Label lblStateZip1;
        private System.Windows.Forms.Label lblStateZip2;
        private System.Windows.Forms.TextBox tbStateName;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbZipCode2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbStateCode;
    }
}