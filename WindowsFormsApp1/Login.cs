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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        MainClass main = new MainClass();

        private void login_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            main.ShowWindow(home, this, MDI.ActiveForm);
        }
    }
}
