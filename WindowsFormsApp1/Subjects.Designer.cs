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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subjectname_label = new System.Windows.Forms.Label();
            this.subjectNameTxt = new System.Windows.Forms.TextBox();
            this.subjectnameerror_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.classDD = new System.Windows.Forms.ComboBox();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_Txtbox
            // 
            this.search_Txtbox.Margin = new System.Windows.Forms.Padding(1);
            this.search_Txtbox.Size = new System.Drawing.Size(122, 23);
            // 
            // leftpanel
            // 
            this.leftpanel.Margin = new System.Windows.Forms.Padding(1);
            this.leftpanel.Size = new System.Drawing.Size(228, 452);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.classDD);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.subjectname_label);
            this.panel6.Controls.Add(this.subjectNameTxt);
            this.panel6.Controls.Add(this.subjectnameerror_Label);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(228, 380);
            this.panel6.Controls.SetChildIndex(this.subjectnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.subjectNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.subjectname_label, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.classDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Margin = new System.Windows.Forms.Padding(1);
            this.rightpanel.Size = new System.Drawing.Size(765, 452);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(765, 407);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(765, 45);
            // 
            // subjectname_label
            // 
            this.subjectname_label.AutoSize = true;
            this.subjectname_label.Location = new System.Drawing.Point(11, 52);
            this.subjectname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectname_label.Name = "subjectname_label";
            this.subjectname_label.Size = new System.Drawing.Size(117, 13);
            this.subjectname_label.TabIndex = 2;
            this.subjectname_label.Text = "Subject/Course Name";
            // 
            // subjectNameTxt
            // 
            this.subjectNameTxt.Enabled = false;
            this.subjectNameTxt.Location = new System.Drawing.Point(14, 70);
            this.subjectNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.subjectNameTxt.MaxLength = 50;
            this.subjectNameTxt.Name = "subjectNameTxt";
            this.subjectNameTxt.Size = new System.Drawing.Size(198, 22);
            this.subjectNameTxt.TabIndex = 1;
            this.subjectNameTxt.TextChanged += new System.EventHandler(this.subjectNameTxt_TextChanged);
            // 
            // subjectnameerror_Label
            // 
            this.subjectnameerror_Label.AutoSize = true;
            this.subjectnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.subjectnameerror_Label.Location = new System.Drawing.Point(196, 50);
            this.subjectnameerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectnameerror_Label.Name = "subjectnameerror_Label";
            this.subjectnameerror_Label.Size = new System.Drawing.Size(21, 28);
            this.subjectnameerror_Label.TabIndex = 67;
            this.subjectnameerror_Label.Text = "*";
            this.subjectnameerror_Label.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(765, 357);
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
            this.classidGV,
            this.SubjectNameGV,
            this.SubjectIDGV,
            this.ClassGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(761, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Class it belongs";
            // 
            // classDD
            // 
            this.classDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classDD.FormattingEnabled = true;
            this.classDD.Location = new System.Drawing.Point(14, 113);
            this.classDD.Name = "classDD";
            this.classDD.Size = new System.Drawing.Size(195, 21);
            this.classDD.TabIndex = 69;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.MinimumWidth = 8;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 64;
            // 
            // classidGV
            // 
            this.classidGV.HeaderText = "ClassID";
            this.classidGV.Name = "classidGV";
            this.classidGV.ReadOnly = true;
            this.classidGV.Visible = false;
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
            // ClassGV
            // 
            this.ClassGV.HeaderText = "Class";
            this.ClassGV.Name = "ClassGV";
            this.ClassGV.ReadOnly = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 452);
            this.Margin = new System.Windows.Forms.Padding(1);
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
        private System.Windows.Forms.ComboBox classDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassGV;
    }
}