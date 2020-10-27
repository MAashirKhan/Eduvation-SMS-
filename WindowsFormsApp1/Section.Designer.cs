namespace WindowsFormsApp1
{
    partial class Section
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
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.sectionNameTxt = new System.Windows.Forms.TextBox();
            this.status_label = new System.Windows.Forms.Label();
            this.sectionName_label = new System.Windows.Forms.Label();
            this.statuserror_label = new System.Windows.Forms.Label();
            this.sectionnameerror_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.leftpanel.Size = new System.Drawing.Size(342, 742);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusDD);
            this.panel6.Controls.Add(this.sectionNameTxt);
            this.panel6.Controls.Add(this.status_label);
            this.panel6.Controls.Add(this.sectionName_label);
            this.panel6.Controls.Add(this.statuserror_label);
            this.panel6.Controls.Add(this.sectionnameerror_Label);
            this.panel6.Size = new System.Drawing.Size(342, 670);
            this.panel6.Controls.SetChildIndex(this.sectionnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.statuserror_label, 0);
            this.panel6.Controls.SetChildIndex(this.sectionName_label, 0);
            this.panel6.Controls.SetChildIndex(this.status_label, 0);
            this.panel6.Controls.SetChildIndex(this.sectionNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1257, 742);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Size = new System.Drawing.Size(1257, 670);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1257, 72);
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(12, 178);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(301, 29);
            this.statusDD.TabIndex = 71;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // sectionNameTxt
            // 
            this.sectionNameTxt.Location = new System.Drawing.Point(12, 109);
            this.sectionNameTxt.MaxLength = 30;
            this.sectionNameTxt.Name = "sectionNameTxt";
            this.sectionNameTxt.Size = new System.Drawing.Size(304, 29);
            this.sectionNameTxt.TabIndex = 70;
            this.sectionNameTxt.TextChanged += new System.EventHandler(this.sectionNameTxt_TextChanged);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(8, 148);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(55, 21);
            this.status_label.TabIndex = 69;
            this.status_label.Text = "Status";
            // 
            // sectionName_label
            // 
            this.sectionName_label.AutoSize = true;
            this.sectionName_label.Location = new System.Drawing.Point(8, 77);
            this.sectionName_label.Name = "sectionName_label";
            this.sectionName_label.Size = new System.Drawing.Size(112, 21);
            this.sectionName_label.TabIndex = 68;
            this.sectionName_label.Text = "Section Name";
            // 
            // statuserror_label
            // 
            this.statuserror_label.AutoSize = true;
            this.statuserror_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserror_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.statuserror_label.Location = new System.Drawing.Point(291, 145);
            this.statuserror_label.Name = "statuserror_label";
            this.statuserror_label.Size = new System.Drawing.Size(32, 41);
            this.statuserror_label.TabIndex = 73;
            this.statuserror_label.Text = "*";
            this.statuserror_label.Visible = false;
            // 
            // sectionnameerror_Label
            // 
            this.sectionnameerror_Label.AutoSize = true;
            this.sectionnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.sectionnameerror_Label.Location = new System.Drawing.Point(294, 75);
            this.sectionnameerror_Label.Name = "sectionnameerror_Label";
            this.sectionnameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.sectionnameerror_Label.TabIndex = 72;
            this.sectionnameerror_Label.Text = "*";
            this.sectionnameerror_Label.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1257, 590);
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
            this.SectionNameGV,
            this.StatusGV,
            this.SectionIDGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 557);
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
            // SectionNameGV
            // 
            this.SectionNameGV.HeaderText = "Section Name";
            this.SectionNameGV.MinimumWidth = 8;
            this.SectionNameGV.Name = "SectionNameGV";
            this.SectionNameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 8;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // SectionIDGV
            // 
            this.SectionIDGV.HeaderText = "SectionID";
            this.SectionIDGV.MinimumWidth = 8;
            this.SectionIDGV.Name = "SectionIDGV";
            this.SectionIDGV.ReadOnly = true;
            this.SectionIDGV.Visible = false;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 742);
            this.Name = "Section";
            this.Text = "Section";
            this.Load += new System.EventHandler(this.Section_Load);
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

        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.TextBox sectionNameTxt;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label sectionName_label;
        private System.Windows.Forms.Label statuserror_label;
        private System.Windows.Forms.Label sectionnameerror_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionIDGV;
    }
}