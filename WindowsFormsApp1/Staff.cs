using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        Image image;

        //Here we are link up our data base by using Data Context Method 
        //It is responsible for retrival and saving of data
        eduvationdbDataContext eduvationdb = new eduvationdbDataContext();

        //Here We override the methods from sample 2 form
        public override void add_btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel7);
            loadRoles();
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
            if (nameTxt.Text == "") { nameerror_Label.Visible = true; } else { nameerror_Label.Visible = false; }
            if (usernameTxt.Text == "") { unameerror_Label.Visible = true; } else { unameerror_Label.Visible = false; }
            if (passwordTxt.Text == "") { pswderror_Label.Visible = true; } else { pswderror_Label.Visible = false; }
            if (confirmpasswordTxt.Text == "") { cpswderror_Label.Visible = true; } else { cpswderror_Label.Visible = false; }
            if (passwordTxt.Text != confirmpasswordTxt.Text) { mismatchedError_Label.Visible = true; } else { mismatchedError_Label.Visible = false; }
            if (phoneTxt.Text == "") { phoneerror_Label.Visible = true; } else { phoneerror_Label.Visible = false; }
            if (roleDD.SelectedIndex == -1) { roleerror_Label.Visible = true; } else { roleerror_Label.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuserror_Label.Visible = true; } else { statuserror_Label.Visible = false; }

            //Now We made a condition if any of error label is visible it will show a message dialog
            if (nameerror_Label.Visible || unameerror_Label.Visible || pswderror_Label.Visible || cpswderror_Label.Visible
                || mismatchedError_Label.Visible || phoneerror_Label.Visible || roleerror_Label.Visible
                || statuserror_Label.Visible)
            {
                MainClass.MSGBox("Fields with * are mandatory", "ERROR!!", "Error");
            }
            else
            {
                if (edit == 0) //Code For SAVE 
                {
                    if (imgTxt.Text == "")
                    {
                        byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        eduvationdb.staff_insertStaffWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phoneTxt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat);
                        MainClass.MSGBox(nameTxt.Text + " Added Successfully into the System.", "Success", "Success");
                        MainClass.reset_disable(panel7);
                        loadData();
                    }
                    else
                    {
                        byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        MemoryStream ms = new MemoryStream();
                        image.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        eduvationdb.staff_insertStaff(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phoneTxt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat, arr);
                        MainClass.MSGBox(nameTxt.Text + " Added Successfully into the System.", "Success", "Success");
                        MainClass.reset_disable(panel7);
                        loadData();
                    }
                }
                else if (edit == 1) //Code For UPDATE
                {
                    byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                    if (image == null)
                    {
                        eduvationdb.staff_updatetStaffWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phoneTxt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat, staffID);
                        MainClass.MSGBox(nameTxt.Text + " data updated successfully in the system.", "Success", "Success");
                        MainClass.reset_disable(panel7);
                        loadData();
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        image.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        eduvationdb.staff_updatetStaff(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phoneTxt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat, arr, staffID);
                        MainClass.MSGBox(nameTxt.Text + " data updated successfully in the system.", "Success", "Success");
                        MainClass.reset_disable(panel7);
                        loadData();
                    }
                }
            }
        }

        public override void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                eduvationdb.staff_deleteStaff(staffID);
                MainClass.MSGBox(nameTxt.Text + " deleted successfully from the system.", "Success", "Success");
                MainClass.reset_disable(panel7);
                loadData();
            }
        }
        //Mapping of Data
        private void loadData()
        {
            var data = eduvationdb.staff_getStaffDetails();
            userIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            UsernameGV.DataPropertyName = "Username";
            PasswordGV.DataPropertyName = "Password";
            PhoneGV.DataPropertyName = "Phone";
            StatusGV.DataPropertyName = "Status";
            RoleGV.DataPropertyName = "Role";
            roleIDGV.DataPropertyName = "RoleID";
            dataGridView1.DataSource = data;
            MainClass.SNo(dataGridView1, "snoGv");
        }

        // Public method to get Roles data from DataBase
        public void loadRoles()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-991QFRP" + "\\" + "SQLEXPRESS;Initial Catalog=Eduvation SMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("staff_getRoles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            roleDD.DataSource = dt;
            roleDD.DisplayMember = "Role";
            roleDD.ValueMember = "ID";
        }

        //view button
        public override void view_btn_Click(object sender, EventArgs e)
        {
            loadData();
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
            if (passwordTxt.Text != confirmpasswordTxt.Text) { mismatchedError_Label.Visible = true; } else { mismatchedError_Label.Visible = false; }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneerror_Label.Visible = true; } else { phoneerror_Label.Visible = false; }
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
            DialogResult dr = browseImageDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                image = new Bitmap(browseImageDialog.FileName);
                picBox.Image = image;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imgTxt.Text = browseImageDialog.FileName;
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.reset_disable(panel7);
            loadRoles();
        }

        int staffID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.Disable(panel7);
                picBox.Image = null;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UsernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                confirmpasswordTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                roleDD.SelectedValue = row.Cells["roleIDGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();

                var im = (from x in eduvationdb.staffs where x.staff_id == staffID select x.staff_img).First();
                if (im == null)
                {

                }
                else
                {
                    byte[] arr = im.ToArray();
                    MemoryStream ms = new MemoryStream(arr);
                    image = Image.FromStream(ms);
                    picBox.Image = image;
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}