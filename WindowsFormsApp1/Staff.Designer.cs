namespace WindowsFormsApp1
{
    partial class Staff
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
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmpasswordTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genderDD = new System.Windows.Forms.ComboBox();
            this.roleDD = new System.Windows.Forms.ComboBox();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browse_Btn = new System.Windows.Forms.Button();
            this.image_label = new System.Windows.Forms.Label();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.nameerror_Label = new System.Windows.Forms.Label();
            this.unameerror_Label = new System.Windows.Forms.Label();
            this.pswderror_Label = new System.Windows.Forms.Label();
            this.cpswderror_Label = new System.Windows.Forms.Label();
            this.phoneerror_Label = new System.Windows.Forms.Label();
            this.gendererror_Label = new System.Windows.Forms.Label();
            this.roleerror_Label = new System.Windows.Forms.Label();
            this.statuserror_Label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftpanel.Size = new System.Drawing.Size(342, 1050);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(342, 978);
            this.panel6.Controls.SetChildIndex(this.panel7, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightpanel.Size = new System.Drawing.Size(1100, 1050);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(1100, 977);
            // 
            // panel5
            // 
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(1100, 73);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(35, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 54);
            this.label10.TabIndex = 33;
            this.label10.Text = "Staff\'s Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(24, 37);
            this.nameTxt.MaxLength = 40;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(300, 29);
            this.nameTxt.TabIndex = 18;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Username";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(24, 294);
            this.phoneTxt.MaxLength = 15;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(300, 29);
            this.phoneTxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            // 
            // confirmpasswordTxt
            // 
            this.confirmpasswordTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordTxt.Location = new System.Drawing.Point(24, 231);
            this.confirmpasswordTxt.MaxLength = 30;
            this.confirmpasswordTxt.Name = "confirmpasswordTxt";
            this.confirmpasswordTxt.PasswordChar = '•';
            this.confirmpasswordTxt.Size = new System.Drawing.Size(300, 29);
            this.confirmpasswordTxt.TabIndex = 22;
            this.confirmpasswordTxt.TextChanged += new System.EventHandler(this.confirmpasswordTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Confirm Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(24, 166);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '•';
            this.passwordTxt.Size = new System.Drawing.Size(300, 29);
            this.passwordTxt.TabIndex = 24;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone Number";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(24, 100);
            this.usernameTxt.MaxLength = 40;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(300, 29);
            this.usernameTxt.TabIndex = 26;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Role";
            // 
            // genderDD
            // 
            this.genderDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderDD.FormattingEnabled = true;
            this.genderDD.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderDD.Location = new System.Drawing.Point(22, 355);
            this.genderDD.Name = "genderDD";
            this.genderDD.Size = new System.Drawing.Size(301, 29);
            this.genderDD.TabIndex = 29;
            // 
            // roleDD
            // 
            this.roleDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDD.FormattingEnabled = true;
            this.roleDD.Location = new System.Drawing.Point(22, 417);
            this.roleDD.Name = "roleDD";
            this.roleDD.Size = new System.Drawing.Size(301, 29);
            this.roleDD.TabIndex = 30;
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.statusDD.Location = new System.Drawing.Point(22, 477);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(301, 29);
            this.statusDD.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Status";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.browse_Btn);
            this.panel7.Controls.Add(this.image_label);
            this.panel7.Controls.Add(this.imgTxt);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.statusDD);
            this.panel7.Controls.Add(this.roleDD);
            this.panel7.Controls.Add(this.genderDD);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.usernameTxt);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.passwordTxt);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.confirmpasswordTxt);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.phoneTxt);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.nameTxt);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.nameerror_Label);
            this.panel7.Controls.Add(this.unameerror_Label);
            this.panel7.Controls.Add(this.pswderror_Label);
            this.panel7.Controls.Add(this.cpswderror_Label);
            this.panel7.Controls.Add(this.phoneerror_Label);
            this.panel7.Controls.Add(this.gendererror_Label);
            this.panel7.Controls.Add(this.roleerror_Label);
            this.panel7.Controls.Add(this.statuserror_Label);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 901);
            this.panel7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 646);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // browse_Btn
            // 
            this.browse_Btn.BackColor = System.Drawing.Color.DarkGreen;
            this.browse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_Btn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_Btn.Location = new System.Drawing.Point(22, 579);
            this.browse_Btn.Name = "browse_Btn";
            this.browse_Btn.Size = new System.Drawing.Size(300, 45);
            this.browse_Btn.TabIndex = 36;
            this.browse_Btn.Text = "Browse";
            this.browse_Btn.UseVisualStyleBackColor = false;
            // 
            // image_label
            // 
            this.image_label.AutoSize = true;
            this.image_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_label.Location = new System.Drawing.Point(18, 511);
            this.image_label.Name = "image_label";
            this.image_label.Size = new System.Drawing.Size(53, 21);
            this.image_label.TabIndex = 35;
            this.image_label.Text = "Image";
            // 
            // imgTxt
            // 
            this.imgTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgTxt.Location = new System.Drawing.Point(22, 535);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(300, 29);
            this.imgTxt.TabIndex = 34;
            // 
            // nameerror_Label
            // 
            this.nameerror_Label.AutoSize = true;
            this.nameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.nameerror_Label.Location = new System.Drawing.Point(301, 7);
            this.nameerror_Label.Name = "nameerror_Label";
            this.nameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.nameerror_Label.TabIndex = 38;
            this.nameerror_Label.Text = "*";
            this.nameerror_Label.Visible = false;
            // 
            // unameerror_Label
            // 
            this.unameerror_Label.AutoSize = true;
            this.unameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.unameerror_Label.Location = new System.Drawing.Point(301, 73);
            this.unameerror_Label.Name = "unameerror_Label";
            this.unameerror_Label.Size = new System.Drawing.Size(32, 41);
            this.unameerror_Label.TabIndex = 39;
            this.unameerror_Label.Text = "*";
            this.unameerror_Label.Visible = false;
            // 
            // pswderror_Label
            // 
            this.pswderror_Label.AutoSize = true;
            this.pswderror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswderror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.pswderror_Label.Location = new System.Drawing.Point(303, 136);
            this.pswderror_Label.Name = "pswderror_Label";
            this.pswderror_Label.Size = new System.Drawing.Size(32, 41);
            this.pswderror_Label.TabIndex = 40;
            this.pswderror_Label.Text = "*";
            this.pswderror_Label.Visible = false;
            // 
            // cpswderror_Label
            // 
            this.cpswderror_Label.AutoSize = true;
            this.cpswderror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpswderror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.cpswderror_Label.Location = new System.Drawing.Point(303, 203);
            this.cpswderror_Label.Name = "cpswderror_Label";
            this.cpswderror_Label.Size = new System.Drawing.Size(32, 41);
            this.cpswderror_Label.TabIndex = 39;
            this.cpswderror_Label.Text = "*";
            this.cpswderror_Label.Visible = false;
            // 
            // phoneerror_Label
            // 
            this.phoneerror_Label.AutoSize = true;
            this.phoneerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.phoneerror_Label.Location = new System.Drawing.Point(303, 266);
            this.phoneerror_Label.Name = "phoneerror_Label";
            this.phoneerror_Label.Size = new System.Drawing.Size(32, 41);
            this.phoneerror_Label.TabIndex = 41;
            this.phoneerror_Label.Text = "*";
            this.phoneerror_Label.Visible = false;
            // 
            // gendererror_Label
            // 
            this.gendererror_Label.AutoSize = true;
            this.gendererror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendererror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.gendererror_Label.Location = new System.Drawing.Point(302, 325);
            this.gendererror_Label.Name = "gendererror_Label";
            this.gendererror_Label.Size = new System.Drawing.Size(32, 41);
            this.gendererror_Label.TabIndex = 42;
            this.gendererror_Label.Text = "*";
            this.gendererror_Label.Visible = false;
            // 
            // roleerror_Label
            // 
            this.roleerror_Label.AutoSize = true;
            this.roleerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.roleerror_Label.Location = new System.Drawing.Point(302, 389);
            this.roleerror_Label.Name = "roleerror_Label";
            this.roleerror_Label.Size = new System.Drawing.Size(32, 41);
            this.roleerror_Label.TabIndex = 43;
            this.roleerror_Label.Text = "*";
            this.roleerror_Label.Visible = false;
            // 
            // statuserror_Label
            // 
            this.statuserror_Label.AutoSize = true;
            this.statuserror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.statuserror_Label.Location = new System.Drawing.Point(303, 448);
            this.statuserror_Label.Name = "statuserror_Label";
            this.statuserror_Label.Size = new System.Drawing.Size(32, 41);
            this.statuserror_Label.TabIndex = 44;
            this.statuserror_Label.Text = "*";
            this.statuserror_Label.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 1050);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff";
            this.Text = "Staff";
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.ComboBox roleDD;
        private System.Windows.Forms.ComboBox genderDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmpasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label image_label;
        private System.Windows.Forms.TextBox imgTxt;
        private System.Windows.Forms.Button browse_Btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameerror_Label;
        private System.Windows.Forms.Label unameerror_Label;
        private System.Windows.Forms.Label pswderror_Label;
        private System.Windows.Forms.Label cpswderror_Label;
        private System.Windows.Forms.Label phoneerror_Label;
        private System.Windows.Forms.Label gendererror_Label;
        private System.Windows.Forms.Label roleerror_Label;
        private System.Windows.Forms.Label statuserror_Label;
    }
}