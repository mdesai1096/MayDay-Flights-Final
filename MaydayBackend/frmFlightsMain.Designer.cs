namespace MaydayBackend
{
    partial class frmFlightsMain
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
            this.lblFRef = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lstFlights = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFRef
            // 
            this.lblFRef.AutoSize = true;
            this.lblFRef.Location = new System.Drawing.Point(12, 9);
            this.lblFRef.Name = "lblFRef";
            this.lblFRef.Size = new System.Drawing.Size(99, 13);
            this.lblFRef.TabIndex = 5;
            this.lblFRef.Text = "Filter by Destination";
            this.lblFRef.Click += new System.EventHandler(this.lblFRef_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(11, 25);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(117, 25);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 21);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter By Destination";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lstFlights
            // 
            this.lstFlights.FormattingEnabled = true;
            this.lstFlights.Location = new System.Drawing.Point(11, 51);
            this.lstFlights.Name = "lstFlights";
            this.lstFlights.Size = new System.Drawing.Size(468, 251);
            this.lstFlights.TabIndex = 13;
            this.lstFlights.SelectedIndexChanged += new System.EventHandler(this.lstBookings_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(380, 32);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 14;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(332, 305);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 21);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(46, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 21);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 17;
            // 
            // frmFlightsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lstFlights);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFRef);
            this.Name = "frmFlightsMain";
            this.Text = "frmFlightsMain";
            this.Load += new System.EventHandler(this.frmFlightsMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFRef;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lstFlights;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}