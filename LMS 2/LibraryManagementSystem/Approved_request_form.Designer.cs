namespace LibraryManagementSystem
{
    partial class Approved_request_form
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
            this.approved_request_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.approved_request_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // approved_request_grid_view
            // 
            this.approved_request_grid_view.AllowUserToOrderColumns = true;
            this.approved_request_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approved_request_grid_view.Location = new System.Drawing.Point(12, 12);
            this.approved_request_grid_view.Name = "approved_request_grid_view";
            this.approved_request_grid_view.Size = new System.Drawing.Size(776, 426);
            this.approved_request_grid_view.TabIndex = 0;
            // 
            // Approved_request_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.approved_request_grid_view);
            this.Name = "Approved_request_form";
            this.Text = "Approved_request_form";
            this.Load += new System.EventHandler(this.Approved_request_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.approved_request_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView approved_request_grid_view;
    }
}