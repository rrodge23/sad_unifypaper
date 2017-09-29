namespace UnifyPaper.form.pages
{
    partial class frmTransactionOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionOption));
            this.cbSalesReturnTransaction = new System.Windows.Forms.CheckBox();
            this.btnNTT = new DevComponents.DotNetBar.ButtonX();
            this.btnTET = new DevComponents.DotNetBar.ButtonX();
            this.btnMTO = new DevComponents.DotNetBar.ButtonX();
            this.btnTD = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // cbSalesReturnTransaction
            // 
            this.cbSalesReturnTransaction.AutoSize = true;
            this.cbSalesReturnTransaction.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalesReturnTransaction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbSalesReturnTransaction.Location = new System.Drawing.Point(41, 37);
            this.cbSalesReturnTransaction.Name = "cbSalesReturnTransaction";
            this.cbSalesReturnTransaction.Size = new System.Drawing.Size(202, 21);
            this.cbSalesReturnTransaction.TabIndex = 0;
            this.cbSalesReturnTransaction.Text = "Sales Return Transaction";
            this.cbSalesReturnTransaction.UseVisualStyleBackColor = true;
            // 
            // btnNTT
            // 
            this.btnNTT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNTT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNTT.Location = new System.Drawing.Point(41, 86);
            this.btnNTT.Name = "btnNTT";
            this.btnNTT.Size = new System.Drawing.Size(202, 23);
            this.btnNTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNTT.TabIndex = 1;
            this.btnNTT.Text = "Non Taxable Transaction";
            // 
            // btnTET
            // 
            this.btnTET.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTET.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTET.Location = new System.Drawing.Point(41, 124);
            this.btnTET.Name = "btnTET";
            this.btnTET.Size = new System.Drawing.Size(202, 23);
            this.btnTET.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTET.TabIndex = 2;
            this.btnTET.Text = "Tax Exempt Transaction";
            // 
            // btnMTO
            // 
            this.btnMTO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMTO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMTO.Location = new System.Drawing.Point(41, 159);
            this.btnMTO.Name = "btnMTO";
            this.btnMTO.Size = new System.Drawing.Size(202, 23);
            this.btnMTO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMTO.TabIndex = 3;
            this.btnMTO.Text = "Manual Tax OverRide";
            // 
            // btnTD
            // 
            this.btnTD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTD.Location = new System.Drawing.Point(41, 194);
            this.btnTD.Name = "btnTD";
            this.btnTD.Size = new System.Drawing.Size(202, 23);
            this.btnTD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTD.TabIndex = 4;
            this.btnTD.Text = "Transaction Discount";
            this.btnTD.Click += new System.EventHandler(this.btnTD_Click);
            // 
            // frmTransactionOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnTD);
            this.Controls.Add(this.btnMTO);
            this.Controls.Add(this.btnTET);
            this.Controls.Add(this.btnNTT);
            this.Controls.Add(this.cbSalesReturnTransaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransactionOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSalesReturnTransaction;
        private DevComponents.DotNetBar.ButtonX btnNTT;
        private DevComponents.DotNetBar.ButtonX btnTET;
        private DevComponents.DotNetBar.ButtonX btnMTO;
        private DevComponents.DotNetBar.ButtonX btnTD;
    }
}