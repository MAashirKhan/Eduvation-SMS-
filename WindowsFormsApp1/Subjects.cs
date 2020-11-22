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
    public partial class Subjects : Sample2
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void subjectNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (subjectNameTxt.Text == "") { subjectnameerror_Label.Visible = true; } else { subjectnameerror_Label.Visible = false; }
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
            var result = eduvationdb.st_getSubjects();
            SubjectIDGV.DataPropertyName = "ID";
            SubjectNameGV.DataPropertyName = "Subjects";
            classidGV.DataPropertyName = "ClassID";
            ClassGV.DataPropertyName = "Class";
            dataGridView1.DataSource = result;
            MainClass.SNo(dataGridView1, "snoGV");
        }

        public override void save_btn_Click(object sender, EventArgs e)
        {
            if (subjectNameTxt.Text == "") { subjectnameerror_Label.Visible = true; } else { subjectnameerror_Label.Visible = false; }

            //Now We made a condition if any of error label is visible it will show a message dialog
            if (subjectnameerror_Label.Visible)
            {
                MainClass.MSGBox("Fields with * are mandatory", "ERROR!!", "Error");
            }
            else
            {
                if (edit == 0) //Code For SAVE 
                {
                    try
                    {
                        //here the table is come up as a class because we use LINQ method
                        subject s = new subject();

                        eduvationdb.st_insertSubject(subjectNameTxt.Text, Convert.ToInt32(classDD.SelectedValue.ToString()));
                        //Without this class you could not submit the changes to dbs so it is necessary
                        eduvationdb.SubmitChanges();
                        MainClass.MSGBox(subjectNameTxt.Text + " Added Successfully.", "Success", "Success");
                        MainClass.reset_disable(panel6);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MainClass.MSGBox("Possible Errors\n\n1.Are you trying to add same subject in this class?\n2.Contact Technical Support for Assisitance.\nwebisoftpak@gmail.com", "Error", "Error");
                    }
                }
                else if (edit == 1) //Code For UPDATE
                {
                    eduvationdb.st_updateSubject(subjectNameTxt.Text, Convert.ToInt32(classDD.SelectedValue.ToString()), subjectID);
                    //Without this class you could not submit the changes to dbs so it is necessary
                    eduvationdb.SubmitChanges();

                    MainClass.MSGBox(subjectNameTxt.Text + " Updated Successfully.", "Success", "Success");
                    MainClass.reset_disable(panel6);
                    loadData();
                }
            }
        }

        public override void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are You sure you want to delete " + subjectNameTxt.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    eduvationdb.st_deleteSubject(subjectID);
                    MainClass.MSGBox(subjectNameTxt.Text + " Deleted Successfully.", "Success", "Success");
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

        public void loadList()
        {
            var li = (from s in eduvationdb.classes select new { s.cls_id, s.cls_name }).ToList();
            li.Insert(0, new { cls_id = 0, cls_name = "Select" });
            classDD.DataSource = li;
            classDD.DisplayMember = "cls_name";
            classDD.ValueMember = "cls_id";
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            loadList();
            MainClass.reset_disable(panel6);
        }

        int subjectID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.Disable(panel6);
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                subjectID = Convert.ToInt32(gridViewRow.Cells["SubjectIDGV"].Value.ToString());
                subjectNameTxt.Text = gridViewRow.Cells["SubjectNameGV"].Value.ToString();
                classDD.SelectedValue = gridViewRow.Cells["classidGV"].Value;
            }
        }
    }
}