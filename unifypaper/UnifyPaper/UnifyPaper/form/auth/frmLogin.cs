﻿using System;
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
                    this.Close();
                }
                else
                {
                    errorLabel.Text = "Invalid Information Details";
                }
            }
            else
            {
                errorLabel.Text = "Fill Out All Details";
            }                  
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            errorLabel.Text = "";
            List<Classes.Entities.users> u = new List<Classes.Entities.users>();
            u = db.getAllUser();
            if(u.Count < 1) 
            {
                form.pages.frmMainPage fmp = new form.pages.frmMainPage();
                fmp.ShowDialog();
                this.Close();
            }
        }

        private void frmLogin_Keydown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == Keys.Escape.GetHashCode())
            {
                this.close();
            }*/
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
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
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
