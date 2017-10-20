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
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnSalesReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLastTransaction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReprint
            // 
            this.btnReprint.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprint.Location = new System.Drawing.Point(28, 34);
            this.btnReprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(212, 33);
            this.btnReprint.TabIndex = 0;
            this.btnReprint.Text = "Reprint Last Sales Receipt";
            this.btnReprint.UseVisualStyleBackColor = true;
            // 
            // btnVoid
            // 
            this.btnVoid.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.Location = new System.Drawing.Point(28, 71);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(212, 33);
            this.btnVoid.TabIndex = 2;
            this.btnVoid.Text = "Void a Past Transaction";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReturn.Location = new System.Drawing.Point(28, 108);
            this.btnSalesReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Size = new System.Drawing.Size(212, 33);
            this.btnSalesReturn.TabIndex = 3;
            this.btnSalesReturn.Text = "Sales Return from a Past Transaction";
            this.btnSalesReturn.UseVisualStyleBackColor = true;
            this.btnSalesReturn.Click += new System.EventHandler(this.btnSalesReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Transaction:";
            // 
            // lbLastTransaction
            // 
            this.lbLastTransaction.AutoSize = true;
            this.lbLastTransaction.ForeColor = System.Drawing.Color.White;
            this.lbLastTransaction.Location = new System.Drawing.Point(120, 164);
            this.lbLastTransaction.Name = "lbLastTransaction";
            this.lbLastTransaction.Size = new System.Drawing.Size(37, 13);
            this.lbLastTransaction.TabIndex = 5;
            this.lbLastTransaction.Text = "11111";
            // 
            // frmReCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(259, 195);
            this.Controls.Add(this.lbLastTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalesReturn);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnReprint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReCall";
            this.Load += new System.EventHandler(this.frmReCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLastTransaction;
    }
}