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
                    //Here we are link up our data base by using Data Context Method 
                    //It is responsible for retrival and saving of data
                    eduvationdbDataContext eduvationdb = new eduvationdbDataContext();
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

        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.reset_disable(panel6);
        }
    }
}
