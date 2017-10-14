﻿using System;
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
    public partial class frmReCall : Form
    {
        public frmReCall()
        {
            InitializeComponent();
        }


        //INITIATE
        Classes.Model.m_transaction m_trans = new Classes.Model.m_transaction();
        Classes.Entities.transaction e_trans = new Classes.Entities.transaction();

        private void btnViewOrPrintPastSalesReceipt_Click(object sender, EventArgs e)
        {
            frmTransactionNumber ftn = new frmTransactionNumber();
            ftn.ShowDialog();
        }

        private void frmReCall_Load(object sender, EventArgs e)
        {
            displayLatestTransactionID();
        }

        private void displayLatestTransactionID()
        {
           
            lbLastTransaction.Text = m_trans.getLatestTransactionID();
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            frmSalesReturn fsr = new frmSalesReturn();
            fsr.ShowDialog();

            if(fsr.ID != "0")
            {
                Classes.Entities.transaction previousTransaction = new Classes.Entities.transaction();
                previousTransaction = m_trans.getPreviousTransaction(fsr.ID);
                if (previousTransaction != null)
                {
                    Classes.Entities.products prodList = new Classes.Entities.products();

                }
                else
                {
                    MessageBox.Show("Invalid Transaction ID");
                }
            }
            
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {

        }
    }

    
}
