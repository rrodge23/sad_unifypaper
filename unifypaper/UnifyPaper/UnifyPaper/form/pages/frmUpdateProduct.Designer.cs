namespace UnifyPaper.form.pages
{
    partial class frmUpdateProduct
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
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.lbLastname = new System.Windows.Forms.Label();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.lbMiddlename = new System.Windows.Forms.Label();
            this.tbFirstname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbAccountID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbMiddlename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 16;
            this.comboBoxEx1.Location = new System.Drawing.Point(209, 186);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(256, 22);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(455, 236);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 24);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastname.Location = new System.Drawing.Point(52, 154);
            this.lbLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(37, 17);
            this.lbLastname.TabIndex = 26;
            this.lbLastname.Text = "Price";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(350, 236);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 25);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "Update";
            // 
            // lbMiddlename
            // 
            this.lbMiddlename.AutoSize = true;
            this.lbMiddlename.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddlename.Location = new System.Drawing.Point(52, 107);
            this.lbMiddlename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMiddlename.Name = "lbMiddlename";
            this.lbMiddlename.Size = new System.Drawing.Size(84, 17);
            this.lbMiddlename.TabIndex = 25;
            this.lbMiddlename.Text = "Middle Name";
            // 
            // tbFirstname
            // 
            // 
            // 
            // 
            this.tbFirstname.Border.Class = "TextBoxBorder";
            this.tbFirstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFirstname.Location = new System.Drawing.Point(209, 74);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstname.Multiline = true;
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.PreventEnterBeep = true;
            this.tbFirstname.Size = new System.Drawing.Size(305, 62);
            this.tbFirstname.TabIndex = 31;
            // 
            // tbAccountID
            // 
            // 
            // 
            // 
            this.tbAccountID.Border.Class = "TextBoxBorder";
            this.tbAccountID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAccountID.Location = new System.Drawing.Point(209, 38);
            this.tbAccountID.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.PreventEnterBeep = true;
            this.tbAccountID.Size = new System.Drawing.Size(206, 20);
            this.tbAccountID.TabIndex = 30;
            // 
            // tbMiddlename
            // 
            // 
            // 
            // 
            this.tbMiddlename.Border.Class = "TextBoxBorder";
            this.tbMiddlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMiddlename.Location = new System.Drawing.Point(209, 151);
            this.tbMiddlename.Margin = new System.Windows.Forms.Padding(2);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.PreventEnterBeep = true;
            this.tbMiddlename.Size = new System.Drawing.Size(305, 20);
            this.tbMiddlename.TabIndex = 32;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(52, 192);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(65, 17);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "Category";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.Location = new System.Drawing.Point(52, 74);
            this.lbFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(129, 17);
            this.lbFirstname.TabIndex = 23;
            this.lbFirstname.Text = "Product Description";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountID.Location = new System.Drawing.Point(52, 41);
            this.lbAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(93, 17);
            this.lbAccountID.TabIndex = 22;
            this.lbAccountID.Text = "Product Code";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxEx1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lbLastname);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lbMiddlename);
            this.panel1.Controls.Add(this.tbFirstname);
            this.panel1.Controls.Add(this.tbAccountID);
            this.panel1.Controls.Add(this.tbMiddlename);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbFirstname);
            this.panel1.Controls.Add(this.lbAccountID);
            this.panel1.Location = new System.Drawing.Point(58, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 281);
            this.panel1.TabIndex = 38;
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 356);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateProduct";
            this.Text = "frmUpdateProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label lbLastname;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private System.Windows.Forms.Label lbMiddlename;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFirstname;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAccountID;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMiddlename;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.Panel panel1;
    }
}