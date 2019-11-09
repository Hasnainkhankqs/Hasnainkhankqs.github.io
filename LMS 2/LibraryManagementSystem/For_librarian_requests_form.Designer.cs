namespace LibraryManagementSystem
{
    partial class For_librarian_requests_form
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
            this.requests_gridview = new System.Windows.Forms.DataGridView();
            this.Request_accept_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requests_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // requests_gridview
            // 
            this.requests_gridview.AllowUserToOrderColumns = true;
            this.requests_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requests_gridview.Location = new System.Drawing.Point(22, 12);
            this.requests_gridview.Name = "requests_gridview";
            this.requests_gridview.Size = new System.Drawing.Size(646, 404);
            this.requests_gridview.TabIndex = 0;
            // 
            // Request_accept_btn
            // 
            this.Request_accept_btn.Location = new System.Drawing.Point(693, 79);
            this.Request_accept_btn.Name = "Request_accept_btn";
            this.Request_accept_btn.Size = new System.Drawing.Size(95, 23);
            this.Request_accept_btn.TabIndex = 1;
            this.Request_accept_btn.Text = "Accept Request";
            this.Request_accept_btn.UseVisualStyleBackColor = true;
            this.Request_accept_btn.Click += new System.EventHandler(this.Request_accept_btn_Click);
            // 
            // For_librarian_requests_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Request_accept_btn);
            this.Controls.Add(this.requests_gridview);
            this.Name = "For_librarian_requests_form";
            this.Text = "For_librarian_requests_form";
            this.Load += new System.EventHandler(this.For_librarian_requests_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requests_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requests_gridview;
        private System.Windows.Forms.Button Request_accept_btn;
    }
}