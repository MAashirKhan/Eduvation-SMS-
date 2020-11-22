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
    public partial class ClassTimings : Sample2
    {
        public ClassTimings()
        {
            InitializeComponent();
        }

        private void timingNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (timingNameTxt.Text == "") { timingnameerror_Label.Visible = true; } else { timingnameerror_Label.Visible = false; }
        }

        private void dayDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dayDD.SelectedIndex == -1) { dayerror_label.Visible = true; } else { dayerror_label.Visible = false; }
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
            var result = eduvationdb.st_getTimings();
            tIdGV.DataPropertyName = "ID";
            timingNameGV.DataPropertyName = "TimingName";
            startGV.DataPropertyName = "From";
            endGV.DataPropertyName = "To";
            dayGV.DataPropertyName = "Day";
            classIDGV.DataPropertyName = "ClassID";
            classNameGV.DataPropertyName = "Class";
            dataGridView1.DataSource = result;
            MainClass.SNo(dataGridView1, "snoGV");
        }

        public void loadList()
        {
            var li = (from s in eduvationdb.classes select new { s.cls_id, s.cls_name }).ToList();
            li.Insert(0, new { cls_id = 0, cls_name = "Select" });
            classDD.DataSource = li;
            classDD.DisplayMember = "cls_name";
            classDD.ValueMember = "cls_id";
        }

        int timingID;
        public override void save_btn_Click(object sender, EventArgs e)
        {
            if (timingNameTxt.Text == "") { timingnameerror_Label.Visible = true; } else { timingnameerror_Label.Visible = false; }
            if (dayDD.SelectedIndex == -1) { dayerror_label.Visible = true; } else { dayerror_label.Visible = false; }
            //Now We made a condition if any of error label is visible it will show a message dialog
            if (timingnameerror_Label.Visible || dayerror_label.Visible)
            {
                MainClass.MSGBox("Fields with * are mandatory", "ERROR!!", "Error");
            }
            else
            {
                TimeSpan startTime = new TimeSpan(classstart_TimePicker.Value.Hour, classstart_TimePicker.Value.Minute, classstart_TimePicker.Value.Second);
                TimeSpan endTime = new TimeSpan(endclass_TimePicker.Value.Hour, endclass_TimePicker.Value.Minute, endclass_TimePicker.Value.Second);
                if (edit == 0) //Code For SAVE 
                {
                    try
                    {
                        //here the table is come up as a class because we use LINQ method
                        timing t = new timing();

                        eduvationdb.st_insertTimings(timingNameTxt.Text, startTime, endTime, dayDD.SelectedItem.ToString(), Convert.ToInt32(classDD.SelectedValue.ToString()));
                        //Without this class you could not submit the changes to dbs so it is necessary
                        eduvationdb.SubmitChanges();
                        MainClass.MSGBox(timingNameTxt.Text + " Added Successfully.", "Success", "Success");
                        MainClass.reset_disable(panel6);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MainClass.MSGBox(ex.Message, "Error", "Error");
                    }
                }
                else if (edit == 1) //Code For UPDATE
                {
                    eduvationdb.st_updateTimings(timingNameTxt.Text, startTime, endTime, dayDD.SelectedItem.ToString(), timingID, Convert.ToInt32(classDD.SelectedValue.ToString()));
                    //Without this class you could not submit the changes to dbs so it is necessary
                    eduvationdb.SubmitChanges();

                    MainClass.MSGBox(timingNameTxt.Text + " Updated Successfully.", "Success", "Success");
                    MainClass.reset_disable(panel6);
                    loadData();
                }
            }
        }

        public override void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are You sure you want to delete " + timingNameTxt.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    eduvationdb.st_deleteTimings(timingID);
                    MainClass.MSGBox(timingNameTxt.Text + " Deleted Successfully.", "Success", "Success");
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

        private void ClassTimings_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false;
            loadList();
            MainClass.reset_disable(panel6);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.Disable(panel6);
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                timingID = Convert.ToInt32(gridViewRow.Cells["tIdGV"].Value.ToString());
                timingNameTxt.Text = gridViewRow.Cells["timingNameGV"].Value.ToString();
                classstart_TimePicker.Value = Convert.ToDateTime(gridViewRow.Cells["startGV"].Value);
                endclass_TimePicker.Value = Convert.ToDateTime(gridViewRow.Cells["endGV"].Value);
                dayDD.SelectedItem = gridViewRow.Cells["dayGV"].Value.ToString();
                classDD.SelectedValue = gridViewRow.Cells["classIDGV"].Value.ToString();
            }
        }
    }
}
