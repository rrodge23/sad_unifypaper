namespace UnifyPaper.form.pages
{
    partial class frmViewBelowMinimumProducts
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemoveAll = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgAddedProductMinimumQuantity = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAddAll = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgProductList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrintItems = new DevComponents.DotNetBar.ButtonX();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddedProductMinimumQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrintItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(29, 724);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1314, 38);
            this.panel4.TabIndex = 43;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemoveAll.AntiAlias = true;
            this.btnRemoveAll.Checked = true;
            this.btnRemoveAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAll.Location = new System.Drawing.Point(1236, 29);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnRemoveAll.Size = new System.Drawing.Size(88, 32);
            this.btnRemoveAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemoveAll.Symbol = "";
            this.btnRemoveAll.TabIndex = 27;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Added List";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1339, 33);
            this.panel13.TabIndex = 33;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1339, 33);
            this.panel10.TabIndex = 34;
            // 
            // dgAddedProductMinimumQuantity
            // 
            this.dgAddedProductMinimumQuantity.BackgroundColor = System.Drawing.Color.White;
            this.dgAddedProductMinimumQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddedProductMinimumQuantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAddedProductMinimumQuantity.Location = new System.Drawing.Point(0, 35);
            this.dgAddedProductMinimumQuantity.Name = "dgAddedProductMinimumQuantity";
            this.dgAddedProductMinimumQuantity.Size = new System.Drawing.Size(1339, 337);
            this.dgAddedProductMinimumQuantity.TabIndex = 33;
            this.dgAddedProductMinimumQuantity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddedProductMinimumQuantity_CellClick);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 357);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1343, 39);
            this.panel9.TabIndex = 36;
            // 
            // btnAddAll
            // 
            this.btnAddAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddAll.AntiAlias = true;
            this.btnAddAll.Checked = true;
            this.btnAddAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAll.Location = new System.Drawing.Point(1127, 29);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnAddAll.Size = new System.Drawing.Size(88, 32);
            this.btnAddAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddAll.Symbol = "57669";
            this.btnAddAll.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAddAll.TabIndex = 35;
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(29, 762);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 10);
            this.panel2.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Product List";
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1269, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(45, 10);
            this.panel12.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.AntiAlias = true;
            this.buttonX1.Checked = true;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(1305, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX1.Size = new System.Drawing.Size(34, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_2);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 772);
            this.panel1.TabIndex = 40;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Firebrick;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.btnRemoveAll);
            this.panel8.Controls.Add(this.btnAddAll);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.dgProductList);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1343, 357);
            this.panel8.TabIndex = 34;
            // 
            // dgProductList
            // 
            this.dgProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProductList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProductList.Location = new System.Drawing.Point(0, 63);
            this.dgProductList.Name = "dgProductList";
            this.dgProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductList.Size = new System.Drawing.Size(1339, 290);
            this.dgProductList.TabIndex = 31;
            this.dgProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Below Minimum Products";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonX1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1339, 27);
            this.panel11.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1343, 772);
            this.panel6.TabIndex = 45;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Firebrick;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.dgAddedProductMinimumQuantity);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 396);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1343, 376);
            this.panel7.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(217, 533);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1343, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 772);
            this.panel3.TabIndex = 42;
            // 
            // btnPrintItems
            // 
            this.btnPrintItems.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintItems.AntiAlias = true;
            this.btnPrintItems.Checked = true;
            this.btnPrintItems.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintItems.Location = new System.Drawing.Point(1209, 8);
            this.btnPrintItems.Name = "btnPrintItems";
            this.btnPrintItems.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnPrintItems.Size = new System.Drawing.Size(99, 27);
            this.btnPrintItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintItems.Symbol = "";
            this.btnPrintItems.TabIndex = 32;
            this.btnPrintItems.Text = "Export";
            // 
            // frmViewBelowMinimumProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewBelowMinimumProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewBelowMinimumProducts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewBelowMinimumProducts_Load);
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAddedProductMinimumQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgAddedProductMinimumQuantity;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btnRemoveAll;
        private DevComponents.DotNetBar.ButtonX btnAddAll;
        private DevComponents.DotNetBar.ButtonX btnPrintItems;

    }
}