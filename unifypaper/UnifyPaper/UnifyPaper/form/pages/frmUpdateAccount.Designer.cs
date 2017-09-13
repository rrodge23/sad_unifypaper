namespace UnifyPaper.form.pages
{
    partial class frmUpdateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAccount));
            this.lbAccountInformation = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.tbFullname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCurrentPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbUserID = new System.Windows.Forms.Label();
            this.cmbUserLevel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbUserLevel = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccountInformation
            // 
            this.lbAccountInformation.AutoSize = true;
            this.lbAccountInformation.BackColor = System.Drawing.Color.DimGray;
            this.lbAccountInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAccountInformation.Location = new System.Drawing.Point(31, 15);
            this.lbAccountInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountInformation.Name = "lbAccountInformation";
            this.lbAccountInformation.Padding = new System.Windows.Forms.Padding(5);
            this.lbAccountInformation.Size = new System.Drawing.Size(186, 29);
            this.lbAccountInformation.TabIndex = 28;
            this.lbAccountInformation.Text = "Account Information";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.AntiAlias = true;
            this.btnCancel.Checked = true;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(171, 245);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancel.Size = new System.Drawing.Size(88, 45);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.AntiAlias = true;
            this.btnUpdate.Checked = true;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(57, 245);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnUpdate.Size = new System.Drawing.Size(88, 45);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.Symbol = "";
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = " Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbFullname
            // 
            this.tbFullname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbFullname.Border.Class = "TextBoxBorder";
            this.tbFullname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFullname.DisabledBackColor = System.Drawing.Color.White;
            this.tbFullname.ForeColor = System.Drawing.Color.Black;
            this.tbFullname.Location = new System.Drawing.Point(139, 30);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(2);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.PreventEnterBeep = true;
            this.tbFullname.Size = new System.Drawing.Size(152, 20);
            this.tbFullname.TabIndex = 25;
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbCurrentPassword.Border.Class = "TextBoxBorder";
            this.tbCurrentPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCurrentPassword.DisabledBackColor = System.Drawing.Color.White;
            this.tbCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.tbCurrentPassword.Location = new System.Drawing.Point(139, 99);
            this.tbCurrentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PreventEnterBeep = true;
            this.tbCurrentPassword.Size = new System.Drawing.Size(152, 20);
            this.tbCurrentPassword.TabIndex = 24;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbUsername.Border.Class = "TextBoxBorder";
            this.tbUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUsername.DisabledBackColor = System.Drawing.Color.White;
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.Location = new System.Drawing.Point(139, 65);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PreventEnterBeep = true;
            this.tbUsername.Size = new System.Drawing.Size(152, 20);
            this.tbUsername.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxX1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lbNewPassword);
            this.panel1.Controls.Add(this.tbNewPassword);
            this.panel1.Controls.Add(this.lbUserID);
            this.panel1.Controls.Add(this.tbCurrentPassword);
            this.panel1.Controls.Add(this.tbFullname);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.cmbUserLevel);
            this.panel1.Controls.Add(this.lbCurrentPassword);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbUserLevel);
            this.panel1.Controls.Add(this.lbFullname);
            this.panel1.Controls.Add(this.lbAccountID);
            this.panel1.Location = new System.Drawing.Point(11, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 313);
            this.panel1.TabIndex = 29;
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(139, 165);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(152, 20);
            this.textBoxX1.TabIndex = 32;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNewPassword.Location = new System.Drawing.Point(39, 164);
            this.lbNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(96, 17);
            this.lbNewPassword.TabIndex = 31;
            this.lbNewPassword.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbNewPassword.Border.Class = "TextBoxBorder";
            this.tbNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNewPassword.DisabledBackColor = System.Drawing.Color.White;
            this.tbNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tbNewPassword.Location = new System.Drawing.Point(139, 132);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PreventEnterBeep = true;
            this.tbNewPassword.Size = new System.Drawing.Size(152, 20);
            this.tbNewPassword.TabIndex = 30;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(141, 37);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(0, 13);
            this.lbUserID.TabIndex = 28;
            // 
            // cmbUserLevel
            // 
            this.cmbUserLevel.DisplayMember = "Text";
            this.cmbUserLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserLevel.ForeColor = System.Drawing.Color.Black;
            this.cmbUserLevel.FormattingEnabled = true;
            this.cmbUserLevel.ItemHeight = 16;
            this.cmbUserLevel.Location = new System.Drawing.Point(139, 195);
            this.cmbUserLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserLevel.Name = "cmbUserLevel";
            this.cmbUserLevel.Size = new System.Drawing.Size(152, 22);
            this.cmbUserLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUserLevel.TabIndex = 27;
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCurrentPassword.Location = new System.Drawing.Point(18, 131);
            this.lbCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(117, 17);
            this.lbCurrentPassword.TabIndex = 26;
            this.lbCurrentPassword.Text = "Current Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsername.Location = new System.Drawing.Point(66, 98);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(69, 17);
            this.lbUsername.TabIndex = 25;
            this.lbUsername.Text = "Username";
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUserLevel.Location = new System.Drawing.Point(65, 195);
            this.lbUserLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(70, 17);
            this.lbUserLevel.TabIndex = 24;
            this.lbUserLevel.Text = "User Level";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFullname.Location = new System.Drawing.Point(74, 64);
            this.lbFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(61, 17);
            this.lbFullname.TabIndex = 23;
            this.lbFullname.Text = "Fullname";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAccountID.Location = new System.Drawing.Point(58, 29);
            this.lbAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(77, 17);
            this.lbAccountID.TabIndex = 22;
            this.lbAccountID.Text = "Account ID";
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(343, 353);
            this.Controls.Add(this.lbAccountInformation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.frmUpdateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountInformation;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFullname;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCurrentPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUserLevel;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbAccountID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUserLevel;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbNewPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNewPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}