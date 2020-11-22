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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.browse_Btn = new System.Windows.Forms.Button();
            this.image_label = new System.Windows.Forms.Label();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.roleDD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmpasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameerror_Label = new System.Windows.Forms.Label();
            this.unameerror_Label = new System.Windows.Forms.Label();
            this.pswderror_Label = new System.Windows.Forms.Label();
            this.cpswderror_Label = new System.Windows.Forms.Label();
            this.phoneerror_Label = new System.Windows.Forms.Label();
            this.roleerror_Label = new System.Windows.Forms.Label();
            this.statuserror_Label = new System.Windows.Forms.Label();
            this.mismatchedError_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
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
            this.leftpanel.Size = new System.Drawing.Size(228, 545);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(228, 473);
            this.panel6.Controls.SetChildIndex(this.panel7, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Margin = new System.Windows.Forms.Padding(1);
            this.rightpanel.Size = new System.Drawing.Size(781, 545);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(781, 500);
            this.panel4.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel5
            // 
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(781, 45);
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
            // panel7
            // 
            this.panel7.Controls.Add(this.picBox);
            this.panel7.Controls.Add(this.browse_Btn);
            this.panel7.Controls.Add(this.image_label);
            this.panel7.Controls.Add(this.imgTxt);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.statusDD);
            this.panel7.Controls.Add(this.roleDD);
            this.panel7.Controls.Add(this.label8);
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
            this.panel7.Controls.Add(this.roleerror_Label);
            this.panel7.Controls.Add(this.statuserror_Label);
            this.panel7.Controls.Add(this.mismatchedError_Label);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 38);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 435);
            this.panel7.TabIndex = 1;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(65, 364);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 93);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 72;
            this.picBox.TabStop = false;
            // 
            // browse_Btn
            // 
            this.browse_Btn.BackColor = System.Drawing.Color.DarkGreen;
            this.browse_Btn.FlatAppearance.BorderSize = 2;
            this.browse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_Btn.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_Btn.Location = new System.Drawing.Point(11, 321);
            this.browse_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.browse_Btn.Name = "browse_Btn";
            this.browse_Btn.Size = new System.Drawing.Size(200, 31);
            this.browse_Btn.TabIndex = 63;
            this.browse_Btn.Text = "Browse";
            this.browse_Btn.UseVisualStyleBackColor = false;
            this.browse_Btn.Click += new System.EventHandler(this.browse_Btn_Click);
            // 
            // image_label
            // 
            this.image_label.AutoSize = true;
            this.image_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_label.Location = new System.Drawing.Point(7, 274);
            this.image_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.image_label.Name = "image_label";
            this.image_label.Size = new System.Drawing.Size(38, 13);
            this.image_label.TabIndex = 62;
            this.image_label.Text = "Image";
            // 
            // imgTxt
            // 
            this.imgTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgTxt.Location = new System.Drawing.Point(9, 289);
            this.imgTxt.Margin = new System.Windows.Forms.Padding(2);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(201, 22);
            this.imgTxt.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.statusDD.Location = new System.Drawing.Point(9, 251);
            this.statusDD.Margin = new System.Windows.Forms.Padding(2);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(202, 21);
            this.statusDD.TabIndex = 59;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // roleDD
            // 
            this.roleDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDD.FormattingEnabled = true;
            this.roleDD.Location = new System.Drawing.Point(9, 214);
            this.roleDD.Margin = new System.Windows.Forms.Padding(2);
            this.roleDD.Name = "roleDD";
            this.roleDD.Size = new System.Drawing.Size(202, 21);
            this.roleDD.TabIndex = 58;
            this.roleDD.SelectedIndexChanged += new System.EventHandler(this.roleDD_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Role";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(9, 58);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTxt.MaxLength = 40;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(201, 22);
            this.usernameTxt.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Phone Number";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(9, 96);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '•';
            this.passwordTxt.Size = new System.Drawing.Size(201, 22);
            this.passwordTxt.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Confirm Password";
            // 
            // confirmpasswordTxt
            // 
            this.confirmpasswordTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordTxt.Location = new System.Drawing.Point(9, 136);
            this.confirmpasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmpasswordTxt.MaxLength = 30;
            this.confirmpasswordTxt.Name = "confirmpasswordTxt";
            this.confirmpasswordTxt.PasswordChar = '•';
            this.confirmpasswordTxt.Size = new System.Drawing.Size(201, 22);
            this.confirmpasswordTxt.TabIndex = 50;
            this.confirmpasswordTxt.Validating += new System.ComponentModel.CancelEventHandler(this.confirmpasswordTxt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Password";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(9, 175);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTxt.MaxLength = 15;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(201, 22);
            this.phoneTxt.TabIndex = 48;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Username";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(9, 16);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.MaxLength = 40;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(201, 22);
            this.nameTxt.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Name";
            // 
            // nameerror_Label
            // 
            this.nameerror_Label.AutoSize = true;
            this.nameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.nameerror_Label.Location = new System.Drawing.Point(193, -2);
            this.nameerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameerror_Label.Name = "nameerror_Label";
            this.nameerror_Label.Size = new System.Drawing.Size(21, 28);
            this.nameerror_Label.TabIndex = 64;
            this.nameerror_Label.Text = "*";
            this.nameerror_Label.Visible = false;
            // 
            // unameerror_Label
            // 
            this.unameerror_Label.AutoSize = true;
            this.unameerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.unameerror_Label.Location = new System.Drawing.Point(193, 38);
            this.unameerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unameerror_Label.Name = "unameerror_Label";
            this.unameerror_Label.Size = new System.Drawing.Size(21, 28);
            this.unameerror_Label.TabIndex = 65;
            this.unameerror_Label.Text = "*";
            this.unameerror_Label.Visible = false;
            // 
            // pswderror_Label
            // 
            this.pswderror_Label.AutoSize = true;
            this.pswderror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswderror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.pswderror_Label.Location = new System.Drawing.Point(195, 77);
            this.pswderror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pswderror_Label.Name = "pswderror_Label";
            this.pswderror_Label.Size = new System.Drawing.Size(21, 28);
            this.pswderror_Label.TabIndex = 67;
            this.pswderror_Label.Text = "*";
            this.pswderror_Label.Visible = false;
            // 
            // cpswderror_Label
            // 
            this.cpswderror_Label.AutoSize = true;
            this.cpswderror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpswderror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.cpswderror_Label.Location = new System.Drawing.Point(195, 119);
            this.cpswderror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpswderror_Label.Name = "cpswderror_Label";
            this.cpswderror_Label.Size = new System.Drawing.Size(21, 28);
            this.cpswderror_Label.TabIndex = 66;
            this.cpswderror_Label.Text = "*";
            this.cpswderror_Label.Visible = false;
            // 
            // phoneerror_Label
            // 
            this.phoneerror_Label.AutoSize = true;
            this.phoneerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.phoneerror_Label.Location = new System.Drawing.Point(195, 158);
            this.phoneerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneerror_Label.Name = "phoneerror_Label";
            this.phoneerror_Label.Size = new System.Drawing.Size(21, 28);
            this.phoneerror_Label.TabIndex = 68;
            this.phoneerror_Label.Text = "*";
            this.phoneerror_Label.Visible = false;
            // 
            // roleerror_Label
            // 
            this.roleerror_Label.AutoSize = true;
            this.roleerror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleerror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.roleerror_Label.Location = new System.Drawing.Point(196, 197);
            this.roleerror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleerror_Label.Name = "roleerror_Label";
            this.roleerror_Label.Size = new System.Drawing.Size(21, 28);
            this.roleerror_Label.TabIndex = 70;
            this.roleerror_Label.Text = "*";
            this.roleerror_Label.Visible = false;
            // 
            // statuserror_Label
            // 
            this.statuserror_Label.AutoSize = true;
            this.statuserror_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserror_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.statuserror_Label.Location = new System.Drawing.Point(197, 234);
            this.statuserror_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statuserror_Label.Name = "statuserror_Label";
            this.statuserror_Label.Size = new System.Drawing.Size(21, 28);
            this.statuserror_Label.TabIndex = 71;
            this.statuserror_Label.Text = "*";
            this.statuserror_Label.Visible = false;
            // 
            // mismatchedError_Label
            // 
            this.mismatchedError_Label.AutoSize = true;
            this.mismatchedError_Label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mismatchedError_Label.ForeColor = System.Drawing.Color.Red;
            this.mismatchedError_Label.Location = new System.Drawing.Point(101, 121);
            this.mismatchedError_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mismatchedError_Label.Name = "mismatchedError_Label";
            this.mismatchedError_Label.Size = new System.Drawing.Size(80, 13);
            this.mismatchedError_Label.TabIndex = 73;
            this.mismatchedError_Label.Text = "MISMATCHED";
            this.mismatchedError_Label.Visible = false;
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
            this.groupBox2.Size = new System.Drawing.Size(781, 450);
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
            this.roleIDGV,
            this.userIDGV,
            this.NameGV,
            this.UsernameGV,
            this.PasswordGV,
            this.CPasswordGV,
            this.PhoneGV,
            this.RoleGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
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
            this.dataGridView1.Size = new System.Drawing.Size(777, 428);
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
            // roleIDGV
            // 
            this.roleIDGV.HeaderText = "RoleID";
            this.roleIDGV.Name = "roleIDGV";
            this.roleIDGV.ReadOnly = true;
            this.roleIDGV.Visible = false;
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "User ID";
            this.userIDGV.MinimumWidth = 8;
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 8;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            this.UsernameGV.HeaderText = "User Name";
            this.UsernameGV.MinimumWidth = 8;
            this.UsernameGV.Name = "UsernameGV";
            this.UsernameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Pswd";
            this.PasswordGV.MinimumWidth = 8;
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // CPasswordGV
            // 
            this.CPasswordGV.HeaderText = "CPswd";
            this.CPasswordGV.MinimumWidth = 8;
            this.CPasswordGV.Name = "CPasswordGV";
            this.CPasswordGV.ReadOnly = true;
            this.CPasswordGV.Visible = false;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.MinimumWidth = 8;
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
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
            // browseImageDialog
            // 
            this.browseImageDialog.FileName = "browseImageDialog";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 545);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button browse_Btn;
        private System.Windows.Forms.Label image_label;
        private System.Windows.Forms.TextBox imgTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.ComboBox roleDD;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Label nameerror_Label;
        private System.Windows.Forms.Label unameerror_Label;
        private System.Windows.Forms.Label pswderror_Label;
        private System.Windows.Forms.Label cpswderror_Label;
        private System.Windows.Forms.Label phoneerror_Label;
        private System.Windows.Forms.Label roleerror_Label;
        private System.Windows.Forms.Label statuserror_Label;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label mismatchedError_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog browseImageDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}