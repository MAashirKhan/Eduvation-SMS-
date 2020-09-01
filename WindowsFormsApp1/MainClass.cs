using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Class For Get the path of the Folder
    class MainClass
    {
      public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Method For Open and Close Form Window you have to give three parameters here
        // Opening Win , Closing Win and Parent Win which we also called MDI


        public void ShowWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }

    }
    
}
