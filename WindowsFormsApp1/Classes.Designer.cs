namespace WindowsFormsApp1
{
    partial class Classes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.standardName_label = new System.Windows.Forms.Label();
            this.section_label = new System.Windows.Forms.Label();
            this.standardNameTxt = new System.Windows.Forms.TextBox();
            this.sectionDD = new System.Windows.Forms.ComboBox();
            this.addclass_Btn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.nameerror_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(342, 727);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listBox);
            this.panel6.Controls.Add(this.addclass_Btn);
            this.panel6.Controls.Add(this.sectionDD);
            this.panel6.Controls.Add(this.standardNameTxt);
            this.panel6.Controls.Add(this.section_label);
            this.panel6.Controls.Add(this.standardName_label);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.nameerror_Label);
            this.panel6.Size = new System.Drawing.Size(342, 655);
            this.panel6.Controls.SetChildIndex(this.nameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.standardName_label, 0);
            this.panel6.Controls.SetChildIndex(this.section_label, 0);
            this.panel6.Controls.SetChildIndex(this.standardNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.sectionDD, 0);
            this.panel6.Controls.SetChildIndex(this.addclass_Btn, 0);
            this.panel6.Controls.SetChildIndex(this.listBox, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1139, 727);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Size = new System.Drawing.Size(1139, 655);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1139, 72);
            // 
            // standardName_label
            // 
            this.standardName_label.AutoSize = true;
            this.standardName_label.Location = new System.Drawing.Point(8, 68);
            this.standardName_label.Name = "standardName_label";
            this.standardName_label.Size = new System.Drawing.Size(123, 21);
            this.standardName_label.TabIndex = 1;
            this.standardName_label.Text = "Standard Name";
            // 
            // section_label
            // 
            this.section_label.AutoSize = true;
            this.section_label.Location = new System.Drawing.Point(8, 139);
            this.section_label.Name = "section_label";
            this.section_label.Size = new System.Drawing.Size(65, 21);
            this.section_label.TabIndex = 2;
            this.section_label.Text = "Section";
            // 
            // standardNameTxt
            // 
            this.standardNameTxt.Location = new System.Drawing.Point(12, 100);
            this.standardNameTxt.MaxLength = 30;
            this.standardNameTxt.Name = "standardNameTxt";
            this.standardNameTxt.Size = new System.Drawing.Size(304, 29);
            this.standardNameTxt.TabIndex = 5;
            // 
            // sectionDD
            // 
            this.sectionDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionDD.FormattingEnabled = true;
            this.sectionDD.Location = new System.Drawing.Point(12, 169);
            this.sectionDD.Name = "sectionDD";
            this.sectionDD.Size = new System.Drawing.Size(301, 29);
            this.sectionDD.TabIndex = 58;
            // 
            // addclass_Btn
            // 
            this.addclass_Btn.BackColor = System.Drawing.Color.DarkGreen;
            this.addclass_Btn.FlatAppearance.BorderSize = 2;
            this.addclass_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addclass_Btn.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addclass_Btn.Location = new System.Drawing.Point(12, 216);
            this.addclass_Btn.Name = "addclass_Btn";
            this.addclass_Btn.Size = new System.Drawing.Size(300, 50);
            this.addclass_Btn.TabIndex = 64;
            this.addclass_Btn.Text = "ADD";
            this.addclass_Btn.UseVisualStyleBackColor = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 21;
            this.listBox.Location = new System.Drawing.Point(13, 276);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(300, 130);
            this.listBox.TabIndex = 65;
            // 
            // nameerror_Label
            // 
            this.nameerror_Label.AutoSize = true;
            this.nameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.nameerror_Label.Location = new System.Drawing.Point(294, 66);
            this.nameerror_Label.Name = "nameerror_Label";
            this.nameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.nameerror_Label.TabIndex = 66;
            this.nameerror_Label.Text = "*";
            this.nameerror_Label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(291, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 41);
            this.label2.TabIndex = 67;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1139, 575);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.roleIdGV,
            this.RoleGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.MinimumWidth = 8;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 89;
            // 
            // roleIdGV
            // 
            this.roleIdGV.HeaderText = "Role ID";
            this.roleIdGV.MinimumWidth = 8;
            this.roleIdGV.Name = "roleIdGV";
            this.roleIdGV.ReadOnly = true;
            this.roleIdGV.Visible = false;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.MinimumWidth = 8;
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 8;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 727);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Classes";
            this.Text = "Classes";
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label section_label;
        private System.Windows.Forms.Label standardName_label;
        private System.Windows.Forms.TextBox standardNameTxt;
        private System.Windows.Forms.ComboBox sectionDD;
        private System.Windows.Forms.Button addclass_Btn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameerror_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}