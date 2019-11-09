namespace LibraryManagementSystem
{
    partial class User_loan_history_form
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
            this.user_loan_history_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.user_loan_history_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // user_loan_history_gridview
            // 
            this.user_loan_history_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_loan_history_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_loan_history_gridview.Location = new System.Drawing.Point(0, 0);
            this.user_loan_history_gridview.Name = "user_loan_history_gridview";
            this.user_loan_history_gridview.Size = new System.Drawing.Size(800, 450);
            this.user_loan_history_gridview.TabIndex = 0;
            // 
            // User_loan_history_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_loan_history_gridview);
            this.Name = "User_loan_history_form";
            this.Text = "User_loan_history_fomr";
            this.Load += new System.EventHandler(this.User_loan_history_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_loan_history_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView user_loan_history_gridview;
    }
}