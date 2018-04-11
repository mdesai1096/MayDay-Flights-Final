namespace MaydayBackend
{
    partial class frmCustomerMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstCust = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFilterbyPostcode = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFilterbySurname = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(329, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Display Customers";
            // 
            // lstCust
            // 
            this.lstCust.FormattingEnabled = true;
            this.lstCust.Location = new System.Drawing.Point(33, 75);
            this.lstCust.Name = "lstCust";
            this.lstCust.Size = new System.Drawing.Size(666, 173);
            this.lstCust.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(33, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 43);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(544, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilterbyPostcode
            // 
            this.btnFilterbyPostcode.Location = new System.Drawing.Point(203, 36);
            this.btnFilterbyPostcode.Name = "btnFilterbyPostcode";
            this.btnFilterbyPostcode.Size = new System.Drawing.Size(134, 33);
            this.btnFilterbyPostcode.TabIndex = 5;
            this.btnFilterbyPostcode.Text = "Filter by PostCode";
            this.btnFilterbyPostcode.UseVisualStyleBackColor = true;
            this.btnFilterbyPostcode.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(33, 43);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(383, 284);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "lblError";
            // 
            // btnFilterbySurname
            // 
            this.btnFilterbySurname.Location = new System.Drawing.Point(343, 36);
            this.btnFilterbySurname.Name = "btnFilterbySurname";
            this.btnFilterbySurname.Size = new System.Drawing.Size(135, 33);
            this.btnFilterbySurname.TabIndex = 8;
            this.btnFilterbySurname.Text = "Filter by Surname";
            this.btnFilterbySurname.UseVisualStyleBackColor = true;
            this.btnFilterbySurname.Click += new System.EventHandler(this.btnFilterbySurname_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(600, 39);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayAll.TabIndex = 9;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // frmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 372);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnFilterbySurname);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilterbyPostcode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCust);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCustomerMain";
            this.Text = "frmCustomerMain";
            this.Load += new System.EventHandler(this.frmCustomerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstCust;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFilterbyPostcode;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFilterbySurname;
        private System.Windows.Forms.Button btnDisplayAll;
    }
}