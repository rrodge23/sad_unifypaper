using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifyPaper.form.pages
{
    public partial class frmUpdateAccount : Form
    {
        public frmUpdateAccount()
        {
            InitializeComponent();
            tbCurrentPassword.PasswordChar = '•';
            tbNewPassword.PasswordChar = '•';
        }


        public frmMainPage mainPageFrm { get; set; }
        public string ID { get; set; }
        Classes.Database.database db = new Classes.Database.database();

        private void loadData()
        {
            Classes.Entities.users u = new Classes.Entities.users();
            u = db.getUserByID(this.ID);
            tbFullname.Text = u.fullname;
            tbUsername.Text = u.username;
            tbCurrentPassword.Text = u.userlevel;
        }

        public void updateData()
        {
            if (tbFullname.Text.Trim() != "" && tbUsername.Text.Trim() != "" && cmbUserLevel.Text.Trim() != "")
            {
                if (MessageBox.Show("Do you want to update this record?", "Updating...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Classes.Entities.users u = new Classes.Entities.users();
                    u.ID = this.ID;
                    u.fullname = tbFullname.Text.Trim();
                    u.username = tbUsername.Text.Trim();
                    u.userlevel = cmbUserLevel.Text.Trim();

                    db = new Classes.Database.database();
                    db.updateUser(u);
                    mainPageFrm.loadData();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error: Empty!");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateAccount_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
