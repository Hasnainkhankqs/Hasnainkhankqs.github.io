namespace LibraryManagementSystem
{
    partial class User_dues_history_form
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
            this.dues_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dues_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // dues_grid_view
            // 
            this.dues_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dues_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dues_grid_view.Location = new System.Drawing.Point(0, 0);
            this.dues_grid_view.Name = "dues_grid_view";
            this.dues_grid_view.Size = new System.Drawing.Size(800, 450);
            this.dues_grid_view.TabIndex = 0;
            // 
            // User_dues_history_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dues_grid_view);
            this.Name = "User_dues_history_form";
            this.Text = "User_dues_history_form";
            this.Load += new System.EventHandler(this.User_dues_history_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dues_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dues_grid_view;
    }
}