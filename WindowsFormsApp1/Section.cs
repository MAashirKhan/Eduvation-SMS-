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
    public partial class Section : Sample2
    {
        public Section()
        {
            InitializeComponent();
        }

        private void sectionNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (sectionNameTxt.Text == "") { sectionnameerror_Label.Visible = true; } else { sectionnameerror_Label.Visible = false; }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) { statuserror_label.Visible = true; } else { statuserror_label.Visible = false; }
        }

        //Here we are link up our data base by using Data Context Method 
        //It is responsible for retrival and saving of data
        eduvationdbDataContext eduvationdb = new eduvationdbDataContext();

        /*Here we will declare a variable edit it has default value
          0 but whenever we click on edit button and select any of row it will enable
         the controls and show that particular data for edit.*/
        int edit = 0;
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

        private void loadData()
        {
            var result = eduvationdb.st_getSections();
            SectionIDGV.DataPropertyName = "ID";
            SectionNameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = result;
            MainClass.SNo(dataGridView1, "snoGV");
        }

        //Global variable
        int sectionID;
        public override void save_btn_Click(object sender, EventArgs e)
        {
            if (sectionNameTxt.Text == "") { sectionnameerror_Label.Visible = true; } else { sectionnameerror_Label.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuserror_label.Visible = true; } else { statuserror_label.Visible = false; }

            //Now We made a condition if any of error label is visible it will show a message dialog
            if (sectionnameerror_Label.Visible || statuserror_label.Visible )
            {
                MainClass.MSGBox("Fields with * are mandatory", "ERROR!!", "Error");
            }
            else
            {
                if (edit == 0) //Code For SAVE 
                {
                    //here the table is come up as a class because we use LINQ method
                    section s = new section();
             
                    if (statusDD.SelectedIndex == 0)
                    {
                        s.sec_status = 1; //For Active
                    }
                    else
                    {
                        s.sec_status = 0; //For Inactive
                    }
                    eduvationdb.st_insertSections(sectionNameTxt.Text, s.sec_status);
                    //Without this class you could not submit the changes to dbs so it is necessary
                    eduvationdb.SubmitChanges();

                    MainClass.MSGBox(sectionNameTxt.Text + " Added Successfully.", "Success", "Success");
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
                    eduvationdb.st_updateSections(sectionNameTxt.Text, status, sectionID);
                    //Without this class you could not submit the changes to dbs so it is necessary
                    eduvationdb.SubmitChanges();

                    MainClass.MSGBox(sectionNameTxt.Text + " Updated Successfully.", "Success", "Success");
                    MainClass.reset_disable(panel6);
                    loadData();
                }
            }
        }

        public override void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are You sure you want to delete " + sectionNameTxt.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    eduvationdb.st_deleteSection(sectionID);
                    MainClass.MSGBox(sectionNameTxt.Text + " Deleted Successfully.", "Success", "Success");
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

        }

        private void Section_Load(object sender, EventArgs e)
        {
            MainClass.reset_disable(panel6);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                sectionID = Convert.ToInt32(gridViewRow.Cells["SectionIDGV"].Value.ToString());
                sectionNameTxt.Text = gridViewRow.Cells["SectionNameGV"].Value.ToString();
                statusDD.SelectedItem = gridViewRow.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}