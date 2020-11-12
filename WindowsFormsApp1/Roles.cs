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
    public partial class Roles : Sample2
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void role_textBox_TextChanged(object sender, EventArgs e)
        {
            if (role_textBox.Text == "")
            {
                roleerrorlabel.Visible = true;
            }
            else
            {
                roleerrorlabel.Visible = false;
            }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) // Here -1 means that it is empty dropdown list
            {
                rolestatuserrorlabel.Visible = true;
            }
            else
            {
                rolestatuserrorlabel.Visible = false;
            }
        }
        //Here we are link up our data base by using Data Context Method 
        //It is responsible for retrival and saving of data
        eduvationdbDataContext eduvationdb = new eduvationdbDataContext();


        /*Here we will declare a variable edit it has default value
           0 but whenever we click on edit button and select any of row it will enable
           the controls and show that particular data for edit.*/
        int edit = 0;
        //Override the methods for search, add, edit, delete and view 
        // We use the overriding concept so we can use these button according to specific page requirement
        //Here We override the methods from sample 2 form
        public override void add_btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel6);
            edit = 0;
        }

        public override void edit_btn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(panel6);
        }


        public override void save_btn_Click(object sender, EventArgs e)
        {
            if (role_textBox.Text == ""){ roleerrorlabel.Visible = true;} else{roleerrorlabel.Visible = false;}
            if (statusDD.SelectedIndex == -1) { rolestatuserrorlabel.Visible = true; } else { rolestatuserrorlabel.Visible = false; }

            //Now We made a condition if any of error label is visible it will show a message dialog
            if (roleerrorlabel.Visible || rolestatuserrorlabel.Visible)
            {
                MainClass.MSGBox("Fields with * are mandatory", "ERROR!!", "Error");
            }
            else
            {
                if (edit == 0) //Code For SAVE 
                {
                    
                    //here the table is come up as a class because we use LINQ method
                    role r = new role();
                    r.rl_name = role_textBox.Text;
                    if (statusDD.SelectedIndex == 0)
                    {
                        r.rl_status = 1; //For Active
                    }
                    else
                    {
                        r.rl_status = 0; //For Inactive
                    }
                    eduvationdb.staff_insertRoles(role_textBox.Text, r.rl_status);
                    //Without this class you could not submit the changes to dbs so it is necessary
                    eduvationdb.SubmitChanges();

                    MainClass.MSGBox(role_textBox.Text+" Added Successfully.", "Success", "Success");
                    MainClass.reset_disable(panel6);
                    loadData();
                }
                else if (edit == 1) //Code For UPDATE
                {
                    //here the table is come up as a class because we use LINQ method
                    byte status;
                    if (statusDD.SelectedIndex == 0)
                    {
                        status = 1; //For Active
                    }
                    else
                    {
                        status = 0; //For Inactive
                    }
                    eduvationdb.staff_updateRoles(role_textBox.Text,status,roleID);
                    //Without this class you could not submit the changes to dbs so it is necessary
                    eduvationdb.SubmitChanges();

                    MainClass.MSGBox(role_textBox.Text + " Updated Successfully.", "Success", "Success");
                    MainClass.reset_disable(panel6);
                    loadData();

                }
            }
        }

        public override void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are You sure you want to delete "+role_textBox.Text+" ?","Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    eduvationdb.staff_deleteRoles(roleID);
                    MainClass.MSGBox(role_textBox.Text + " Deleted Successfully.", "Success", "Success");
                    MainClass.reset_disable(panel6);
                    loadData();

                }
            }
        }

        public override void view_btn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            searchdata();
        }
        private void loadData() 
        {
            var result = eduvationdb.staff_viewRoles();
            roleIdGV.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role"; 
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = result;
            MainClass.SNo(dataGridView1, "snoGV");
        }

        private void searchdata()
        {
            var result = eduvationdb.staff_searchRoles(search_Txtbox.Text);
            roleIdGV.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = result;
            MainClass.SNo(dataGridView1, "snoGV");
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.reset_disable(panel6);
           
        }
        int roleID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(gridViewRow.Cells["roleIDGV"].Value.ToString());
                role_textBox.Text = gridViewRow.Cells["RoleGV"].Value.ToString();
                statusDD.SelectedItem = gridViewRow.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
