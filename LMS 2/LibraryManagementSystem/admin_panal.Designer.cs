namespace LibraryManagementSystem
{
    partial class Admin_panal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_name_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersDetailToolStripMenuItem,
            this.addItemToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersDetailToolStripMenuItem
            // 
            this.usersDetailToolStripMenuItem.Name = "usersDetailToolStripMenuItem";
            this.usersDetailToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.usersDetailToolStripMenuItem.Text = "Users Detail";
            this.usersDetailToolStripMenuItem.Click += new System.EventHandler(this.UsersDetailToolStripMenuItem_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addItemToolStripMenuItem.Text = "Add Item";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.form2ToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.form1ToolStripMenuItem.Text = "form1";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.form2ToolStripMenuItem.Text = "form2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // admin_name_lbl
            // 
            this.admin_name_lbl.AutoSize = true;
            this.admin_name_lbl.Location = new System.Drawing.Point(666, 11);
            this.admin_name_lbl.Name = "admin_name_lbl";
            this.admin_name_lbl.Size = new System.Drawing.Size(64, 13);
            this.admin_name_lbl.TabIndex = 2;
            this.admin_name_lbl.Text = "Changeable";
            // 
            // Admin_panal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_name_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_panal";
            this.Text = "admin_panal";
            this.Load += new System.EventHandler(this.MaybeDeleted_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label admin_name_lbl;
    }
}