namespace WindowsFormsApp1
{
    partial class ClassTimings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timingNameTxt = new System.Windows.Forms.TextBox();
            this.timingName_label = new System.Windows.Forms.Label();
            this.timingnameerror_Label = new System.Windows.Forms.Label();
            this.startclass_label = new System.Windows.Forms.Label();
            this.classstart_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.endclass_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.endclass_label = new System.Windows.Forms.Label();
            this.dayDD = new System.Windows.Forms.ComboBox();
            this.day_label = new System.Windows.Forms.Label();
            this.dayerror_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classError_Label = new System.Windows.Forms.Label();
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
            this.search_Txtbox.Size = new System.Drawing.Size(118, 23);
            // 
            // leftpanel
            // 
            this.leftpanel.Margin = new System.Windows.Forms.Padding(1);
            this.leftpanel.Size = new System.Drawing.Size(228, 448);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.classDD);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.dayDD);
            this.panel6.Controls.Add(this.day_label);
            this.panel6.Controls.Add(this.dayerror_label);
            this.panel6.Controls.Add(this.endclass_TimePicker);
            this.panel6.Controls.Add(this.endclass_label);
            this.panel6.Controls.Add(this.classstart_TimePicker);
            this.panel6.Controls.Add(this.startclass_label);
            this.panel6.Controls.Add(this.timingNameTxt);
            this.panel6.Controls.Add(this.timingnameerror_Label);
            this.panel6.Controls.Add(this.timingName_label);
            this.panel6.Controls.Add(this.classError_Label);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(228, 376);
            this.panel6.Controls.SetChildIndex(this.classError_Label, 0);
            this.panel6.Controls.SetChildIndex(this.timingName_label, 0);
            this.panel6.Controls.SetChildIndex(this.timingnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.timingNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.startclass_label, 0);
            this.panel6.Controls.SetChildIndex(this.classstart_TimePicker, 0);
            this.panel6.Controls.SetChildIndex(this.endclass_label, 0);
            this.panel6.Controls.SetChildIndex(this.endclass_TimePicker, 0);
            this.panel6.Controls.SetChildIndex(this.dayerror_label, 0);
            this.panel6.Controls.SetChildIndex(this.day_label, 0);
            this.panel6.Controls.SetChildIndex(this.dayDD, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.classDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Margin = new System.Windows.Forms.Padding(1);
            this.rightpanel.Size = new System.Drawing.Size(731, 448);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(731, 403);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(731, 45);
            // 
            // timingNameTxt
            // 
            this.timingNameTxt.Location = new System.Drawing.Point(8, 71);
            this.timingNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.timingNameTxt.MaxLength = 30;
            this.timingNameTxt.Name = "timingNameTxt";
            this.timingNameTxt.Size = new System.Drawing.Size(204, 22);
            this.timingNameTxt.TabIndex = 76;
            this.timingNameTxt.TextChanged += new System.EventHandler(this.timingNameTxt_TextChanged);
            // 
            // timingName_label
            // 
            this.timingName_label.AutoSize = true;
            this.timingName_label.Location = new System.Drawing.Point(5, 51);
            this.timingName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timingName_label.Name = "timingName_label";
            this.timingName_label.Size = new System.Drawing.Size(100, 13);
            this.timingName_label.TabIndex = 74;
            this.timingName_label.Text = "Slot/Timing Name";
            // 
            // timingnameerror_Label
            // 
            this.timingnameerror_Label.AutoSize = true;
            this.timingnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timingnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.timingnameerror_Label.Location = new System.Drawing.Point(196, 50);
            this.timingnameerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timingnameerror_Label.Name = "timingnameerror_Label";
            this.timingnameerror_Label.Size = new System.Drawing.Size(21, 28);
            this.timingnameerror_Label.TabIndex = 78;
            this.timingnameerror_Label.Text = "*";
            this.timingnameerror_Label.Visible = false;
            // 
            // startclass_label
            // 
            this.startclass_label.AutoSize = true;
            this.startclass_label.Location = new System.Drawing.Point(4, 97);
            this.startclass_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startclass_label.Name = "startclass_label";
            this.startclass_label.Size = new System.Drawing.Size(59, 13);
            this.startclass_label.TabIndex = 80;
            this.startclass_label.Text = "Start Time";
            // 
            // classstart_TimePicker
            // 
            this.classstart_TimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.classstart_TimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.classstart_TimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.classstart_TimePicker.CustomFormat = "h:mm tt";
            this.classstart_TimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classstart_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.classstart_TimePicker.Location = new System.Drawing.Point(8, 116);
            this.classstart_TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.classstart_TimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.classstart_TimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.classstart_TimePicker.Name = "classstart_TimePicker";
            this.classstart_TimePicker.ShowUpDown = true;
            this.classstart_TimePicker.Size = new System.Drawing.Size(201, 23);
            this.classstart_TimePicker.TabIndex = 83;
            // 
            // endclass_TimePicker
            // 
            this.endclass_TimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.endclass_TimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.endclass_TimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.endclass_TimePicker.CustomFormat = "h:mm tt";
            this.endclass_TimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endclass_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endclass_TimePicker.Location = new System.Drawing.Point(7, 159);
            this.endclass_TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endclass_TimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.endclass_TimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.endclass_TimePicker.Name = "endclass_TimePicker";
            this.endclass_TimePicker.ShowUpDown = true;
            this.endclass_TimePicker.Size = new System.Drawing.Size(201, 23);
            this.endclass_TimePicker.TabIndex = 86;
            // 
            // endclass_label
            // 
            this.endclass_label.AutoSize = true;
            this.endclass_label.Location = new System.Drawing.Point(5, 144);
            this.endclass_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endclass_label.Name = "endclass_label";
            this.endclass_label.Size = new System.Drawing.Size(54, 13);
            this.endclass_label.TabIndex = 84;
            this.endclass_label.Text = "End Time";
            // 
            // dayDD
            // 
            this.dayDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayDD.FormattingEnabled = true;
            this.dayDD.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayDD.Location = new System.Drawing.Point(8, 204);
            this.dayDD.Margin = new System.Windows.Forms.Padding(2);
            this.dayDD.Name = "dayDD";
            this.dayDD.Size = new System.Drawing.Size(202, 21);
            this.dayDD.TabIndex = 88;
            this.dayDD.SelectedIndexChanged += new System.EventHandler(this.dayDD_SelectedIndexChanged);
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Location = new System.Drawing.Point(5, 186);
            this.day_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(27, 13);
            this.day_label.TabIndex = 87;
            this.day_label.Text = "Day";
            // 
            // dayerror_label
            // 
            this.dayerror_label.AutoSize = true;
            this.dayerror_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayerror_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.dayerror_label.Location = new System.Drawing.Point(194, 183);
            this.dayerror_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayerror_label.Name = "dayerror_label";
            this.dayerror_label.Size = new System.Drawing.Size(21, 28);
            this.dayerror_label.TabIndex = 89;
            this.dayerror_label.Text = "*";
            this.dayerror_label.Visible = false;
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
            this.groupBox2.Size = new System.Drawing.Size(731, 353);
            this.groupBox2.TabIndex = 4;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.classIDGV,
            this.classNameGV,
            this.startGV,
            this.endGV,
            this.dayGV,
            this.tIdGV,
            this.timingNameGV});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(727, 331);
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
            this.classIDGV.HeaderText = "classID";
            this.classIDGV.Name = "classIDGV";
            this.classIDGV.ReadOnly = true;
            this.classIDGV.Visible = false;
            // 
            // classNameGV
            // 
            this.classNameGV.HeaderText = "Class Name";
            this.classNameGV.Name = "classNameGV";
            this.classNameGV.ReadOnly = true;
            // 
            // startGV
            // 
            this.startGV.HeaderText = "Start Timing";
            this.startGV.Name = "startGV";
            this.startGV.ReadOnly = true;
            // 
            // endGV
            // 
            this.endGV.HeaderText = "Ending Time";
            this.endGV.Name = "endGV";
            this.endGV.ReadOnly = true;
            // 
            // dayGV
            // 
            this.dayGV.HeaderText = "Days";
            this.dayGV.Name = "dayGV";
            this.dayGV.ReadOnly = true;
            // 
            // tIdGV
            // 
            this.tIdGV.HeaderText = "TimingIDGV";
            this.tIdGV.Name = "tIdGV";
            this.tIdGV.ReadOnly = true;
            this.tIdGV.Visible = false;
            // 
            // timingNameGV
            // 
            this.timingNameGV.HeaderText = "Timing Name";
            this.timingNameGV.Name = "timingNameGV";
            this.timingNameGV.ReadOnly = true;
            // 
            // classDD
            // 
            this.classDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDD.FormattingEnabled = true;
            this.classDD.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.classDD.Location = new System.Drawing.Point(7, 245);
            this.classDD.Margin = new System.Windows.Forms.Padding(2);
            this.classDD.Name = "classDD";
            this.classDD.Size = new System.Drawing.Size(202, 21);
            this.classDD.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Class";
            // 
            // classError_Label
            // 
            this.classError_Label.AutoSize = true;
            this.classError_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classError_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.classError_Label.Location = new System.Drawing.Point(193, 223);
            this.classError_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classError_Label.Name = "classError_Label";
            this.classError_Label.Size = new System.Drawing.Size(21, 28);
            this.classError_Label.TabIndex = 92;
            this.classError_Label.Text = "*";
            this.classError_Label.Visible = false;
            // 
            // ClassTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 448);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ClassTimings";
            this.Text = "ClassTimings";
            this.Load += new System.EventHandler(this.ClassTimings_Load);
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
        private System.Windows.Forms.TextBox timingNameTxt;
        private System.Windows.Forms.Label timingnameerror_Label;
        private System.Windows.Forms.Label timingName_label;
        private System.Windows.Forms.Label startclass_label;
        private System.Windows.Forms.DateTimePicker classstart_TimePicker;
        private System.Windows.Forms.DateTimePicker endclass_TimePicker;
        private System.Windows.Forms.Label endclass_label;
        private System.Windows.Forms.ComboBox dayDD;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label dayerror_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox classDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label classError_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn startGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn endGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingNameGV;
    }
}