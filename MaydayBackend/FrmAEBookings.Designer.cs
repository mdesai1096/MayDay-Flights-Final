namespace MaydayBackend
{
    partial class FrmAEBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAEBookings));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPayType = new System.Windows.Forms.TextBox();
            this.txtDateBo = new System.Windows.Forms.TextBox();
            this.txtBookRef = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblBookRef = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPaytype = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstCust = new System.Windows.Forms.ListBox();
            this.txtFilterCust = new System.Windows.Forms.TextBox();
            this.btnFilterCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(351, 365);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPayType
            // 
            this.txtPayType.Location = new System.Drawing.Point(655, 248);
            this.txtPayType.Name = "txtPayType";
            this.txtPayType.Size = new System.Drawing.Size(100, 20);
            this.txtPayType.TabIndex = 1;
            // 
            // txtDateBo
            // 
            this.txtDateBo.Location = new System.Drawing.Point(655, 193);
            this.txtDateBo.Name = "txtDateBo";
            this.txtDateBo.Size = new System.Drawing.Size(100, 20);
            this.txtDateBo.TabIndex = 2;
            // 
            // txtBookRef
            // 
            this.txtBookRef.Location = new System.Drawing.Point(655, 70);
            this.txtBookRef.Name = "txtBookRef";
            this.txtBookRef.Size = new System.Drawing.Size(100, 20);
            this.txtBookRef.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(655, 134);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // lblBookRef
            // 
            this.lblBookRef.AutoSize = true;
            this.lblBookRef.Location = new System.Drawing.Point(553, 77);
            this.lblBookRef.Name = "lblBookRef";
            this.lblBookRef.Size = new System.Drawing.Size(96, 13);
            this.lblBookRef.TabIndex = 5;
            this.lblBookRef.Text = "Booking Refernce:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(553, 134);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(553, 193);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date Booked";
            // 
            // lblPaytype
            // 
            this.lblPaytype.AutoSize = true;
            this.lblPaytype.Location = new System.Drawing.Point(553, 255);
            this.lblPaytype.Name = "lblPaytype";
            this.lblPaytype.Size = new System.Drawing.Size(75, 13);
            this.lblPaytype.TabIndex = 8;
            this.lblPaytype.Text = "Payment Type";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblError.Location = new System.Drawing.Point(87, 336);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 9;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(396, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 26);
            this.lblTitle.TabIndex = 10;
            // 
            // lstCust
            // 
            this.lstCust.FormattingEnabled = true;
            this.lstCust.Location = new System.Drawing.Point(27, 86);
            this.lstCust.Name = "lstCust";
            this.lstCust.Size = new System.Drawing.Size(187, 238);
            this.lstCust.TabIndex = 11;
            // 
            // txtFilterCust
            // 
            this.txtFilterCust.Location = new System.Drawing.Point(27, 60);
            this.txtFilterCust.Name = "txtFilterCust";
            this.txtFilterCust.Size = new System.Drawing.Size(100, 20);
            this.txtFilterCust.TabIndex = 12;
            // 
            // btnFilterCust
            // 
            this.btnFilterCust.Location = new System.Drawing.Point(133, 50);
            this.btnFilterCust.Name = "btnFilterCust";
            this.btnFilterCust.Size = new System.Drawing.Size(97, 30);
            this.btnFilterCust.TabIndex = 13;
            this.btnFilterCust.Text = "Filter by Surname";
            this.btnFilterCust.UseVisualStyleBackColor = true;
            this.btnFilterCust.Click += new System.EventHandler(this.btnFilterCust_Click);
            // 
            // FrmAEBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 434);
            this.Controls.Add(this.btnFilterCust);
            this.Controls.Add(this.txtFilterCust);
            this.Controls.Add(this.lstCust);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPaytype);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBookRef);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBookRef);
            this.Controls.Add(this.txtDateBo);
            this.Controls.Add(this.txtPayType);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAEBookings";
            this.Text = "New/Update Booking";
            this.Load += new System.EventHandler(this.FrmAEBookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPayType;
        private System.Windows.Forms.TextBox txtDateBo;
        private System.Windows.Forms.TextBox txtBookRef;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblBookRef;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPaytype;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstCust;
        private System.Windows.Forms.TextBox txtFilterCust;
        private System.Windows.Forms.Button btnFilterCust;
    }
}