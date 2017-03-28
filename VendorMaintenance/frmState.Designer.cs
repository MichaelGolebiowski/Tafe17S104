namespace VendorMaintenance
{
    partial class frmState
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
            this.lblCode = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbZip1 = new System.Windows.Forms.TextBox();
            this.tbZip2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblZip1 = new System.Windows.Forms.Label();
            this.lblzip2 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "State Code";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(82, 12);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(82, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbZip1
            // 
            this.tbZip1.Location = new System.Drawing.Point(82, 67);
            this.tbZip1.Name = "tbZip1";
            this.tbZip1.Size = new System.Drawing.Size(100, 20);
            this.tbZip1.TabIndex = 3;
            // 
            // tbZip2
            // 
            this.tbZip2.Location = new System.Drawing.Point(82, 94);
            this.tbZip2.Name = "tbZip2";
            this.tbZip2.Size = new System.Drawing.Size(100, 20);
            this.tbZip2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(107, 131);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "State Name";
            // 
            // lblZip1
            // 
            this.lblZip1.AutoSize = true;
            this.lblZip1.Location = new System.Drawing.Point(13, 74);
            this.lblZip1.Name = "lblZip1";
            this.lblZip1.Size = new System.Drawing.Size(44, 13);
            this.lblZip1.TabIndex = 9;
            this.lblZip1.Text = "First Zip";
            // 
            // lblzip2
            // 
            this.lblzip2.AutoSize = true;
            this.lblzip2.Location = new System.Drawing.Point(13, 101);
            this.lblzip2.Name = "lblzip2";
            this.lblzip2.Size = new System.Drawing.Size(45, 13);
            this.lblzip2.TabIndex = 10;
            this.lblzip2.Text = "Last Zip";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(189, 9);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 11;
            this.btnFetch.Text = "Fetch State";
            this.btnFetch.UseVisualStyleBackColor = true;
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 197);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lblzip2);
            this.Controls.Add(this.lblZip1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbZip2);
            this.Controls.Add(this.tbZip1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lblCode);
            this.Name = "frmState";
            this.Text = "frmState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbZip1;
        private System.Windows.Forms.TextBox tbZip2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblZip1;
        private System.Windows.Forms.Label lblzip2;
        private System.Windows.Forms.Button btnFetch;
    }
}