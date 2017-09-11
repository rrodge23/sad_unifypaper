namespace UnifyPaper.form.pages
{
    partial class frmAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.tbFullname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAccountInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUserLevel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbUserLevel = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFullname
            // 
            // 
            // 
            // 
            this.tbFullname.Border.Class = "TextBoxBorder";
            this.tbFullname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFullname.Location = new System.Drawing.Point(153, 31);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.PreventEnterBeep = true;
            this.tbFullname.Size = new System.Drawing.Size(152, 20);
            this.tbFullname.TabIndex = 1;
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.Border.Class = "TextBoxBorder";
            this.tbUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUsername.Location = new System.Drawing.Point(153, 66);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PreventEnterBeep = true;
            this.tbUsername.Size = new System.Drawing.Size(152, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.Border.Class = "TextBoxBorder";
            this.tbPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPassword.Location = new System.Drawing.Point(153, 100);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PreventEnterBeep = true;
            this.tbPassword.Size = new System.Drawing.Size(152, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbLastname_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(100, 206);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 25);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(193, 207);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 24);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Account Information";
            // 
            // lbAccountInformation
            // 
            this.lbAccountInformation.AutoSize = true;
            this.lbAccountInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInformation.Location = new System.Drawing.Point(39, 12);
            this.lbAccountInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountInformation.Name = "lbAccountInformation";
            this.lbAccountInformation.Size = new System.Drawing.Size(176, 19);
            this.lbAccountInformation.TabIndex = 20;
            this.lbAccountInformation.Text = "Account Information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbUserLevel);
            this.panel1.Controls.Add(this.lbUserLevel);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.tbConfirmPassword);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbConfirmPassword);
            this.panel1.Controls.Add(this.tbFullname);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbFullname);
            this.panel1.Location = new System.Drawing.Point(11, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 258);
            this.panel1.TabIndex = 21;
            // 
            // cmbUserLevel
            // 
            this.cmbUserLevel.DisplayMember = "Text";
            this.cmbUserLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserLevel.FormattingEnabled = true;
            this.cmbUserLevel.ItemHeight = 15;
            this.cmbUserLevel.Location = new System.Drawing.Point(153, 160);
            this.cmbUserLevel.Name = "cmbUserLevel";
            this.cmbUserLevel.Size = new System.Drawing.Size(152, 21);
            this.cmbUserLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUserLevel.TabIndex = 5;
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLevel.Location = new System.Drawing.Point(70, 163);
            this.lbUserLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(70, 17);
            this.lbUserLevel.TabIndex = 29;
            this.lbUserLevel.Text = "User Level";
            // 
            // tbConfirmPassword
            // 
            // 
            // 
            // 
            this.tbConfirmPassword.Border.Class = "TextBoxBorder";
            this.tbConfirmPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbConfirmPassword.Location = new System.Drawing.Point(153, 131);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PreventEnterBeep = true;
            this.tbConfirmPassword.Size = new System.Drawing.Size(152, 20);
            this.tbConfirmPassword.TabIndex = 4;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(22, 134);
            this.lbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(118, 17);
            this.lbConfirmPassword.TabIndex = 27;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(74, 101);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 17);
            this.lbPassword.TabIndex = 26;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(71, 67);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(69, 17);
            this.lbUsername.TabIndex = 25;
            this.lbUsername.Text = "Username";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.Location = new System.Drawing.Point(74, 32);
            this.lbFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(66, 17);
            this.lbFullname.TabIndex = 23;
            this.lbFullname.Text = "Full Name";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(391, 295);
            this.Controls.Add(this.lbAccountInformation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.Load += new System.EventHandler(this.frmAddAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX tbFullname;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPassword;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAccountInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbFullname;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUserLevel;
        private System.Windows.Forms.Label lbUserLevel;
        private DevComponents.DotNetBar.Controls.TextBoxX tbConfirmPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
    }
}