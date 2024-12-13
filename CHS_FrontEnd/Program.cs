using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_FrontEnd
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            frmLogin frm = new frmLogin();   
            if (frm.ShowDialog() != DialogResult.OK) return;


            Application.Run(new Mainfrm());
        }
    }
}
