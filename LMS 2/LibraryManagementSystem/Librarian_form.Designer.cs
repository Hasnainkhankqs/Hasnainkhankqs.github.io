namespace LibraryManagementSystem
{
    partial class Librarian_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.librarain_txt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overDuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Librarian";
            // 
            // librarain_txt
            // 
            this.librarain_txt.AutoSize = true;
            this.librarain_txt.Location = new System.Drawing.Point(630, 9);
            this.librarain_txt.Name = "librarain_txt";
            this.librarain_txt.Size = new System.Drawing.Size(63, 13);
            this.librarain_txt.TabIndex = 2;
            this.librarain_txt.Text = "changeable";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRequestsToolStripMenuItem,
            this.overDuesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allRequestsToolStripMenuItem
            // 
            this.allRequestsToolStripMenuItem.Name = "allRequestsToolStripMenuItem";
            this.allRequestsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.allRequestsToolStripMenuItem.Text = "All Requests";
            this.allRequestsToolStripMenuItem.Click += new System.EventHandler(this.AllRequestsToolStripMenuItem_Click);
            // 
            // overDuesToolStripMenuItem
            // 
            this.overDuesToolStripMenuItem.Name = "overDuesToolStripMenuItem";
            this.overDuesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.overDuesToolStripMenuItem.Text = "Over Dues";
            this.overDuesToolStripMenuItem.Click += new System.EventHandler(this.OverDuesToolStripMenuItem_Click);
            // 
            // Librarian_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.librarain_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Librarian_form";
            this.Text = "Librarian_form";
            this.Load += new System.EventHandler(this.Librarian_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label librarain_txt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overDuesToolStripMenuItem;
    }
}