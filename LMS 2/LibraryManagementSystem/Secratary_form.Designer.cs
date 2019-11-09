namespace LibraryManagementSystem
{
    partial class Secratary_form
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
            this.Category_combo = new System.Windows.Forms.ComboBox();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.insert_item_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.secratray_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Update_btn = new System.Windows.Forms.Button();
            this.quantity_update_txt = new System.Windows.Forms.TextBox();
            this.item_nam_txt = new System.Windows.Forms.TextBox();
            this.finished_gridview = new System.Windows.Forms.DataGridView();
            this.item_id_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finished_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_combo
            // 
            this.Category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_combo.FormattingEnabled = true;
            this.Category_combo.Location = new System.Drawing.Point(91, 19);
            this.Category_combo.Name = "Category_combo";
            this.Category_combo.Size = new System.Drawing.Size(121, 21);
            this.Category_combo.TabIndex = 0;
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(112, 72);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.Size = new System.Drawing.Size(100, 20);
            this.item_name_txt.TabIndex = 1;
            // 
            // insert_item_btn
            // 
            this.insert_item_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insert_item_btn.Location = new System.Drawing.Point(137, 164);
            this.insert_item_btn.Name = "insert_item_btn";
            this.insert_item_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_item_btn.TabIndex = 2;
            this.insert_item_btn.Text = "Add Item";
            this.insert_item_btn.UseVisualStyleBackColor = true;
            this.insert_item_btn.Click += new System.EventHandler(this.Insert_item_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome Secratary";
            // 
            // secratray_lbl
            // 
            this.secratray_lbl.AutoSize = true;
            this.secratray_lbl.Location = new System.Drawing.Point(522, 9);
            this.secratray_lbl.Name = "secratray_lbl";
            this.secratray_lbl.Size = new System.Drawing.Size(64, 13);
            this.secratray_lbl.TabIndex = 4;
            this.secratray_lbl.Text = "Changeable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secratary Form";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(154, 118);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(58, 20);
            this.quantity_txt.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Category_combo);
            this.groupBox1.Controls.Add(this.quantity_txt);
            this.groupBox1.Controls.Add(this.item_name_txt);
            this.groupBox1.Controls.Add(this.insert_item_btn);
            this.groupBox1.Location = new System.Drawing.Point(716, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantitiy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.item_id_lbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Update_btn);
            this.groupBox2.Controls.Add(this.quantity_update_txt);
            this.groupBox2.Controls.Add(this.item_nam_txt);
            this.groupBox2.Location = new System.Drawing.Point(716, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 214);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quantitiy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item Name";
            // 
            // Update_btn
            // 
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_btn.Location = new System.Drawing.Point(137, 156);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 10;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // quantity_update_txt
            // 
            this.quantity_update_txt.Location = new System.Drawing.Point(152, 109);
            this.quantity_update_txt.Name = "quantity_update_txt";
            this.quantity_update_txt.Size = new System.Drawing.Size(60, 20);
            this.quantity_update_txt.TabIndex = 1;
            // 
            // item_nam_txt
            // 
            this.item_nam_txt.Location = new System.Drawing.Point(112, 61);
            this.item_nam_txt.Name = "item_nam_txt";
            this.item_nam_txt.Size = new System.Drawing.Size(100, 20);
            this.item_nam_txt.TabIndex = 0;
            // 
            // finished_gridview
            // 
            this.finished_gridview.AllowUserToOrderColumns = true;
            this.finished_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finished_gridview.Location = new System.Drawing.Point(18, 83);
            this.finished_gridview.Name = "finished_gridview";
            this.finished_gridview.Size = new System.Drawing.Size(619, 328);
            this.finished_gridview.TabIndex = 7;
            this.finished_gridview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Finished_gridview_RowHeaderMouseClick);
            // 
            // item_id_lbl
            // 
            this.item_id_lbl.AutoSize = true;
            this.item_id_lbl.Location = new System.Drawing.Point(176, 42);
            this.item_id_lbl.Name = "item_id_lbl";
            this.item_id_lbl.Size = new System.Drawing.Size(40, 13);
            this.item_id_lbl.TabIndex = 11;
            this.item_id_lbl.Text = "item_id";
            this.item_id_lbl.Visible = false;
            // 
            // Secratary_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(989, 458);
            this.Controls.Add(this.finished_gridview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secratray_lbl);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Secratary_form";
            this.Text = "Secratary_form";
            this.Load += new System.EventHandler(this.Secratary_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finished_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Category_combo;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.Button insert_item_btn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label secratray_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.TextBox quantity_update_txt;
        private System.Windows.Forms.TextBox item_nam_txt;
        private System.Windows.Forms.DataGridView finished_gridview;
        private System.Windows.Forms.Label item_id_lbl;
    }
}