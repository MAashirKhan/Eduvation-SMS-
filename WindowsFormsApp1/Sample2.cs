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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        public virtual void add_btn_Click(object sender, EventArgs e)
        {

        }

        public virtual void edit_btn_Click(object sender, EventArgs e)
        {

        }

        public virtual void save_btn_Click(object sender, EventArgs e)
        {

        }

        public virtual void delete_btn_Click(object sender, EventArgs e)
        {

        }

        public virtual void view_btn_Click(object sender, EventArgs e)
        {

        }

        public virtual void search_Txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        MainClass main = new MainClass();
        private void back_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            main.ShowWindow(home, this, MDI.ActiveForm);

        }
    }
}
