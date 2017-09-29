namespace UnifyPaper.form.pages
{
    partial class frmReCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReCall));
            this.btnReprint = new System.Windows.Forms.Button();
            this.btnViewOrPrintPastSalesReceipt = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnSalesReturn = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReprint
            // 
            this.btnReprint.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprint.Location = new System.Drawing.Point(38, 42);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(282, 41);
            this.btnReprint.TabIndex = 0;
            this.btnReprint.Text = "Reprint Last Sales Receipt";
            this.btnReprint.UseVisualStyleBackColor = true;
            // 
            // btnViewOrPrintPastSalesReceipt
            // 
            this.btnViewOrPrintPastSalesReceipt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrPrintPastSalesReceipt.Location = new System.Drawing.Point(38, 108);
            this.btnViewOrPrintPastSalesReceipt.Name = "btnViewOrPrintPastSalesReceipt";
            this.btnViewOrPrintPastSalesReceipt.Size = new System.Drawing.Size(282, 41);
            this.btnViewOrPrintPastSalesReceipt.TabIndex = 1;
            this.btnViewOrPrintPastSalesReceipt.Text = "View or Print a Past Sales Receipt";
            this.btnViewOrPrintPastSalesReceipt.UseVisualStyleBackColor = true;
            this.btnViewOrPrintPastSalesReceipt.Click += new System.EventHandler(this.btnViewOrPrintPastSalesReceipt_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.Location = new System.Drawing.Point(38, 172);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(282, 41);
            this.btnVoid.TabIndex = 2;
            this.btnVoid.Text = "Void a Past Transaction";
            this.btnVoid.UseVisualStyleBackColor = true;
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReturn.Location = new System.Drawing.Point(38, 230);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Size = new System.Drawing.Size(282, 41);
            this.btnSalesReturn.TabIndex = 3;
            this.btnSalesReturn.Text = "Sales Return from a Past Transaction";
            this.btnSalesReturn.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(38, 290);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(282, 41);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restore Open (Save) Transaction\r\n";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // frmReCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(359, 365);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnSalesReturn);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnViewOrPrintPastSalesReceipt);
            this.Controls.Add(this.btnReprint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReCall";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Button btnViewOrPrintPastSalesReceipt;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Button btnRestore;
    }
}