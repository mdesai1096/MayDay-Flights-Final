namespace MaydayBackend
{
    partial class frmBookingMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingMain));
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFRef = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilterT = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDFilter = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.btnSurname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(642, 19);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 39);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Show All Bookings";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(140, 333);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 24);
            this.lblError.TabIndex = 3;
            // 
            // lblFRef
            // 
            this.lblFRef.AutoSize = true;
            this.lblFRef.Location = new System.Drawing.Point(27, 9);
            this.lblFRef.Name = "lblFRef";
            this.lblFRef.Size = new System.Drawing.Size(120, 13);
            this.lblFRef.TabIndex = 4;
            this.lblFRef.Text = "Filter by Ref or Surname";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(30, 29);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 5;
            // 
            // lblFilterT
            // 
            this.lblFilterT.AutoSize = true;
            this.lblFilterT.Location = new System.Drawing.Point(326, 5);
            this.lblFilterT.Name = "lblFilterT";
            this.lblFilterT.Size = new System.Drawing.Size(104, 13);
            this.lblFilterT.TabIndex = 6;
            this.lblFilterT.Text = "Filter by Date Range";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(326, 21);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(27, 13);
            this.lblfrom.TabIndex = 7;
            this.lblfrom.Text = "from";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(330, 34);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 8;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(454, 34);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(436, 37);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "to";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(133, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(73, 21);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter By Ref";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDFilter
            // 
            this.btnDFilter.Location = new System.Drawing.Point(561, 21);
            this.btnDFilter.Name = "btnDFilter";
            this.btnDFilter.Size = new System.Drawing.Size(75, 38);
            this.btnDFilter.TabIndex = 12;
            this.btnDFilter.Text = "Filter by Date";
            this.btnDFilter.UseVisualStyleBackColor = true;
            this.btnDFilter.Click += new System.EventHandler(this.btnDFilter_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Booking";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstBookings
            // 
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.Location = new System.Drawing.Point(7, 70);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(710, 251);
            this.lstBookings.TabIndex = 0;
            // 
            // btnSurname
            // 
            this.btnSurname.Location = new System.Drawing.Point(212, 29);
            this.btnSurname.Name = "btnSurname";
            this.btnSurname.Size = new System.Drawing.Size(97, 21);
            this.btnSurname.TabIndex = 15;
            this.btnSurname.Text = "Filter By Surname";
            this.btnSurname.UseVisualStyleBackColor = true;
            this.btnSurname.Click += new System.EventHandler(this.btnSurname_Click);
            // 
            // frmBookingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 374);
            this.Controls.Add(this.btnSurname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.lblFilterT);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFRef);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.lstBookings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookingMain";
            this.Text = "Display Bookings";
            this.Load += new System.EventHandler(this.frmBookingMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFRef;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilterT;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDFilter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.Button btnSurname;
    }
}