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
        
        private void staff_Btn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void class_Btn_Click(object sender, EventArgs e)
        {
            Classes cls = new Classes();
            MainClass.ShowWindow(cls, this, MDI.ActiveForm);
        }

        private void students_Btn_Click(object sender, EventArgs e)
        {
            Students stud = new Students();
            MainClass.ShowWindow(stud, this, MDI.ActiveForm);
        }

        private void exams_Btn_Click(object sender, EventArgs e)
        {
            Exams exm = new Exams();
            MainClass.ShowWindow(exm, this, MDI.ActiveForm);
        }

        private void timetable_Btn_Click(object sender, EventArgs e)
        {
            Time_Table timetbl = new Time_Table();
            MainClass.ShowWindow(timetbl, this, MDI.ActiveForm);
        }

        private void feevoucher_Btn_Click(object sender, EventArgs e)
        {
            Fee_Voucher feevouch = new Fee_Voucher();
            MainClass.ShowWindow(feevouch, this, MDI.ActiveForm);
        }

        private void results_Btn_Click(object sender, EventArgs e)
        {
            Results res = new Results();
            MainClass.ShowWindow(res, this, MDI.ActiveForm);
        }

        private void admission_Btn_Click(object sender, EventArgs e)
        {
            Admissions adm = new Admissions();
            MainClass.ShowWindow(adm, this, MDI.ActiveForm);
        }

        private void subjects_Btn_Click(object sender, EventArgs e)
        {
            Subjects subj = new Subjects();
            MainClass.ShowWindow(subj, this, MDI.ActiveForm);
        }

        private void role_Btn_Click(object sender, EventArgs e)
        {
            Roles rl = new Roles();
            MainClass.ShowWindow(rl, this, MDI.ActiveForm);
        }

        private void section_Btn_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            MainClass.ShowWindow(section, this, MDI.ActiveForm);
        }

        private void classTime_Btn_Click(object sender, EventArgs e)
        {
            ClassTimings timings = new ClassTimings();
            MainClass.ShowWindow(timings, this, MDI.ActiveForm);
        }

        private void Shifts_Btn_Click(object sender, EventArgs e)
        {
            Shifts shift = new Shifts();
            MainClass.ShowWindow(shift, this, MDI.ActiveForm);
        }
    }
}
