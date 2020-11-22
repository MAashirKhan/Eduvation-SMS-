using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        MainClass main = new MainClass();

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { loginusernameerrorlabel.Visible = true; } else { loginusernameerrorlabel.Visible = false; }
            if (passwordTxt.Text == "") { passworderrorlabel.Visible = true; } else { passworderrorlabel.Visible = false; }

            if (loginusernameerrorlabel.Visible || passworderrorlabel.Visible)
            {
                MainClass.MSGBox("Field with * are mandatory.", "Error", "Error");
            }
            else
            {
                if (main.GetStaffLogin(usernameTxt.Text, passwordTxt.Text))
                {
                    if (MainClass.STAFFROLE == "Faculty")
                    {
                        FacultyDB facDB = new FacultyDB();
                        MainClass.ShowWindow(facDB, this, MDI.ActiveForm);
                    }
                    else if (MainClass.STAFFROLE == "Admin")
                    {
                        Home home = new Home();
                        MainClass.ShowWindow(home, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MainClass.MSGBox("Invalid Username OR Password", "Error", "Error");
                }
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                loginusernameerrorlabel.Visible = true;
            }
            else
            {
                loginusernameerrorlabel.Visible = false;
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

        private void Login_Load(object sender, EventArgs e)
        {
            MDI m = new MDI();
            m.lOGOUTToolStripMenuItem.Enabled = false;
        }
    }
}