using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();

        private void MDI_Load(object sender, EventArgs e)
        {
           
            if (File.Exists(main.path+"\\eduvation"))
            {
                Login obj = new Login();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();

            }
            else
            {
                SignUp obj = new SignUp();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
