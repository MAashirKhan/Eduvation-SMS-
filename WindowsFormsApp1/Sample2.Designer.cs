namespace WindowsFormsApp1
{
    partial class Sample2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_Txtbox = new System.Windows.Forms.TextBox();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(342, 727);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(342, 658);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1150, 727);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Size = new System.Drawing.Size(1150, 658);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1150, 69);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 76);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.view_btn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.save_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.edit_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.add_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view_btn
            // 
            this.view_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_btn.FlatAppearance.BorderSize = 2;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.Location = new System.Drawing.Point(767, 3);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(185, 70);
            this.view_btn.TabIndex = 4;
            this.view_btn.Text = "VIEW";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_btn.FlatAppearance.BorderSize = 2;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(576, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(185, 70);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_btn.FlatAppearance.BorderSize = 2;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(385, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(185, 70);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_btn.FlatAppearance.BorderSize = 2;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(194, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(185, 70);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_btn.FlatAppearance.BorderSize = 2;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(185, 70);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_Txtbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(958, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // search_Txtbox
            // 
            this.search_Txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_Txtbox.Location = new System.Drawing.Point(3, 27);
            this.search_Txtbox.Name = "search_Txtbox";
            this.search_Txtbox.Size = new System.Drawing.Size(183, 31);
            this.search_Txtbox.TabIndex = 0;
            this.search_Txtbox.TextChanged += new System.EventHandler(this.search_Txtbox_TextChanged);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 727);
            this.ControlBox = false;
            this.Name = "Sample2";
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox search_Txtbox;
    }
}