namespace LibraryManagementSystem
{
    partial class login_form
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
            this.email_label = new System.Windows.Forms.Label();
            this.Login_group = new System.Windows.Forms.GroupBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.register_link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(23, 56);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email";
            // 
            // Login_group
            // 
            this.Login_group.BackColor = System.Drawing.SystemColors.GrayText;
            this.Login_group.Controls.Add(this.login_btn);
            this.Login_group.Controls.Add(this.register_link);
            this.Login_group.Controls.Add(this.password_txt);
            this.Login_group.Controls.Add(this.email_txt);
            this.Login_group.Controls.Add(this.password_label);
            this.Login_group.Controls.Add(this.email_label);
            this.Login_group.Location = new System.Drawing.Point(495, 56);
            this.Login_group.Name = "Login_group";
            this.Login_group.Size = new System.Drawing.Size(233, 200);
            this.Login_group.TabIndex = 1;
            this.Login_group.TabStop = false;
            this.Login_group.Text = "Login Info";
            this.Login_group.ForeColor = System.Drawing.Color.White;
            // 
            // login_btn
            // 
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(152, 156);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(127, 100);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(127, 49);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(23, 100);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // register_link
            // 
            this.register_link.AutoSize = true;
            this.register_link.Location = new System.Drawing.Point(75, 166);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(71, 13);
            this.register_link.TabIndex = 5;
            this.register_link.TabStop = true;
            this.register_link.Text = "Register Now";
            this.register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_link_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login From";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_group);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.Login_group.ResumeLayout(false);
            this.Login_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.GroupBox Login_group;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.LinkLabel register_link;
        private System.Windows.Forms.Label label3;
    }
}