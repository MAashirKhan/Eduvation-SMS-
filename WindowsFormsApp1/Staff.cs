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
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        /*Here we will declare a variable edit it has default value
         0 but whenever we click on edit button and select any of row it will enable
        the controls and show that particular data for edit.*/
        int edit = 0;
        //Here We override the methods from sample 2 form
        public override void add_btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel7);
            imgTxt.Enabled = false;
            edit = 0;
        }

        public override void edit_btn_Click(object sender, EventArgs e)
        {
            edit = 1;
            imgTxt.Enabled = false;
            MainClass.Enable(panel7);
        }

        public override void save_btn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == ""){nameerror_Label.Visible = true;} else {nameerror_Label.Visible = false;}
            if (usernameTxt.Text == "") { unameerror_Label.Visible = true; } else { unameerror_Label.Visible = false; }
            if (passwordTxt.Text == "") { pswderror_Label.Visible = true; } else { pswderror_Label.Visible = false; }
            if (confirmpasswordTxt.Text == "") {cpswderror_Label.Visible = true; } else { cpswderror_Label.Visible = false; }
            if (passwordTxt.Text != confirmpasswordTxt.Text) { mismatchedError_Label.Visible = true; } else { mismatchedError_Label.Visible = false; }
            if (phoneTxt.Text == "") { phoneerror_Label.Visible = true; } else { phoneerror_Label.Visible = false; }
            if (genderDD.SelectedIndex == -1) {gendererror_Label.Visible = true; } else { gendererror_Label.Visible = false; }
            if (roleDD.SelectedIndex == -1) { roleerror_Label.Visible = true; } else { roleerror_Label.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuserror_Label.Visible = true; } else { statuserror_Label.Visible = false; }

            //Now We made a condition if any of error label is visible it will show a message dialog
            if (nameerror_Label.Visible || unameerror_Label.Visible || pswderror_Label.Visible || cpswderror_Label.Visible 
                || mismatchedError_Label.Visible || phoneerror_Label.Visible || gendererror_Label.Visible || roleerror_Label.Visible
                || statuserror_Label.Visible)
            {
                MainClass.MSGBox("Fields with * are mandatory", "ERROR!!", "Error");
            }
            else
            {
                if (edit == 0) //Code For SAVE 
                {  
                    
                }
                else if (edit == 1) //Code For UPDATE
                { 
                
                }
            }
        }

        public override void delete_btn_Click(object sender, EventArgs e)
        {

        }

        public override void view_btn_Click(object sender, EventArgs e)
        {

        }

        public override void search_Txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameerror_Label.Visible = true; } else { nameerror_Label.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { unameerror_Label.Visible = true; } else { unameerror_Label.Visible = false; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { pswderror_Label.Visible = true; } else { pswderror_Label.Visible = false; }
        }

        private void confirmpasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (confirmpasswordTxt.Text == "") { cpswderror_Label.Visible = true; } else { cpswderror_Label.Visible = false; }
        }

        private void confirmpasswordTxt_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTxt.Text != confirmpasswordTxt.Text) { mismatchedError_Label.Visible = true; } else { mismatchedError_Label.Visible = false;}
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneerror_Label.Visible = true; } else { phoneerror_Label.Visible = false; }
        }

        private void genderDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderDD.SelectedIndex == -1) { gendererror_Label.Visible = true; } else { gendererror_Label.Visible = false; }
        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1) { roleerror_Label.Visible = true; } else { roleerror_Label.Visible = false; }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) { statuserror_Label.Visible = true; } else { statuserror_Label.Visible = false; }
        }

        private void browse_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Image";
            //Select Format
            fileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF;";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = new Bitmap(fileDialog.FileName);
                picBox.Image = image;
                imgTxt.Text = fileDialog.FileName;

            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.reset_disable(panel7);
        }
    }
}
