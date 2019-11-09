namespace LibraryManagementSystem
{
    partial class User_profile_form
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
            this.catagory_combo = new System.Windows.Forms.ComboBox();
            this.item_combo = new System.Windows.Forms.ComboBox();
            this.loan_itm_btn = new System.Windows.Forms.Button();
            this.catagory_lbl = new System.Windows.Forms.Label();
            this.item_lbl = new System.Windows.Forms.Label();
            this.remaining_count = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone_no_lbl = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.user_email_lbll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loan_history_grid_view = new System.Windows.Forms.DataGridView();
            this.OverDues_gird_view = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loanHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messgeCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loan_history_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverDues_gird_view)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catagory_combo
            // 
            this.catagory_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagory_combo.FormattingEnabled = true;
            this.catagory_combo.Location = new System.Drawing.Point(458, 97);
            this.catagory_combo.Name = "catagory_combo";
            this.catagory_combo.Size = new System.Drawing.Size(121, 21);
            this.catagory_combo.TabIndex = 0;
            this.catagory_combo.DropDownClosed += new System.EventHandler(this.Catagory_combo_DropDownClosed);
            // 
            // item_combo
            // 
            this.item_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item_combo.FormattingEnabled = true;
            this.item_combo.Location = new System.Drawing.Point(667, 92);
            this.item_combo.Name = "item_combo";
            this.item_combo.Size = new System.Drawing.Size(121, 21);
            this.item_combo.TabIndex = 1;
            // 
            // loan_itm_btn
            // 
            this.loan_itm_btn.BackColor = System.Drawing.SystemColors.Control;
            this.loan_itm_btn.Location = new System.Drawing.Point(713, 156);
            this.loan_itm_btn.Name = "loan_itm_btn";
            this.loan_itm_btn.Size = new System.Drawing.Size(75, 23);
            this.loan_itm_btn.TabIndex = 2;
            this.loan_itm_btn.Text = "Loan item";
            this.loan_itm_btn.UseVisualStyleBackColor = false;
            this.loan_itm_btn.Click += new System.EventHandler(this.Loan_itm_btn_Click);
            // 
            // catagory_lbl
            // 
            this.catagory_lbl.AutoSize = true;
            this.catagory_lbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.catagory_lbl.Location = new System.Drawing.Point(387, 105);
            this.catagory_lbl.Name = "catagory_lbl";
            this.catagory_lbl.Size = new System.Drawing.Size(49, 13);
            this.catagory_lbl.TabIndex = 3;
            this.catagory_lbl.Text = "Catagory";
            // 
            // item_lbl
            // 
            this.item_lbl.AutoSize = true;
            this.item_lbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.item_lbl.Location = new System.Drawing.Point(613, 100);
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.Size = new System.Drawing.Size(27, 13);
            this.item_lbl.TabIndex = 4;
            this.item_lbl.Text = "Item";
            // 
            // remaining_count
            // 
            this.remaining_count.AutoSize = true;
            this.remaining_count.BackColor = System.Drawing.Color.Cornsilk;
            this.remaining_count.ForeColor = System.Drawing.Color.Crimson;
            this.remaining_count.Location = new System.Drawing.Point(567, 11);
            this.remaining_count.Name = "remaining_count";
            this.remaining_count.Size = new System.Drawing.Size(35, 13);
            this.remaining_count.TabIndex = 5;
            this.remaining_count.Text = "label1";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.email_lbl.Location = new System.Drawing.Point(86, 47);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(59, 13);
            this.email_lbl.TabIndex = 7;
            this.email_lbl.Text = "nameLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phone_no_lbl);
            this.groupBox1.Controls.Add(this.ph);
            this.groupBox1.Controls.Add(this.name_lbl);
            this.groupBox1.Controls.Add(this.user_email_lbll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.email_lbl);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic info";
            // 
            // phone_no_lbl
            // 
            this.phone_no_lbl.AutoSize = true;
            this.phone_no_lbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.phone_no_lbl.Location = new System.Drawing.Point(86, 71);
            this.phone_no_lbl.Name = "phone_no_lbl";
            this.phone_no_lbl.Size = new System.Drawing.Size(35, 13);
            this.phone_no_lbl.TabIndex = 12;
            this.phone_no_lbl.Text = "label2";
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.ForeColor = System.Drawing.Color.Cornsilk;
            this.ph.Location = new System.Drawing.Point(20, 71);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(58, 13);
            this.ph.TabIndex = 11;
            this.ph.Text = "Phone No.";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.name_lbl.Location = new System.Drawing.Point(86, 25);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 10;
            this.name_lbl.Text = "label3";
            // 
            // user_email_lbll
            // 
            this.user_email_lbll.AutoSize = true;
            this.user_email_lbll.ForeColor = System.Drawing.Color.Cornsilk;
            this.user_email_lbll.Location = new System.Drawing.Point(20, 47);
            this.user_email_lbll.Name = "user_email_lbll";
            this.user_email_lbll.Size = new System.Drawing.Size(32, 13);
            this.user_email_lbll.TabIndex = 9;
            this.user_email_lbll.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // loan_history_grid_view
            // 
            this.loan_history_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loan_history_grid_view.Location = new System.Drawing.Point(12, 265);
            this.loan_history_grid_view.Name = "loan_history_grid_view";
            this.loan_history_grid_view.Size = new System.Drawing.Size(240, 150);
            this.loan_history_grid_view.TabIndex = 9;
            // 
            // OverDues_gird_view
            // 
            this.OverDues_gird_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OverDues_gird_view.Location = new System.Drawing.Point(339, 265);
            this.OverDues_gird_view.Name = "OverDues_gird_view";
            this.OverDues_gird_view.Size = new System.Drawing.Size(240, 150);
            this.OverDues_gird_view.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loan History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(336, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Over Dues";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loanHistoryToolStripMenuItem,
            this.dueDatesToolStripMenuItem,
            this.approvedItemsToolStripMenuItem,
            this.messgeCenterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loanHistoryToolStripMenuItem
            // 
            this.loanHistoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.loanHistoryToolStripMenuItem.Name = "loanHistoryToolStripMenuItem";
            this.loanHistoryToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.loanHistoryToolStripMenuItem.Text = "Requests History";
            this.loanHistoryToolStripMenuItem.Click += new System.EventHandler(this.LoanHistoryToolStripMenuItem_Click);
            // 
            // dueDatesToolStripMenuItem
            // 
            this.dueDatesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dueDatesToolStripMenuItem.Name = "dueDatesToolStripMenuItem";
            this.dueDatesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.dueDatesToolStripMenuItem.Text = "Due Dates Item";
            this.dueDatesToolStripMenuItem.Click += new System.EventHandler(this.DueDatesToolStripMenuItem_Click);
            // 
            // approvedItemsToolStripMenuItem
            // 
            this.approvedItemsToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.approvedItemsToolStripMenuItem.Name = "approvedItemsToolStripMenuItem";
            this.approvedItemsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.approvedItemsToolStripMenuItem.Text = "Approved Items";
            this.approvedItemsToolStripMenuItem.Click += new System.EventHandler(this.ApprovedItemsToolStripMenuItem_Click);
            // 
            // messgeCenterToolStripMenuItem
            // 
            this.messgeCenterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messgeCenterToolStripMenuItem.Name = "messgeCenterToolStripMenuItem";
            this.messgeCenterToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.messgeCenterToolStripMenuItem.Text = "Messge Center";
            this.messgeCenterToolStripMenuItem.Click += new System.EventHandler(this.MessgeCenterToolStripMenuItem_Click);
            // 
            // User_profile_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OverDues_gird_view);
            this.Controls.Add(this.loan_history_grid_view);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.remaining_count);
            this.Controls.Add(this.item_lbl);
            this.Controls.Add(this.catagory_lbl);
            this.Controls.Add(this.loan_itm_btn);
            this.Controls.Add(this.item_combo);
            this.Controls.Add(this.catagory_combo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User_profile_form";
            this.Text = "user_profile_form";
            this.Load += new System.EventHandler(this.User_profile_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loan_history_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverDues_gird_view)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catagory_combo;
        private System.Windows.Forms.ComboBox item_combo;
        private System.Windows.Forms.Button loan_itm_btn;
        private System.Windows.Forms.Label catagory_lbl;
        private System.Windows.Forms.Label item_lbl;
        private System.Windows.Forms.Label remaining_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label user_email_lbll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loan_history_grid_view;
        private System.Windows.Forms.Label phone_no_lbl;
        private System.Windows.Forms.Label ph;
        public System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.DataGridView OverDues_gird_view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loanHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messgeCenterToolStripMenuItem;
    }
}