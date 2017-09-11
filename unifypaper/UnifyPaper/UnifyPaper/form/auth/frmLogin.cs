using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifyPaper
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '•';
        }

        Classes.Database.database db = new Classes.Database.database();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                Classes.Entities.users u = new Classes.Entities.users();
                u.username = tbUsername.Text.ToString().Trim();
                u.password = tbPassword.Text.ToString().Trim();

                Classes.Entities.users user = new Classes.Entities.users();
                user = db.checkLogin(u);
                if (user != null)
                {
                    Classes.Session.sessionUsers.ID = user.ID;
                    Classes.Session.sessionUsers.username = tbUsername.Text.ToString().Trim();
                    Classes.Session.sessionUsers.password = tbPassword.Text.ToString().Trim();
                    Classes.Session.sessionUsers.userlevel = user.userlevel;
                    form.pages.frmMainPage fmp = new form.pages.frmMainPage();
                    fmp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Out Fields");
            }                  
        }

        private void close()
        {
            this.close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Keys.Escape.GetHashCode())
            {
                close();
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.close();
        }
    }
}
