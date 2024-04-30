//Nguyễn Hoàng Thịnh  MSSV:17110372
//Lưu Văn Quận        MSSV:17110355
//Huỳnh Thế Tông      MSSV:17110384
//Trần Phước Khương   MSSV:17110322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASHTABLE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
