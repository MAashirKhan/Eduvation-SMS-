namespace WindowsFormsApp1
{
    partial class FacultyDB
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.students_Btn = new System.Windows.Forms.Button();
            this.class_Btn = new System.Windows.Forms.Button();
            this.exams_Btn = new System.Windows.Forms.Button();
            this.timetable_Btn = new System.Windows.Forms.Button();
            this.results_Btn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(342, 617);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(342, 545);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(881, 617);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Size = new System.Drawing.Size(881, 545);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(881, 72);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.students_Btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.exams_Btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.class_Btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.timetable_Btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.results_Btn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.06579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.73684F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 545);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // students_Btn
            // 
            this.students_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.students_Btn.FlatAppearance.BorderSize = 3;
            this.students_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students_Btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.students_Btn.Image = global::WindowsFormsApp1.Properties.Resources.student;
            this.students_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.students_Btn.Location = new System.Drawing.Point(354, 2);
            this.students_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.students_Btn.Name = "students_Btn";
            this.students_Btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.students_Btn.Size = new System.Drawing.Size(172, 132);
            this.students_Btn.TabIndex = 3;
            this.students_Btn.Text = "Students";
            this.students_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.students_Btn.UseVisualStyleBackColor = true;
            // 
            // class_Btn
            // 
            this.class_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_Btn.FlatAppearance.BorderSize = 3;
            this.class_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class_Btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.class_Btn.Image = global::WindowsFormsApp1.Properties.Resources.classes;
            this.class_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.class_Btn.Location = new System.Drawing.Point(2, 2);
            this.class_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.class_Btn.Name = "class_Btn";
            this.class_Btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.class_Btn.Size = new System.Drawing.Size(172, 132);
            this.class_Btn.TabIndex = 1;
            this.class_Btn.Text = "Classes";
            this.class_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class_Btn.UseVisualStyleBackColor = true;
            // 
            // exams_Btn
            // 
            this.exams_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exams_Btn.FlatAppearance.BorderSize = 3;
            this.exams_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exams_Btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exams_Btn.Image = global::WindowsFormsApp1.Properties.Resources.exam;
            this.exams_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exams_Btn.Location = new System.Drawing.Point(530, 2);
            this.exams_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.exams_Btn.Name = "exams_Btn";
            this.exams_Btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.exams_Btn.Size = new System.Drawing.Size(172, 132);
            this.exams_Btn.TabIndex = 5;
            this.exams_Btn.Text = "Exams";
            this.exams_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exams_Btn.UseVisualStyleBackColor = true;
            // 
            // timetable_Btn
            // 
            this.timetable_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timetable_Btn.FlatAppearance.BorderSize = 3;
            this.timetable_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetable_Btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.timetable_Btn.Image = global::WindowsFormsApp1.Properties.Resources.timetable;
            this.timetable_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timetable_Btn.Location = new System.Drawing.Point(178, 2);
            this.timetable_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.timetable_Btn.Name = "timetable_Btn";
            this.timetable_Btn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.timetable_Btn.Size = new System.Drawing.Size(172, 132);
            this.timetable_Btn.TabIndex = 6;
            this.timetable_Btn.Text = "TimeTable";
            this.timetable_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timetable_Btn.UseVisualStyleBackColor = true;
            // 
            // results_Btn
            // 
            this.results_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results_Btn.FlatAppearance.BorderSize = 3;
            this.results_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.results_Btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.results_Btn.Image = global::WindowsFormsApp1.Properties.Resources.result;
            this.results_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.results_Btn.Location = new System.Drawing.Point(706, 2);
            this.results_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.results_Btn.Name = "results_Btn";
            this.results_Btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.results_Btn.Size = new System.Drawing.Size(173, 132);
            this.results_Btn.TabIndex = 10;
            this.results_Btn.Text = "Results";
            this.results_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.results_Btn.UseVisualStyleBackColor = true;
            // 
            // FacultyDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 617);
            this.ControlBox = false;
            this.Name = "FacultyDB";
            this.Text = "Faculty Dash Board";
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button students_Btn;
        private System.Windows.Forms.Button class_Btn;
        private System.Windows.Forms.Button exams_Btn;
        private System.Windows.Forms.Button timetable_Btn;
        private System.Windows.Forms.Button results_Btn;
    }
}