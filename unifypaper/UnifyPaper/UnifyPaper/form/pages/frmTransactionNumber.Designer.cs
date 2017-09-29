namespace UnifyPaper.form.pages
{
    partial class frmTransactionNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionNumber));
            this.tbEnterTransactionNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.lblLastTransaction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnterTransactionNumber
            // 
            this.tbEnterTransactionNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbEnterTransactionNumber.Border.Class = "TextBoxBorder";
            this.tbEnterTransactionNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEnterTransactionNumber.DisabledBackColor = System.Drawing.Color.White;
            this.tbEnterTransactionNumber.ForeColor = System.Drawing.Color.Black;
            this.tbEnterTransactionNumber.Location = new System.Drawing.Point(244, 55);
            this.tbEnterTransactionNumber.Name = "tbEnterTransactionNumber";
            this.tbEnterTransactionNumber.PreventEnterBeep = true;
            this.tbEnterTransactionNumber.Size = new System.Drawing.Size(304, 22);
            this.tbEnterTransactionNumber.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX1.Location = new System.Drawing.Point(46, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(192, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Enter Transaction Number:";
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(159, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(81, 33);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(389, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 33);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLastTransaction
            // 
            this.lblLastTransaction.AutoSize = true;
            this.lblLastTransaction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLastTransaction.Location = new System.Drawing.Point(13, 189);
            this.lblLastTransaction.Name = "lblLastTransaction";
            this.lblLastTransaction.Size = new System.Drawing.Size(146, 17);
            this.lblLastTransaction.TabIndex = 4;
            this.lblLastTransaction.Text = "Last Transaction: 999";
            // 
            // frmTransactionNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(621, 218);
            this.Controls.Add(this.lblLastTransaction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbEnterTransactionNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransactionNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbEnterTransactionNumber;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label lblLastTransaction;
    }
}