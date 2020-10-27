namespace WindowsFormsApp1
{
    partial class Subjects
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
            this.subjectname_label = new System.Windows.Forms.Label();
            this.subjectNameTxt = new System.Windows.Forms.TextBox();
            this.subjectnameerror_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.leftpanel.Size = new System.Drawing.Size(342, 730);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.subjectname_label);
            this.panel6.Controls.Add(this.subjectNameTxt);
            this.panel6.Controls.Add(this.subjectnameerror_Label);
            this.panel6.Size = new System.Drawing.Size(342, 658);
            this.panel6.Controls.SetChildIndex(this.subjectnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.subjectNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.subjectname_label, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1147, 730);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Size = new System.Drawing.Size(1147, 658);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1147, 72);
            // 
            // subjectname_label
            // 
            this.subjectname_label.AutoSize = true;
            this.subjectname_label.Location = new System.Drawing.Point(17, 84);
            this.subjectname_label.Name = "subjectname_label";
            this.subjectname_label.Size = new System.Drawing.Size(170, 21);
            this.subjectname_label.TabIndex = 2;
            this.subjectname_label.Text = "Subject/Course Name";
            // 
            // subjectNameTxt
            // 
            this.subjectNameTxt.Location = new System.Drawing.Point(21, 113);
            this.subjectNameTxt.MaxLength = 50;
            this.subjectNameTxt.Name = "subjectNameTxt";
            this.subjectNameTxt.Size = new System.Drawing.Size(295, 29);
            this.subjectNameTxt.TabIndex = 1;
            this.subjectNameTxt.TextChanged += new System.EventHandler(this.subjectNameTxt_TextChanged);
            // 
            // subjectnameerror_Label
            // 
            this.subjectnameerror_Label.AutoSize = true;
            this.subjectnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.subjectnameerror_Label.Location = new System.Drawing.Point(294, 80);
            this.subjectnameerror_Label.Name = "subjectnameerror_Label";
            this.subjectnameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.subjectnameerror_Label.TabIndex = 67;
            this.subjectnameerror_Label.Text = "*";
            this.subjectnameerror_Label.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 578);
            this.groupBox2.TabIndex = 3;
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
            this.SubjectNameGV,
            this.SubjectIDGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 545);
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
            // SubjectNameGV
            // 
            this.SubjectNameGV.HeaderText = "Subject/Course Name";
            this.SubjectNameGV.MinimumWidth = 8;
            this.SubjectNameGV.Name = "SubjectNameGV";
            this.SubjectNameGV.ReadOnly = true;
            // 
            // SubjectIDGV
            // 
            this.SubjectIDGV.HeaderText = "SubjectID";
            this.SubjectIDGV.MinimumWidth = 8;
            this.SubjectIDGV.Name = "SubjectIDGV";
            this.SubjectIDGV.ReadOnly = true;
            this.SubjectIDGV.Visible = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 730);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
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

        private System.Windows.Forms.Label subjectname_label;
        private System.Windows.Forms.TextBox subjectNameTxt;
        private System.Windows.Forms.Label subjectnameerror_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDGV;
    }
}