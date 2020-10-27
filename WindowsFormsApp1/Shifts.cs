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
    public partial class Shifts : Sample2
    {
        public Shifts()
        {
            InitializeComponent();
        }

        private void shiftNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (shiftNameTxt.Text == "") { shiftnameerror_Label.Visible = true; } else { shiftnameerror_Label.Visible = false; }
        }

        private void shiftslotsDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shiftslotsDD.SelectedIndex == -1) { shiftsloterror_label.Visible = true; } else { shiftsloterror_label.Visible = false; }
        }

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

        public override void save_btn_Click(object sender, EventArgs e)
        {
            if (shiftNameTxt.Text == "") { shiftnameerror_Label.Visible = true; } else { shiftnameerror_Label.Visible = false; }
            if (shiftslotsDD.SelectedIndex == -1) { shiftsloterror_label.Visible = true; } else { shiftsloterror_label.Visible = false; }

            //Now We made a condition if any of error label is visible it will show a message dialog
            if (shiftnameerror_Label.Visible || shiftsloterror_label.Visible)
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

        private void Shifts_Load(object sender, EventArgs e)
        {
            MainClass.reset_disable(panel6);
        }
    }
}
