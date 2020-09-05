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
    public partial class Home : Sample
    {
        public Home()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void staff_Btn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.WindowState = FormWindowState.Maximized;
            main.ShowWindow(st, this, MDI.ActiveForm);
        }
    }
}
