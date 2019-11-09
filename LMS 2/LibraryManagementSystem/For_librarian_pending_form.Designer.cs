namespace LibraryManagementSystem
{
    partial class For_librarian_pending_form
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
            this.pending_gridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textarea = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pending_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pending_gridview
            // 
            this.pending_gridview.AllowUserToOrderColumns = true;
            this.pending_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pending_gridview.Location = new System.Drawing.Point(12, 14);
            this.pending_gridview.Name = "pending_gridview";
            this.pending_gridview.Size = new System.Drawing.Size(602, 424);
            this.pending_gridview.TabIndex = 0;
            this.pending_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pending_gridview_CellClick);
            this.pending_gridview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Pending_gridview_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sent Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendMsg);
            // 
            // textarea
            // 
            this.textarea.Location = new System.Drawing.Point(620, 92);
            this.textarea.Name = "textarea";
            this.textarea.Size = new System.Drawing.Size(168, 96);
            this.textarea.TabIndex = 2;
            this.textarea.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Message";
            // 
            // For_librarian_pending_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pending_gridview);
            this.Name = "For_librarian_pending_form";
            this.Text = "For_librarian_pending_form";
            this.Load += new System.EventHandler(this.For_librarian_pending_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pending_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pending_gridview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textarea;
        private System.Windows.Forms.Label label1;
    }
}