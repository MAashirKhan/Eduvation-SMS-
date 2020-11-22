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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.standardName_label = new System.Windows.Forms.Label();
            this.standardNameTxt = new System.Windows.Forms.TextBox();
            this.standardnameerror_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.status_label = new System.Windows.Forms.Label();
            this.statuserror_label = new System.Windows.Forms.Label();
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
            this.search_Txtbox.Size = new System.Drawing.Size(123, 23);
            // 
            // leftpanel
            // 
            this.leftpanel.Margin = new System.Windows.Forms.Padding(1);
            this.leftpanel.Size = new System.Drawing.Size(228, 450);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusDD);
            this.panel6.Controls.Add(this.status_label);
            this.panel6.Controls.Add(this.statuserror_label);
            this.panel6.Controls.Add(this.standardNameTxt);
            this.panel6.Controls.Add(this.standardName_label);
            this.panel6.Controls.Add(this.standardnameerror_Label);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(228, 378);
            this.panel6.Controls.SetChildIndex(this.standardnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.standardName_label, 0);
            this.panel6.Controls.SetChildIndex(this.standardNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.statuserror_label, 0);
            this.panel6.Controls.SetChildIndex(this.status_label, 0);
            this.panel6.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Margin = new System.Windows.Forms.Padding(1);
            this.rightpanel.Size = new System.Drawing.Size(756, 450);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(756, 405);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(756, 45);
            // 
            // standardName_label
            // 
            this.standardName_label.AutoSize = true;
            this.standardName_label.Location = new System.Drawing.Point(5, 42);
            this.standardName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.standardName_label.Name = "standardName_label";
            this.standardName_label.Size = new System.Drawing.Size(86, 13);
            this.standardName_label.TabIndex = 1;
            this.standardName_label.Text = "Standard Name";
            // 
            // standardNameTxt
            // 
            this.standardNameTxt.Location = new System.Drawing.Point(8, 62);
            this.standardNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.standardNameTxt.MaxLength = 30;
            this.standardNameTxt.Name = "standardNameTxt";
            this.standardNameTxt.Size = new System.Drawing.Size(204, 22);
            this.standardNameTxt.TabIndex = 5;
            this.standardNameTxt.TextChanged += new System.EventHandler(this.standardNameTxt_TextChanged);
            // 
            // standardnameerror_Label
            // 
            this.standardnameerror_Label.AutoSize = true;
            this.standardnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.standardnameerror_Label.Location = new System.Drawing.Point(196, 41);
            this.standardnameerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.standardnameerror_Label.Name = "standardnameerror_Label";
            this.standardnameerror_Label.Size = new System.Drawing.Size(21, 28);
            this.standardnameerror_Label.TabIndex = 66;
            this.standardnameerror_Label.Text = "*";
            this.standardnameerror_Label.Visible = false;
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
            this.groupBox2.Size = new System.Drawing.Size(756, 355);
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
            this.classIDGV,
            this.StandardNameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // classIDGV
            // 
            this.classIDGV.HeaderText = "ClassID";
            this.classIDGV.MinimumWidth = 8;
            this.classIDGV.Name = "classIDGV";
            this.classIDGV.ReadOnly = true;
            this.classIDGV.Visible = false;
            // 
            // StandardNameGV
            // 
            this.StandardNameGV.HeaderText = "Standard Name";
            this.StandardNameGV.MinimumWidth = 8;
            this.StandardNameGV.Name = "StandardNameGV";
            this.StandardNameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.Enabled = false;
            this.statusDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(8, 109);
            this.statusDD.Margin = new System.Windows.Forms.Padding(2);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(202, 21);
            this.statusDD.TabIndex = 75;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(5, 91);
            this.status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(38, 13);
            this.status_label.TabIndex = 74;
            this.status_label.Text = "Status";
            // 
            // statuserror_label
            // 
            this.statuserror_label.AutoSize = true;
            this.statuserror_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserror_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.statuserror_label.Location = new System.Drawing.Point(194, 89);
            this.statuserror_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statuserror_label.Name = "statuserror_label";
            this.statuserror_label.Size = new System.Drawing.Size(21, 28);
            this.statuserror_label.TabIndex = 76;
            this.statuserror_label.Text = "*";
            this.statuserror_label.Visible = false;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
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
        private System.Windows.Forms.Label standardName_label;
        private System.Windows.Forms.TextBox standardNameTxt;
        private System.Windows.Forms.Label standardnameerror_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label statuserror_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}