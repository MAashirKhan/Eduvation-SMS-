namespace WindowsFormsApp1
{
    partial class SignUp
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
            this.signup_btn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbsTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datasourceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datasourceerrorlabel = new System.Windows.Forms.Label();
            this.dbserrorlabel = new System.Windows.Forms.Label();
            this.usernameerrorlabel = new System.Windows.Forms.Label();
            this.passworderrorlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(342, 692);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.isCB);
            this.panel6.Controls.Add(this.dbsTxt);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.datasourceTxt);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.signup_btn);
            this.panel6.Controls.Add(this.passwordTxt);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.usernameTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.datasourceerrorlabel);
            this.panel6.Controls.Add(this.dbserrorlabel);
            this.panel6.Controls.Add(this.usernameerrorlabel);
            this.panel6.Controls.Add(this.passworderrorlabel);
            this.panel6.Size = new System.Drawing.Size(342, 623);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1132, 692);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1132, 623);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1132, 69);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.signup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signup_btn.FlatAppearance.BorderSize = 3;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.signup_btn.Location = new System.Drawing.Point(55, 536);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(219, 61);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "&SIGN UP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(21, 417);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '•';
            this.passwordTxt.Size = new System.Drawing.Size(297, 31);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(21, 334);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(297, 31);
            this.usernameTxt.TabIndex = 2;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbsTxt
            // 
            this.dbsTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbsTxt.Location = new System.Drawing.Point(21, 252);
            this.dbsTxt.Name = "dbsTxt";
            this.dbsTxt.Size = new System.Drawing.Size(297, 31);
            this.dbsTxt.TabIndex = 1;
            this.dbsTxt.TextChanged += new System.EventHandler(this.dbsTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "DataBase";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datasourceTxt
            // 
            this.datasourceTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.datasourceTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasourceTxt.Location = new System.Drawing.Point(20, 171);
            this.datasourceTxt.Name = "datasourceTxt";
            this.datasourceTxt.Size = new System.Drawing.Size(297, 31);
            this.datasourceTxt.TabIndex = 0;
            this.datasourceTxt.TextChanged += new System.EventHandler(this.datasourceTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Source";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isCB.Location = new System.Drawing.Point(20, 471);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(220, 32);
            this.isCB.TabIndex = 4;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datasourceerrorlabel
            // 
            this.datasourceerrorlabel.AutoSize = true;
            this.datasourceerrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasourceerrorlabel.ForeColor = System.Drawing.Color.Green;
            this.datasourceerrorlabel.Location = new System.Drawing.Point(292, 140);
            this.datasourceerrorlabel.Name = "datasourceerrorlabel";
            this.datasourceerrorlabel.Size = new System.Drawing.Size(26, 32);
            this.datasourceerrorlabel.TabIndex = 16;
            this.datasourceerrorlabel.Text = "*";
            this.datasourceerrorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datasourceerrorlabel.Visible = false;
            // 
            // dbserrorlabel
            // 
            this.dbserrorlabel.AutoSize = true;
            this.dbserrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbserrorlabel.ForeColor = System.Drawing.Color.Green;
            this.dbserrorlabel.Location = new System.Drawing.Point(291, 221);
            this.dbserrorlabel.Name = "dbserrorlabel";
            this.dbserrorlabel.Size = new System.Drawing.Size(26, 32);
            this.dbserrorlabel.TabIndex = 17;
            this.dbserrorlabel.Text = "*";
            this.dbserrorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dbserrorlabel.Visible = false;
            // 
            // usernameerrorlabel
            // 
            this.usernameerrorlabel.AutoSize = true;
            this.usernameerrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameerrorlabel.ForeColor = System.Drawing.Color.Green;
            this.usernameerrorlabel.Location = new System.Drawing.Point(291, 303);
            this.usernameerrorlabel.Name = "usernameerrorlabel";
            this.usernameerrorlabel.Size = new System.Drawing.Size(26, 32);
            this.usernameerrorlabel.TabIndex = 17;
            this.usernameerrorlabel.Text = "*";
            this.usernameerrorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameerrorlabel.Visible = false;
            // 
            // passworderrorlabel
            // 
            this.passworderrorlabel.AutoSize = true;
            this.passworderrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworderrorlabel.ForeColor = System.Drawing.Color.Green;
            this.passworderrorlabel.Location = new System.Drawing.Point(291, 386);
            this.passworderrorlabel.Name = "passworderrorlabel";
            this.passworderrorlabel.Size = new System.Drawing.Size(26, 32);
            this.passworderrorlabel.TabIndex = 18;
            this.passworderrorlabel.Text = "*";
            this.passworderrorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passworderrorlabel.Visible = false;
            // 
            // SignUp
            // 
            this.AcceptButton = this.signup_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 692);
            this.ControlBox = false;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbsTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datasourceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datasourceerrorlabel;
        private System.Windows.Forms.Label dbserrorlabel;
        private System.Windows.Forms.Label usernameerrorlabel;
        private System.Windows.Forms.Label passworderrorlabel;
    }
}