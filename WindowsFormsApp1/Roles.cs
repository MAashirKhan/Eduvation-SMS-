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


        //Override the methods for search, add, edit, delete and view 
        // We use the overriding concept so we can use these button according to specific page requirement
        public override void add_btn_Click(object sender, EventArgs e)
        {

        }

        public override void edit_btn_Click(object sender, EventArgs e)
        {

        }

        public override void save_btn_Click(object sender, EventArgs e)
        {

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
    }
}
