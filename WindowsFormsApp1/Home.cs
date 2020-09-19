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

        private void class_Btn_Click(object sender, EventArgs e)
        {
            Classes cls = new Classes();
            cls.WindowState = FormWindowState.Maximized;
            main.ShowWindow(cls, this, MDI.ActiveForm);
        }

        private void students_Btn_Click(object sender, EventArgs e)
        {
            Students stud = new Students();
            stud.WindowState = FormWindowState.Maximized;
            main.ShowWindow(stud, this, MDI.ActiveForm);
        }

        private void exams_Btn_Click(object sender, EventArgs e)
        {
            Exams exm = new Exams();
            exm.WindowState = FormWindowState.Maximized;
            main.ShowWindow(exm, this, MDI.ActiveForm);
        }

        private void timetable_Btn_Click(object sender, EventArgs e)
        {
            Time_Table timetbl = new Time_Table();
            timetbl.WindowState = FormWindowState.Maximized;
            main.ShowWindow(timetbl, this, MDI.ActiveForm);
        }

        private void feevoucher_Btn_Click(object sender, EventArgs e)
        {
            Fee_Voucher feevouch = new Fee_Voucher();
            feevouch.WindowState = FormWindowState.Maximized;
            main.ShowWindow(feevouch, this, MDI.ActiveForm);
        }

        private void results_Btn_Click(object sender, EventArgs e)
        {
            Results res = new Results();
            res.WindowState = FormWindowState.Maximized;
            main.ShowWindow(res, this, MDI.ActiveForm);
        }

        private void admission_Btn_Click(object sender, EventArgs e)
        {
            Admissions adm = new Admissions();
            adm.WindowState = FormWindowState.Maximized;
            main.ShowWindow(adm, this, MDI.ActiveForm);
        }

        private void subjects_Btn_Click(object sender, EventArgs e)
        {
            Subjects subj = new Subjects();
            subj.WindowState = FormWindowState.Maximized;
            main.ShowWindow(subj, this, MDI.ActiveForm);
        }

        private void role_Btn_Click(object sender, EventArgs e)
        {
            Roles rl = new Roles();
            rl.WindowState = FormWindowState.Maximized;
            main.ShowWindow(rl, this, MDI.ActiveForm);
        }
    }
}
