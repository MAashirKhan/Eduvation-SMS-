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
            this.timeshiftDD = new System.Windows.Forms.ComboBox();
            this.timingNameTxt = new System.Windows.Forms.TextBox();
            this.timeShift_label = new System.Windows.Forms.Label();
            this.timingName_label = new System.Windows.Forms.Label();
            this.timeshifterror_label = new System.Windows.Forms.Label();
            this.timingnameerror_Label = new System.Windows.Forms.Label();
            this.startclass_label = new System.Windows.Forms.Label();
            this.classstart_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.endclass_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.endclass_label = new System.Windows.Forms.Label();
            this.dayDD = new System.Windows.Forms.ComboBox();
            this.day_label = new System.Windows.Forms.Label();
            this.dayerror_label = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(342, 724);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dayDD);
            this.panel6.Controls.Add(this.day_label);
            this.panel6.Controls.Add(this.dayerror_label);
            this.panel6.Controls.Add(this.endclass_TimePicker);
            this.panel6.Controls.Add(this.endclass_label);
            this.panel6.Controls.Add(this.classstart_TimePicker);
            this.panel6.Controls.Add(this.startclass_label);
            this.panel6.Controls.Add(this.timeshiftDD);
            this.panel6.Controls.Add(this.timingNameTxt);
            this.panel6.Controls.Add(this.timeShift_label);
            this.panel6.Controls.Add(this.timingnameerror_Label);
            this.panel6.Controls.Add(this.timingName_label);
            this.panel6.Controls.Add(this.timeshifterror_label);
            this.panel6.Size = new System.Drawing.Size(342, 652);
            this.panel6.Controls.SetChildIndex(this.timeshifterror_label, 0);
            this.panel6.Controls.SetChildIndex(this.timingName_label, 0);
            this.panel6.Controls.SetChildIndex(this.timingnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.timeShift_label, 0);
            this.panel6.Controls.SetChildIndex(this.timingNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.timeshiftDD, 0);
            this.panel6.Controls.SetChildIndex(this.startclass_label, 0);
            this.panel6.Controls.SetChildIndex(this.classstart_TimePicker, 0);
            this.panel6.Controls.SetChildIndex(this.endclass_label, 0);
            this.panel6.Controls.SetChildIndex(this.endclass_TimePicker, 0);
            this.panel6.Controls.SetChildIndex(this.dayerror_label, 0);
            this.panel6.Controls.SetChildIndex(this.day_label, 0);
            this.panel6.Controls.SetChildIndex(this.dayDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1096, 724);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1096, 652);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1096, 72);
            // 
            // timeshiftDD
            // 
            this.timeshiftDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeshiftDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeshiftDD.FormattingEnabled = true;
            this.timeshiftDD.Location = new System.Drawing.Point(12, 183);
            this.timeshiftDD.Name = "timeshiftDD";
            this.timeshiftDD.Size = new System.Drawing.Size(301, 29);
            this.timeshiftDD.TabIndex = 77;
            this.timeshiftDD.SelectedIndexChanged += new System.EventHandler(this.timeshiftDD_SelectedIndexChanged);
            // 
            // timingNameTxt
            // 
            this.timingNameTxt.Location = new System.Drawing.Point(12, 114);
            this.timingNameTxt.MaxLength = 30;
            this.timingNameTxt.Name = "timingNameTxt";
            this.timingNameTxt.Size = new System.Drawing.Size(304, 29);
            this.timingNameTxt.TabIndex = 76;
            this.timingNameTxt.TextChanged += new System.EventHandler(this.timingNameTxt_TextChanged);
            // 
            // timeShift_label
            // 
            this.timeShift_label.AutoSize = true;
            this.timeShift_label.Location = new System.Drawing.Point(8, 153);
            this.timeShift_label.Name = "timeShift_label";
            this.timeShift_label.Size = new System.Drawing.Size(98, 21);
            this.timeShift_label.TabIndex = 75;
            this.timeShift_label.Text = "Timing Shift";
            // 
            // timingName_label
            // 
            this.timingName_label.AutoSize = true;
            this.timingName_label.Location = new System.Drawing.Point(8, 82);
            this.timingName_label.Name = "timingName_label";
            this.timingName_label.Size = new System.Drawing.Size(143, 21);
            this.timingName_label.TabIndex = 74;
            this.timingName_label.Text = "Slot/Timing Name";
            // 
            // timeshifterror_label
            // 
            this.timeshifterror_label.AutoSize = true;
            this.timeshifterror_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeshifterror_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.timeshifterror_label.Location = new System.Drawing.Point(291, 150);
            this.timeshifterror_label.Name = "timeshifterror_label";
            this.timeshifterror_label.Size = new System.Drawing.Size(32, 41);
            this.timeshifterror_label.TabIndex = 79;
            this.timeshifterror_label.Text = "*";
            this.timeshifterror_label.Visible = false;
            // 
            // timingnameerror_Label
            // 
            this.timingnameerror_Label.AutoSize = true;
            this.timingnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timingnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.timingnameerror_Label.Location = new System.Drawing.Point(294, 80);
            this.timingnameerror_Label.Name = "timingnameerror_Label";
            this.timingnameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.timingnameerror_Label.TabIndex = 78;
            this.timingnameerror_Label.Text = "*";
            this.timingnameerror_Label.Visible = false;
            // 
            // startclass_label
            // 
            this.startclass_label.AutoSize = true;
            this.startclass_label.Location = new System.Drawing.Point(8, 230);
            this.startclass_label.Name = "startclass_label";
            this.startclass_label.Size = new System.Drawing.Size(85, 21);
            this.startclass_label.TabIndex = 80;
            this.startclass_label.Text = "Start Time";
            // 
            // classstart_TimePicker
            // 
            this.classstart_TimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.classstart_TimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.classstart_TimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.classstart_TimePicker.CustomFormat = "";
            this.classstart_TimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classstart_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.classstart_TimePicker.Location = new System.Drawing.Point(13, 260);
            this.classstart_TimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.classstart_TimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.classstart_TimePicker.Name = "classstart_TimePicker";
            this.classstart_TimePicker.ShowUpDown = true;
            this.classstart_TimePicker.Size = new System.Drawing.Size(299, 31);
            this.classstart_TimePicker.TabIndex = 83;
            // 
            // endclass_TimePicker
            // 
            this.endclass_TimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.endclass_TimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.endclass_TimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.endclass_TimePicker.CustomFormat = "";
            this.endclass_TimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endclass_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endclass_TimePicker.Location = new System.Drawing.Point(12, 330);
            this.endclass_TimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.endclass_TimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.endclass_TimePicker.Name = "endclass_TimePicker";
            this.endclass_TimePicker.ShowUpDown = true;
            this.endclass_TimePicker.Size = new System.Drawing.Size(299, 31);
            this.endclass_TimePicker.TabIndex = 86;
            // 
            // endclass_label
            // 
            this.endclass_label.AutoSize = true;
            this.endclass_label.Location = new System.Drawing.Point(9, 306);
            this.endclass_label.Name = "endclass_label";
            this.endclass_label.Size = new System.Drawing.Size(77, 21);
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
            this.dayDD.Location = new System.Drawing.Point(13, 407);
            this.dayDD.Name = "dayDD";
            this.dayDD.Size = new System.Drawing.Size(301, 29);
            this.dayDD.TabIndex = 88;
            this.dayDD.SelectedIndexChanged += new System.EventHandler(this.dayDD_SelectedIndexChanged);
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Location = new System.Drawing.Point(9, 377);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(37, 21);
            this.day_label.TabIndex = 87;
            this.day_label.Text = "Day";
            // 
            // dayerror_label
            // 
            this.dayerror_label.AutoSize = true;
            this.dayerror_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayerror_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.dayerror_label.Location = new System.Drawing.Point(292, 374);
            this.dayerror_label.Name = "dayerror_label";
            this.dayerror_label.Size = new System.Drawing.Size(32, 41);
            this.dayerror_label.TabIndex = 89;
            this.dayerror_label.Text = "*";
            this.dayerror_label.Visible = false;
            // 
            // ClassTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 724);
            this.Name = "ClassTimings";
            this.Text = "ClassTimings";
            this.Load += new System.EventHandler(this.ClassTimings_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox timeshiftDD;
        private System.Windows.Forms.TextBox timingNameTxt;
        private System.Windows.Forms.Label timeShift_label;
        private System.Windows.Forms.Label timingnameerror_Label;
        private System.Windows.Forms.Label timingName_label;
        private System.Windows.Forms.Label timeshifterror_label;
        private System.Windows.Forms.Label startclass_label;
        private System.Windows.Forms.DateTimePicker classstart_TimePicker;
        private System.Windows.Forms.DateTimePicker endclass_TimePicker;
        private System.Windows.Forms.Label endclass_label;
        private System.Windows.Forms.ComboBox dayDD;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label dayerror_label;
    }
}