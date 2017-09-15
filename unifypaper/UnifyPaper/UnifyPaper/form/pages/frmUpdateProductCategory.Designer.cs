namespace UnifyPaper.form.pages
{
    partial class frmUpdateProductCategory
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
            this.lbAccountInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.tbAccountID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccountInformation
            // 
            this.lbAccountInformation.AutoSize = true;
            this.lbAccountInformation.BackColor = System.Drawing.Color.DimGray;
            this.lbAccountInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAccountInformation.Location = new System.Drawing.Point(24, 14);
            this.lbAccountInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountInformation.Name = "lbAccountInformation";
            this.lbAccountInformation.Padding = new System.Windows.Forms.Padding(5);
            this.lbAccountInformation.Size = new System.Drawing.Size(195, 29);
            this.lbAccountInformation.TabIndex = 40;
            this.lbAccountInformation.Text = "Category Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.tbAccountID);
            this.panel1.Controls.Add(this.lbAccountID);
            this.panel1.Location = new System.Drawing.Point(11, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 143);
            this.panel1.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.AntiAlias = true;
            this.btnCancel.Checked = true;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(179, 79);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancel.Size = new System.Drawing.Size(88, 45);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.AntiAlias = true;
            this.btnOK.Checked = true;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(75, 79);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnOK.Size = new System.Drawing.Size(88, 45);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.Symbol = "";
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = " Update";
            // 
            // tbAccountID
            // 
            this.tbAccountID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbAccountID.Border.Class = "TextBoxBorder";
            this.tbAccountID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAccountID.DisabledBackColor = System.Drawing.Color.White;
            this.tbAccountID.ForeColor = System.Drawing.Color.Black;
            this.tbAccountID.Location = new System.Drawing.Point(126, 37);
            this.tbAccountID.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.PreventEnterBeep = true;
            this.tbAccountID.Size = new System.Drawing.Size(202, 20);
            this.tbAccountID.TabIndex = 30;
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAccountID.Location = new System.Drawing.Point(13, 37);
            this.lbAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(109, 17);
            this.lbAccountID.TabIndex = 22;
            this.lbAccountID.Text = "Catergory Name";
            // 
            // frmUpdateProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(376, 183);
            this.Controls.Add(this.lbAccountInformation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateProductCategory";
            this.Text = "frmUpdateProductCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountInformation;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAccountID;
        private System.Windows.Forms.Label lbAccountID;
    }
}