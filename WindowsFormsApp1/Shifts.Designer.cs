namespace WindowsFormsApp1
{
    partial class Shifts
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
            this.shiftslotsDD = new System.Windows.Forms.ComboBox();
            this.shiftNameTxt = new System.Windows.Forms.TextBox();
            this.shiftNumber_label = new System.Windows.Forms.Label();
            this.shiftName_label = new System.Windows.Forms.Label();
            this.shiftsloterror_label = new System.Windows.Forms.Label();
            this.shiftnameerror_Label = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(342, 726);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.shiftslotsDD);
            this.panel6.Controls.Add(this.shiftNameTxt);
            this.panel6.Controls.Add(this.shiftNumber_label);
            this.panel6.Controls.Add(this.shiftName_label);
            this.panel6.Controls.Add(this.shiftsloterror_label);
            this.panel6.Controls.Add(this.shiftnameerror_Label);
            this.panel6.Size = new System.Drawing.Size(342, 654);
            this.panel6.Controls.SetChildIndex(this.shiftnameerror_Label, 0);
            this.panel6.Controls.SetChildIndex(this.shiftsloterror_label, 0);
            this.panel6.Controls.SetChildIndex(this.shiftName_label, 0);
            this.panel6.Controls.SetChildIndex(this.shiftNumber_label, 0);
            this.panel6.Controls.SetChildIndex(this.shiftNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.shiftslotsDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1125, 726);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1125, 654);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1125, 72);
            // 
            // shiftslotsDD
            // 
            this.shiftslotsDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftslotsDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftslotsDD.FormattingEnabled = true;
            this.shiftslotsDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.shiftslotsDD.Location = new System.Drawing.Point(12, 174);
            this.shiftslotsDD.Name = "shiftslotsDD";
            this.shiftslotsDD.Size = new System.Drawing.Size(301, 29);
            this.shiftslotsDD.TabIndex = 77;
            this.shiftslotsDD.SelectedIndexChanged += new System.EventHandler(this.shiftslotsDD_SelectedIndexChanged);
            // 
            // shiftNameTxt
            // 
            this.shiftNameTxt.Location = new System.Drawing.Point(12, 105);
            this.shiftNameTxt.MaxLength = 30;
            this.shiftNameTxt.Name = "shiftNameTxt";
            this.shiftNameTxt.Size = new System.Drawing.Size(304, 29);
            this.shiftNameTxt.TabIndex = 76;
            this.shiftNameTxt.TextChanged += new System.EventHandler(this.shiftNameTxt_TextChanged);
            // 
            // shiftNumber_label
            // 
            this.shiftNumber_label.AutoSize = true;
            this.shiftNumber_label.Location = new System.Drawing.Point(8, 144);
            this.shiftNumber_label.Name = "shiftNumber_label";
            this.shiftNumber_label.Size = new System.Drawing.Size(84, 21);
            this.shiftNumber_label.TabIndex = 75;
            this.shiftNumber_label.Text = "Shift Slots";
            // 
            // shiftName_label
            // 
            this.shiftName_label.AutoSize = true;
            this.shiftName_label.Location = new System.Drawing.Point(8, 73);
            this.shiftName_label.Name = "shiftName_label";
            this.shiftName_label.Size = new System.Drawing.Size(91, 21);
            this.shiftName_label.TabIndex = 74;
            this.shiftName_label.Text = "Shift Name";
            // 
            // shiftsloterror_label
            // 
            this.shiftsloterror_label.AutoSize = true;
            this.shiftsloterror_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsloterror_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.shiftsloterror_label.Location = new System.Drawing.Point(291, 141);
            this.shiftsloterror_label.Name = "shiftsloterror_label";
            this.shiftsloterror_label.Size = new System.Drawing.Size(32, 41);
            this.shiftsloterror_label.TabIndex = 79;
            this.shiftsloterror_label.Text = "*";
            this.shiftsloterror_label.Visible = false;
            // 
            // shiftnameerror_Label
            // 
            this.shiftnameerror_Label.AutoSize = true;
            this.shiftnameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftnameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.shiftnameerror_Label.Location = new System.Drawing.Point(294, 71);
            this.shiftnameerror_Label.Name = "shiftnameerror_Label";
            this.shiftnameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.shiftnameerror_Label.TabIndex = 78;
            this.shiftnameerror_Label.Text = "*";
            this.shiftnameerror_Label.Visible = false;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 726);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.Shifts_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox shiftslotsDD;
        private System.Windows.Forms.TextBox shiftNameTxt;
        private System.Windows.Forms.Label shiftNumber_label;
        private System.Windows.Forms.Label shiftName_label;
        private System.Windows.Forms.Label shiftsloterror_label;
        private System.Windows.Forms.Label shiftnameerror_Label;
    }
}