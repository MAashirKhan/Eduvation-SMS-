using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUp : Sample
    {
        public SignUp()
        {
            InitializeComponent();
        }
        //Query accross the signup to check that all fields must filled.

        //String Builder
        StringBuilder sb = new StringBuilder();

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                if (datasourceTxt.Text == "") { datasourceerrorlabel.Visible = true; } else { datasourceerrorlabel.Visible = false; };
                if (dbsTxt.Text == "") { dbserrorlabel.Visible = true; } else { dbserrorlabel.Visible = false; };
                if(datasourceerrorlabel.Visible || dbserrorlabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("DataSource= "+datasourceTxt+"; Initial Catalog= "+dbsTxt+"; Integrated Security= true; MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path+"\\eduvation", sb.ToString());
                    DialogResult dr = MessageBox.Show("Sign Up Successfully!", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if(dr == DialogResult.OK)
                    {
                        Login Log = new Login();
                        MainClass.ShowWindow(Log, this, MDI.ActiveForm);
                    }

                }
            }
            else
            {
                if (datasourceTxt.Text == "") { datasourceerrorlabel.Visible = true; } else { datasourceerrorlabel.Visible = false; };
                if (dbsTxt.Text == "") { dbserrorlabel.Visible = true; } else { dbserrorlabel.Visible = false; };
                if (usernameTxt.Text == "") { usernameerrorlabel.Visible = true; } else { usernameerrorlabel.Visible = false; };
                if (passwordTxt.Text == "") { passworderrorlabel.Visible = true; } else { passworderrorlabel.Visible = false; };
                if (datasourceerrorlabel.Visible || dbserrorlabel.Visible || usernameerrorlabel.Visible || passworderrorlabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("DataSource= " + datasourceTxt.Text + "; Initial Catalog= " + dbsTxt.Text +"; User ID= "+usernameTxt.Text +"; Password= "+passwordTxt.Text +"; MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\eduvation", sb.ToString());
                    DialogResult dr = MessageBox.Show("Sign Up Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login Log = new Login();
                        MainClass.ShowWindow(Log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void datasourceTxt_TextChanged(object sender, EventArgs e)
        {
            if (datasourceTxt.Text == ""){datasourceerrorlabel.Visible = true;}else{datasourceerrorlabel.Visible = false;}
        }

        private void dbsTxt_TextChanged(object sender, EventArgs e)
        {
            if (dbsTxt.Text == "")
            {
                dbserrorlabel.Visible = true;

            }
            else
            {
                dbserrorlabel.Visible = false;
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameerrorlabel.Visible = true;

            }
            else
            {
                usernameerrorlabel.Visible = false;
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            {
                passworderrorlabel.Visible = true;

            }
            else
            {
                passworderrorlabel.Visible = false;
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                usernameTxt.Text = "";
                usernameTxt.Enabled = false;
                usernameerrorlabel.Visible = false;

                passwordTxt.Text = "";
                passwordTxt.Enabled = false;
                passworderrorlabel.Visible = false;
            }
            else
            {
                usernameTxt.Enabled = true;
                passwordTxt.Enabled = true;
            }
            
            
            
        }
    }
}
